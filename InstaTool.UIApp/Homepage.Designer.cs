namespace InstaTool.UIApp
{
    partial class Homepage
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
            this.listOfInstagramAccounts = new System.Windows.Forms.ListView();
            this.EmailPhone = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.instaPassword = new System.Windows.Forms.TextBox();
            this.instaEmailPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfInstagramAccounts
            // 
            this.listOfInstagramAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmailPhone});
            this.listOfInstagramAccounts.FullRowSelect = true;
            this.listOfInstagramAccounts.GridLines = true;
            this.listOfInstagramAccounts.HideSelection = false;
            this.listOfInstagramAccounts.Location = new System.Drawing.Point(254, 43);
            this.listOfInstagramAccounts.Name = "listOfInstagramAccounts";
            this.listOfInstagramAccounts.Size = new System.Drawing.Size(185, 248);
            this.listOfInstagramAccounts.TabIndex = 0;
            this.listOfInstagramAccounts.UseCompatibleStateImageBehavior = false;
            this.listOfInstagramAccounts.View = System.Windows.Forms.View.Details;
            this.listOfInstagramAccounts.SelectedIndexChanged += new System.EventHandler(this.ListOfInstagramAccounts_Load);
            // 
            // EmailPhone
            // 
            this.EmailPhone.Text = "EmailPhone";
            this.EmailPhone.Width = 180;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Use selected account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UseSelectedAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select ONE account from the list to use";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instaPassword);
            this.panel1.Controls.Add(this.instaEmailPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(26, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 248);
            this.panel1.TabIndex = 4;
            // 
            // instaPassword
            // 
            this.instaPassword.Location = new System.Drawing.Point(19, 113);
            this.instaPassword.Name = "instaPassword";
            this.instaPassword.PasswordChar = '*';
            this.instaPassword.Size = new System.Drawing.Size(161, 23);
            this.instaPassword.TabIndex = 2;
            this.instaPassword.TextChanged += new System.EventHandler(this.instaPassword_TextChanged);
            // 
            // instaEmailPhone
            // 
            this.instaEmailPhone.Location = new System.Drawing.Point(19, 43);
            this.instaEmailPhone.Name = "instaEmailPhone";
            this.instaEmailPhone.Size = new System.Drawing.Size(161, 23);
            this.instaEmailPhone.TabIndex = 2;
            this.instaEmailPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Insta Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Insta Email/Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddInstagramAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add an instagram account";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listOfInstagramAccounts);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOfInstagramAccounts;
        private System.Windows.Forms.ColumnHeader EmailPhone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox instaPassword;
        private System.Windows.Forms.TextBox instaEmailPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}