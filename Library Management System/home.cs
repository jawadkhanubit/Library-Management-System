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
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksrec bookrec = new booksrec();
            bookrec.Show();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            members membersrec = new members();
            membersrec.Show();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            timer1.Start();
        }

        private void main_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            searchdataGridView.Hide();
            okbutton.Hide();
            availabledataGridView.Hide();
            gridokbutton.Hide();
            reclabel.Hide();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            searchdataGridView.Hide();
            okbutton.Hide();
            searchtextBox.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                progressBar1.Hide();
                progressBar1.Value = 0; 
                if (searchtextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Book Title For Search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = conec.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From booksrec Where Title='" + searchtextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdta = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sdta.Fill(dt);
                   
                        searchdataGridView.DataSource = dt;

                        conec.Close();
                        searchdataGridView.Show();
                        okbutton.Show();
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
            conec.Open();
            SqlCommand cmd = conec.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From booksrec Where Availability='Available'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdta = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sdta.Fill(dt);
            availabledataGridView.DataSource = dt;

            conec.Close();
            reclabel.Text = "Total Available Books= " + dt.Rows.Count;
            availabledataGridView.Show();
            gridokbutton.Show();
            reclabel.Show();
        }

        private void gridokbutton_Click(object sender, EventArgs e)
        {
            availabledataGridView.Hide();
            gridokbutton.Hide();
            reclabel.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            issuingbook issb = new issuingbook();
            issb.Show();
        }
    }
}
