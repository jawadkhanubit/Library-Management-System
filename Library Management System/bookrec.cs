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
    public partial class booksrec : Form
    {
        public booksrec()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (titletextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Title of the Book.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                conec.Open();
                SqlCommand cmd = conec.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From booksrec Where Title ='" + titletextBox.Text + "'";
                cmd.ExecuteNonQuery();
                conec.Close();
                display();
                MessageBox.Show("Book Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void booksrec_Load(object sender, EventArgs e)
        {
            
            treeView1.Hide();
            oktree.Hide();
            expand.Hide();
            dataGridView1.Hide();
            okbutton.Hide();
            titletextBox.Focus();
            saveupdatebutton.Hide();
            reclabel.Hide();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            idtextBox.ReadOnly = true;
            saveupdatebutton.Hide();
            titletextBox.Clear();
            subjecttextBox.Clear();
            publishertextBox.Clear();
            authortextBox.Clear();
            titletextBox.Focus();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if ((titletextBox.Text == "") || (subjecttextBox.Text == "") || (publishertextBox.Text == "") || (authortextBox.Text == "") || (availabilitycomboBox.Text == ""))
            {
                MessageBox.Show("Please Fill all required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Do you want to save in a text file also or a database only?\n Click Yes for save in a file also\n Click No for database only", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter strw = new StreamWriter("E:\\win part\\Discrete Mathematics\\Project\\booksrec.txt", true))
                    {

                        strw.Write(titletextBox.Text + "\t");
                        strw.Write(subjecttextBox.Text + "\t");
                        strw.Write(publishertextBox.Text + "\t");
                        strw.Write(authortextBox.Text + "\t");
                        strw.WriteLine(availabilitycomboBox.Text + "\t");
                        strw.Close();
                        MessageBox.Show("Book Record Entered Successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                        SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                        conec.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[booksrec]
           ([Title]
           ,[Subject]
           ,[Publisher]
           ,[Author]
           ,[Availability])
     VALUES
           ('" + titletextBox.Text + "','" + subjecttextBox.Text + "','" + publishertextBox.Text + "','" + authortextBox.Text + "','" + availabilitycomboBox.Text + "')", conec);

                        cmd.ExecuteNonQuery();
                        conec.Close();

                }
                else
                {
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[booksrec]
           ([Title]
           ,[Subject]
           ,[Publisher]
           ,[Author]
           ,[Availability])
     VALUES
           ('" + titletextBox.Text + "','" + subjecttextBox.Text + "','" + publishertextBox.Text + "','" + authortextBox.Text + "','" + availabilitycomboBox.Text + "')", conec);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Record Entered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conec.Close();
                }
            }
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to display in tree view?", "Display Option", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");

                DataTable dt = new DataTable();
                SqlDataAdapter sdta = new SqlDataAdapter("Select * From [booksrec]",conec);
                sdta.Fill(dt);
                treeView1.Nodes.Add("booksrec");

                foreach(DataRow dr in dt.Rows)
                {
                    TreeNode nod = new TreeNode(dr["Title"].ToString());
                    nod.Nodes.Add(dr["Subject"].ToString());
                    nod.Nodes.Add(dr["Publisher"].ToString());
                    nod.Nodes.Add(dr["Author"].ToString());
                    nod.Nodes.Add(dr["Availability"].ToString());
                    treeView1.Nodes.Add(nod);
                    
                }
                treeView1.Show();
                oktree.Show();
                expand.Show();
            }
            else
            {
                display();
                dataGridView1.Show();
                okbutton.Show();
                reclabel.Show();
            }  
        }



        public void display()
        {
            SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
            conec.Open();
            SqlCommand cmd = conec.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From booksrec";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdta = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sdta.Fill(dt);
            dataGridView1.DataSource = dt;

            conec.Close();
            reclabel.Text="Total Books Record= "+ dt.Rows.Count;

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            idtextBox.ReadOnly = false;
            MessageBox.Show("First enter ID of the book and then all other information about the book which you want to update record.","How to Update?",MessageBoxButtons.OK,MessageBoxIcon.Information);
            idtextBox.Focus();
            saveupdatebutton.Show();
        }

        private void savupdatebutton_Click(object sender, EventArgs e)
        {
            if ((idtextBox.Text=="") || (titletextBox.Text == "") || (subjecttextBox.Text == "") || (publishertextBox.Text == "") || (authortextBox.Text == "") || (availabilitycomboBox.Text == ""))
            {
                MessageBox.Show("Please Fill all required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                conec.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[booksrec]
   SET [Title] = '" + titletextBox.Text + "',[Subject] ='" + subjecttextBox.Text + "',[Publisher] = '" + publishertextBox.Text + "',[Author] = '" + authortextBox.Text + "',[Availability] = '" + availabilitycomboBox.Text + "' WHERE [ID]='" + idtextBox.Text + "'", conec);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conec.Close();
                saveupdatebutton.Hide();
                idtextBox.Clear();
                titletextBox.Clear();
                subjecttextBox.Clear();
                publishertextBox.Clear();
                authortextBox.Clear();
                availabilitycomboBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            okbutton.Hide();
            reclabel.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void oktree_Click(object sender, EventArgs e)
        {
            treeView1.Hide();
            oktree.Hide();
            expand.Hide();
        }

        private void expand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            expand.Hide();
        }

         
    }
}
