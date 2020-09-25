namespace yt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mazga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mazga
            // 
            this.mazga.Location = new System.Drawing.Point(333, 188);
            this.mazga.Name = "mazga";
            this.mazga.Size = new System.Drawing.Size(75, 23);
            this.mazga.TabIndex = 0;
            this.mazga.Text = "button1";
            this.mazga.UseVisualStyleBackColor = true;
            this.mazga.Click += new System.EventHandler(this.mazga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.mazga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mazga;
    }
}

