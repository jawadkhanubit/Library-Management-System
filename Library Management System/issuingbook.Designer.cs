namespace Library_Management_System
{
    partial class issuingbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issuingbook));
            this.label1 = new System.Windows.Forms.Label();
            this.namembrtextBox = new System.Windows.Forms.TextBox();
            this.durationcomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchmbrtextBox = new System.Windows.Forms.TextBox();
            this.savembrbutton = new System.Windows.Forms.Button();
            this.searchmbrbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.booknametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returndatetextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.okbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration:";
            // 
            // namembrtextBox
            // 
            this.namembrtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namembrtextBox.Location = new System.Drawing.Point(173, 85);
            this.namembrtextBox.Name = "namembrtextBox";
            this.namembrtextBox.Size = new System.Drawing.Size(196, 24);
            this.namembrtextBox.TabIndex = 2;
            // 
            // durationcomboBox
            // 
            this.durationcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationcomboBox.FormattingEnabled = true;
            this.durationcomboBox.Items.AddRange(new object[] {
            "1 Weak",
            "2 Weak",
            "3 Weak",
            "1 Month"});
            this.durationcomboBox.Location = new System.Drawing.Point(490, 134);
            this.durationcomboBox.Name = "durationcomboBox";
            this.durationcomboBox.Size = new System.Drawing.Size(200, 26);
            this.durationcomboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 24);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of the Members:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search Member";
            // 
            // searchmbrtextBox
            // 
            this.searchmbrtextBox.Location = new System.Drawing.Point(697, 26);
            this.searchmbrtextBox.Name = "searchmbrtextBox";
            this.searchmbrtextBox.Size = new System.Drawing.Size(147, 20);
            this.searchmbrtextBox.TabIndex = 0;
            // 
            // savembrbutton
            // 
            this.savembrbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savembrbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savembrbutton.Location = new System.Drawing.Point(591, 230);
            this.savembrbutton.Name = "savembrbutton";
            this.savembrbutton.Size = new System.Drawing.Size(99, 28);
            this.savembrbutton.TabIndex = 7;
            this.savembrbutton.Text = "Issue book";
            this.savembrbutton.UseVisualStyleBackColor = true;
            this.savembrbutton.Click += new System.EventHandler(this.savembrbutton_Click);
            // 
            // searchmbrbutton
            // 
            this.searchmbrbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchmbrbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchmbrbutton.Location = new System.Drawing.Point(782, 52);
            this.searchmbrbutton.Name = "searchmbrbutton";
            this.searchmbrbutton.Size = new System.Drawing.Size(62, 23);
            this.searchmbrbutton.TabIndex = 1;
            this.searchmbrbutton.Text = "Search";
            this.searchmbrbutton.UseVisualStyleBackColor = true;
            this.searchmbrbutton.Click += new System.EventHandler(this.searchmbrbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Issuing Book";
            // 
            // booknametextBox
            // 
            this.booknametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknametextBox.Location = new System.Drawing.Point(490, 85);
            this.booknametextBox.Name = "booknametextBox";
            this.booknametextBox.Size = new System.Drawing.Size(200, 24);
            this.booknametextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Nme:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Return date:";
            // 
            // returndatetextBox
            // 
            this.returndatetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndatetextBox.Location = new System.Drawing.Point(490, 183);
            this.returndatetextBox.Name = "returndatetextBox";
            this.returndatetextBox.Size = new System.Drawing.Size(200, 24);
            this.returndatetextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 101);
            this.dataGridView1.TabIndex = 5;
            // 
            // okbutton
            // 
            this.okbutton.BackColor = System.Drawing.Color.LightGray;
            this.okbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okbutton.Location = new System.Drawing.Point(655, 376);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = false;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Location = new System.Drawing.Point(68, 461);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(662, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // issuingbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.book3;
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchmbrbutton);
            this.Controls.Add(this.savembrbutton);
            this.Controls.Add(this.durationcomboBox);
            this.Controls.Add(this.searchmbrtextBox);
            this.Controls.Add(this.booknametextBox);
            this.Controls.Add(this.returndatetextBox);
            this.Controls.Add(this.namembrtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "issuingbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issuing books";
            this.Load += new System.EventHandler(this.issuingbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namembrtextBox;
        private System.Windows.Forms.ComboBox durationcomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchmbrtextBox;
        private System.Windows.Forms.Button savembrbutton;
        private System.Windows.Forms.Button searchmbrbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox booknametextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox returndatetextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}