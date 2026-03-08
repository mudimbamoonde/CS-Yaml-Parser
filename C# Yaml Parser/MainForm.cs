namespace C__Yaml_Parser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
 LoadFilesFromFolder(@"C:\");
            this.CenterToScreen();

        }
        private void LoadFilesFromFolder(string folder) {

            if (folder == null || folder == "")
            {
                return;

            }
            // clear the list
            listFiles.Items.Clear();

                // clear select details
                ClearSelectionDetails();

                // toggle editor states
                ToggleEditors(false);
           

                // load actual fules
                DirectoryInfo di = new DirectoryInfo(folder);
                string filer = "*.md";
                if (!chkmarkdown.Checked)
                {
                    filer = "";
                }

                FileInfo[] files = di.GetFiles(filer);
                foreach (FileInfo fi in files)
                {
                    listFiles.Items.Add(fi.Name);
                }

            txtFolder.Text = folder;



        }

        private void ClearSelectionDetails() { 
        
        }

        private void ToggleEditors(bool on) 
        { 
            txtFileName.Enabled = on;
            grpYaml.Enabled = on;
            btnSave.Enabled = on;
            txtContent.Enabled = on;


        }

        private void LoadFileContents(string fileName)
        { 
            txtContent.Clear();


        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            //show a dialog to select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();

            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                // txtFolder.text  = set to select folder
                // LoadFilesFromFolder
                LoadFilesFromFolder(fbd.SelectedPath);
              
            }
          
            
         
        }

        private void chkMarkdown_CheckedChanged(object sender, EventArgs e)
        {
            //reloads files from folder
            LoadFilesFromFolder(txtFolder.Text);
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when we select an item, we load the data into the selection panels
            if (listFiles.SelectedIndex == -1 ) {
                return;
            }
            txtFileName.Text = listFiles.SelectedItem.ToString();
            //load the content of the file into the content editor

            LoadFileContents(listFiles.SelectedItem.ToString());
        }
    }
}
