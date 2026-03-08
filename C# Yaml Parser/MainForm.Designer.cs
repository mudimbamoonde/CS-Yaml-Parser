namespace C__Yaml_Parser
{
    partial class frmMain
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
            Label lblContents;
            lblFolder = new Label();
            txtFolder = new TextBox();
            btnbrowse = new Button();
            chkmarkdown = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            listFiles = new ListBox();
            lblFilename = new Label();
            txtFileName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            grpYaml = new GroupBox();
            btnDefaults = new Button();
            btnClear = new Button();
            lblDate = new Label();
            txtDate = new TextBox();
            txtLayout = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            chkListCategs = new CheckedListBox();
            lblCategs = new Label();
            lblLayout = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            txtContent = new TextBox();
            btnSave = new Button();
            lblContents = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpYaml.SuspendLayout();
            SuspendLayout();
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(386, 383);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(58, 15);
            lblContents.TabIndex = 11;
            lblContents.Text = "Contents:";
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(3, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Enabled = false;
            txtFolder.Location = new Point(73, 3);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(314, 23);
            txtFolder.TabIndex = 1;
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new Point(393, 3);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(80, 23);
            btnbrowse.TabIndex = 2;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // chkmarkdown
            // 
            chkmarkdown.AutoSize = true;
            chkmarkdown.Location = new Point(492, 3);
            chkmarkdown.Name = "chkmarkdown";
            chkmarkdown.Size = new Size(148, 19);
            chkmarkdown.TabIndex = 3;
            chkmarkdown.Text = "Markdown Only (*.md)";
            chkmarkdown.UseVisualStyleBackColor = true;
            chkmarkdown.CheckedChanged += chkMarkdown_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9487171F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.0512848F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Controls.Add(chkmarkdown, 3, 0);
            tableLayoutPanel1.Controls.Add(txtFolder, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFolder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnbrowse, 2, 0);
            tableLayoutPanel1.Location = new Point(51, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(646, 30);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // listFiles
            // 
            listFiles.FormattingEnabled = true;
            listFiles.ItemHeight = 15;
            listFiles.Location = new Point(51, 69);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(316, 529);
            listFiles.TabIndex = 5;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new Point(3, 0);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(69, 15);
            lblFilename.TabIndex = 6;
            lblFilename.Text = " File Name: ";
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(137, 3);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(412, 23);
            txtFileName.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.29022F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.70978F));
            tableLayoutPanel2.Controls.Add(lblFilename, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFileName, 1, 0);
            tableLayoutPanel2.Location = new Point(386, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(552, 29);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // grpYaml
            // 
            grpYaml.Controls.Add(btnDefaults);
            grpYaml.Controls.Add(btnClear);
            grpYaml.Controls.Add(lblDate);
            grpYaml.Controls.Add(txtDate);
            grpYaml.Controls.Add(txtLayout);
            grpYaml.Controls.Add(txtAuthor);
            grpYaml.Controls.Add(txtTitle);
            grpYaml.Controls.Add(chkListCategs);
            grpYaml.Controls.Add(lblCategs);
            grpYaml.Controls.Add(lblLayout);
            grpYaml.Controls.Add(lblAuthor);
            grpYaml.Controls.Add(lblTitle);
            grpYaml.Location = new Point(386, 105);
            grpYaml.Name = "grpYaml";
            grpYaml.Size = new Size(549, 272);
            grpYaml.TabIndex = 9;
            grpYaml.TabStop = false;
            grpYaml.Text = "Yaml Data (FrontMatter)";
            // 
            // btnDefaults
            // 
            btnDefaults.Location = new Point(255, 175);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(170, 33);
            btnDefaults.TabIndex = 21;
            btnDefaults.Text = "Default";
            btnDefaults.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 33);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(6, 129);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 19;
            lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(67, 126);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(167, 23);
            txtDate.TabIndex = 18;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(67, 91);
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(168, 23);
            txtLayout.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(67, 56);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(168, 23);
            txtAuthor.TabIndex = 16;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(67, 27);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(168, 23);
            txtTitle.TabIndex = 15;
            // 
            // chkListCategs
            // 
            chkListCategs.FormattingEnabled = true;
            chkListCategs.Location = new Point(255, 45);
            chkListCategs.Name = "chkListCategs";
            chkListCategs.Size = new Size(212, 112);
            chkListCategs.TabIndex = 14;
            // 
            // lblCategs
            // 
            lblCategs.AutoSize = true;
            lblCategs.Location = new Point(255, 27);
            lblCategs.Name = "lblCategs";
            lblCategs.Size = new Size(66, 15);
            lblCategs.TabIndex = 13;
            lblCategs.Text = "Categories:";
            // 
            // lblLayout
            // 
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(6, 94);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(46, 15);
            lblLayout.TabIndex = 12;
            lblLayout.Text = "Layout:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(6, 56);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(6, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title:";
            // 
            // txtContent
            // 
            txtContent.Enabled = false;
            txtContent.Location = new Point(386, 401);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(552, 197);
            txtContent.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(860, 604);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 652);
            Controls.Add(btnSave);
            Controls.Add(lblContents);
            Controls.Add(txtContent);
            Controls.Add(grpYaml);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(listFiles);
            Controls.Add(tableLayoutPanel1);
            Name = "frmMain";
            Text = "YAML FrontMatter Loader";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpYaml.ResumeLayout(false);
            grpYaml.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private TextBox txtFolder;
        private Button btnbrowse;
        private CheckBox chkmarkdown;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listFiles;
        private Label lblFilename;
        private TextBox txtFileName;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grpYaml;
        private TextBox txtDate;
        private TextBox txtLayout;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private CheckedListBox chkListCategs;
        private Label lblCategs;
        private Label lblLayout;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblDate;
        private Button btnDefaults;
        private Button btnClear;
        private TextBox txtContent;
        private Button btnSave;
    }
}
