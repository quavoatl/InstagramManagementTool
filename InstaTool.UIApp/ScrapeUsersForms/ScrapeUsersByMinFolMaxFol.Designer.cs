namespace InstaTool.UIApp.ScrapeUsersForms
{
    partial class ScrapeUsersByMinFolMaxFol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxFollowingTextbox = new System.Windows.Forms.TextBox();
            this.minFollowersTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instagramTargetUrl = new System.Windows.Forms.TextBox();
            this.startScraper = new System.Windows.Forms.Button();
            this.listOfLogsListview = new System.Windows.Forms.ListView();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.listResultsOfScrapingListview = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.exportButton = new System.Windows.Forms.Button();
            this.backToFeatures = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxFollowingTextbox);
            this.panel1.Controls.Add(this.minFollowersTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.instagramTargetUrl);
            this.panel1.Controls.Add(this.startScraper);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 107);
            this.panel1.TabIndex = 0;
            // 
            // maxFollowingTextbox
            // 
            this.maxFollowingTextbox.Location = new System.Drawing.Point(142, 67);
            this.maxFollowingTextbox.Name = "maxFollowingTextbox";
            this.maxFollowingTextbox.Size = new System.Drawing.Size(86, 23);
            this.maxFollowingTextbox.TabIndex = 6;
            this.maxFollowingTextbox.WordWrap = false;
            // 
            // minFollowersTextbox
            // 
            this.minFollowersTextbox.Location = new System.Drawing.Point(20, 67);
            this.minFollowersTextbox.Name = "minFollowersTextbox";
            this.minFollowersTextbox.Size = new System.Drawing.Size(86, 23);
            this.minFollowersTextbox.TabIndex = 5;
            this.minFollowersTextbox.TextChanged += new System.EventHandler(this.minFollowersTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Following";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Followers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User URL";
            // 
            // instagramTargetUrl
            // 
            this.instagramTargetUrl.Location = new System.Drawing.Point(68, 10);
            this.instagramTargetUrl.Name = "instagramTargetUrl";
            this.instagramTargetUrl.Size = new System.Drawing.Size(254, 23);
            this.instagramTargetUrl.TabIndex = 1;
            // 
            // startScraper
            // 
            this.startScraper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startScraper.Location = new System.Drawing.Point(247, 49);
            this.startScraper.Name = "startScraper";
            this.startScraper.Size = new System.Drawing.Size(75, 41);
            this.startScraper.TabIndex = 0;
            this.startScraper.Text = "Start Scraping";
            this.startScraper.UseVisualStyleBackColor = false;
            this.startScraper.Click += new System.EventHandler(this.startScraper_Click);
            // 
            // listOfLogsListview
            // 
            this.listOfLogsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description});
            this.listOfLogsListview.HideSelection = false;
            this.listOfLogsListview.Location = new System.Drawing.Point(4, 145);
            this.listOfLogsListview.Name = "listOfLogsListview";
            this.listOfLogsListview.Size = new System.Drawing.Size(411, 77);
            this.listOfLogsListview.TabIndex = 1;
            this.listOfLogsListview.UseCompatibleStateImageBehavior = false;
            this.listOfLogsListview.View = System.Windows.Forms.View.Details;
            this.listOfLogsListview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Text = "Logs";
            this.Description.Width = 410;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Results: ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Logs";
            this.columnHeader1.Width = 325;
            // 
            // listResultsOfScrapingListview
            // 
            this.listResultsOfScrapingListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listResultsOfScrapingListview.HideSelection = false;
            this.listResultsOfScrapingListview.Location = new System.Drawing.Point(4, 247);
            this.listResultsOfScrapingListview.Name = "listResultsOfScrapingListview";
            this.listResultsOfScrapingListview.Size = new System.Drawing.Size(411, 109);
            this.listResultsOfScrapingListview.TabIndex = 1;
            this.listResultsOfScrapingListview.UseCompatibleStateImageBehavior = false;
            this.listResultsOfScrapingListview.View = System.Windows.Forms.View.Details;
            this.listResultsOfScrapingListview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ScrapedURL";
            this.columnHeader2.Width = 410;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(328, 362);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(87, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export to .txt";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // backToFeatures
            // 
            this.backToFeatures.Location = new System.Drawing.Point(4, 362);
            this.backToFeatures.Name = "backToFeatures";
            this.backToFeatures.Size = new System.Drawing.Size(50, 23);
            this.backToFeatures.TabIndex = 5;
            this.backToFeatures.Text = "Back";
            this.backToFeatures.UseVisualStyleBackColor = true;
            this.backToFeatures.Click += new System.EventHandler(this.backToInstaToolFeatures_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(52, 127);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 15);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Stopped";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_click);
            // 
            // ScrapeUsersByMinFolMaxFol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 389);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.backToFeatures);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.listResultsOfScrapingListview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listOfLogsListview);
            this.Controls.Add(this.panel1);
            this.Name = "ScrapeUsersByMinFolMaxFol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrapeUsers";
            this.Load += new System.EventHandler(this.ScrapeUsersByMinFolMaxFol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maxFollowingTextbox;
        private System.Windows.Forms.TextBox minFollowersTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox instagramTargetUrl;
        private System.Windows.Forms.Button startScraper;
        private System.Windows.Forms.ListView listOfLogsListview;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView resultOfScraping;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ListView listResultsOfScraping;
        private System.Windows.Forms.ListView listResultsOfScrapingListview;
        private System.Windows.Forms.Button backToFeatures;
        private System.Windows.Forms.Label statusLabel;
    }
}