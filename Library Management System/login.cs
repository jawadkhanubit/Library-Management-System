using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                conec.Open();
                SqlDataAdapter sd = new SqlDataAdapter("Select  Count(*) From login Where Name='" + nametextbox.Text + "' and Password='" + pastextbox.Text + "' ", conec);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    main lms = new main();
                    lms.Show();
                }
                else
                {
                    MessageBox.Show("Enter Correct Name or Password", "Error");
                    progressBar1.Hide();
                    progressBar1.Value = 0;
                }
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
    }
}