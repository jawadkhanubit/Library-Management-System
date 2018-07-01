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
    public partial class members : Form
    {
        public members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nametextBox.Clear();
            mobiletextBox.Clear();
            emailtextBox.Clear();
            adresstextBox.Clear();
            nametextBox.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((nametextBox.Text == "") || (mobiletextBox.Text == "") || (emailtextBox.Text == "") || (adresstextBox.Text == "") || (statuscomboBox.Text == ""))
            {
                MessageBox.Show("Please Fill all required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Do you want to save in a file or a database?\n Click Yes for in file\n Click No for database", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter strw = new StreamWriter("E:\\win part\\Discrete Mathematics\\Project\\members.txt", true))
                    {

                        strw.Write(nametextBox.Text + "\t");
                        strw.Write(mobiletextBox.Text + "\t");
                        strw.Write(emailtextBox.Text + "\t");
                        strw.Write(adresstextBox.Text + "\t");
                        strw.WriteLine(statuscomboBox.Text + "\t");
                        strw.Close();
                        MessageBox.Show("Member's Information Entered Successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[members]
           ([Name]
           ,[Mobile]
           ,[Email]
           ,[Adress]
           ,[Status])
     VALUES
           ('" + nametextBox.Text + "','" + mobiletextBox.Text + "','" + emailtextBox.Text + "','" + adresstextBox.Text + "','" + statuscomboBox.Text + "')", conec);

                    cmd.ExecuteNonQuery();
                    conec.Close();
                }
                    else
                    {
                    SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[members]
           ([Name]
           ,[Mobile]
           ,[Email]
           ,[Adress]
           ,[Status])
     VALUES
           ('" + nametextBox.Text + "','" + mobiletextBox.Text + "','" + emailtextBox.Text + "','" + adresstextBox.Text + "','" + statuscomboBox.Text + "')", conec);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member's Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlDataAdapter sdta = new SqlDataAdapter("Select * From [members]", conec);
                sdta.Fill(dt);
                treeView1.Nodes.Add("members");

                foreach (DataRow dr in dt.Rows)
                {
                    TreeNode nod = new TreeNode(dr["Name"].ToString());
                    nod.Nodes.Add(dr["Mobile"].ToString());
                    nod.Nodes.Add(dr["Email"].ToString());
                    nod.Nodes.Add(dr["Adress"].ToString());
                    nod.Nodes.Add(dr["Status"].ToString());
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
                   cmd.CommandText = "Select * From members";
                   cmd.ExecuteNonQuery();
                   SqlDataAdapter sdta = new SqlDataAdapter(cmd);
                   
                   DataTable dt = new DataTable();
                   sdta.Fill(dt);
                   dataGridView1.DataSource = dt;
                   conec.Close();
                   reclabel.Text = "Total Memberes are= " + dt.Rows.Count;
 
               } 

        private void members_Load(object sender, EventArgs e)
        {
            treeView1.Hide();
            oktree.Hide();
            expand.Hide();
            dataGridView1.Hide();
            okbutton.Hide();
            reclabel.Hide();
            nametextBox.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text == "")
            {
                MessageBox.Show("Please enter tha name of the member.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conec = new SqlConnection("Data Source=DESKTOP-9KTV7AF;Initial Catalog=LMS;Integrated Security=True");
                conec.Open();
                SqlCommand cmd = conec.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From members Where Name='" + nametextBox.Text + "'";
                cmd.ExecuteNonQuery();
                conec.Close();
                display();
                MessageBox.Show("Member's Information deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobiletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            okbutton.Hide();
            reclabel.Hide();
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