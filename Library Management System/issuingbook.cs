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
using System.IO;

namespace Library_Management_System
{
    public partial class issuingbook : Form
    {
        public issuingbook()
        {
            InitializeComponent();
        }

        private void searchmbrbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            timer1.Start();
            
        }

        private void issuingbook_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            okbutton.Hide();
            progressBar1.Hide();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            okbutton.Hide();
        }

        private void savembrbutton_Click(object sender, EventArgs e)
        {
            if ((namembrtextBox.Text == "") || (booknametextBox.Text == "") || (dateTimePicker1.Text == "") || (durationcomboBox.Text == "") || (returndatetextBox.Text == ""))
            {
                MessageBox.Show("Please Fill all required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Do you want to save Issuing book record in a file also or a database only?\n Click Yes for save in text file also\n Click No for save in database only", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter strw = new StreamWriter("E:\\win part\\Discrete Mathematics\\Project\\issuingbook.txt", true))
                    {

                        strw.Write(namembrtextBox.Text + "\t");
                        strw.Write(booknametextBox.Text + "\t");
                        strw.Write(dateTimePicker1.Text + "\t");
                        strw.Write(durationcomboBox.Text + "\t");
                        strw.WriteLine(returndatetextBox.Text + "\t");
                        strw.Close();
                        MessageBox.Show("Book Issued Successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [issuingbook]
           ([Name]
           ,[BookName]
           ,[Date]
           ,[Duration]
           ,[ReturnDate])
     VALUES
           ('" + namembrtextBox.Text + "','" + booknametextBox.Text + "','" + dateTimePicker1.Text + "','" + durationcomboBox.Text + "','" + returndatetextBox.Text + "')", conec);

                    cmd.ExecuteNonQuery();
                    conec.Close();
                    namembrtextBox.Clear();
                    booknametextBox.Clear();
                    durationcomboBox.SelectedIndex = -1;
                    returndatetextBox.Clear();

                }
                else
                {
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [issuingbook]
           ([Name]
           ,[BookName]
           ,[Date]
           ,[Duration]
           ,[ReturnDate])
     VALUES
           ('" + namembrtextBox.Text + "','" + booknametextBox.Text + "','" + dateTimePicker1.Text + "','" + durationcomboBox.Text + "','" + returndatetextBox.Text + "')", conec);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conec.Close();
                    namembrtextBox.Clear();
                    booknametextBox.Clear();
                    durationcomboBox.SelectedIndex = -1;
                    returndatetextBox.Clear();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                progressBar1.Hide();
                progressBar1.Value = 0;
                if (searchmbrtextBox.Text == "")
                {
                    MessageBox.Show("Please Ente Member name For Search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = conec.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From members Where Name='" + searchmbrtextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdta = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sdta.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conec.Close();
                    dataGridView1.Show();
                    okbutton.Show();
                }
            }
        }
    }
}
