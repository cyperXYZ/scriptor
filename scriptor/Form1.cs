namespace scriptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateTreeView(string directory, TreeNode parentNode)
        {
            try
            {
                // Clear the existing nodes
                parentNode.Nodes.Clear();


                // Get all directories in the current directory
                string[] subDirectories = Directory.GetDirectories(directory);

                foreach (string subDirectory in subDirectories)
                {
                    // Create a new node for the subdirectory
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(subDirectory));
                    directoryNode.NodeFont = new Font(treeView1.Font, FontStyle.Bold); // Set the font to bold for directories
                    directoryNode.Tag = subDirectory; // Store the full path as tag
                    directoryNode.ImageIndex = 0; // Set the index of the folder icon in the ImageList
                    directoryNode.SelectedImageIndex = 0; // Set the index of the selected folder icon in the ImageList
                    parentNode.Nodes.Add(directoryNode);
                }

                // Get all files in the current directory
                string[] files = Directory.GetFiles(directory);

                foreach (string file in files)
                {
                    // Create a new node for the file
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file; // Store the full path as tag
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Tag != null)
            {
                string fullPath = selectedNode.Tag.ToString();

                // Check if the selected node represents a file
                if (File.Exists(fullPath))
                {
                    try
                    {
                        // Read the contents of the file
                        string fileContents = File.ReadAllText(fullPath);
                        TxtEditor.Text = fileContents;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
                // Check if the selected node represents a directory
                else if (Directory.Exists(fullPath))
                {
                    // Clear the child nodes of the selected node
                    selectedNode.Nodes.Clear();

                    // Populate the tree view with the selected directory
                    PopulateTreeView(fullPath, selectedNode);
                }
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog to select a directory
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a directory";
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedDirectory = folderBrowserDialog.SelectedPath;

                    // Clear the entire tree view
                    treeView1.Nodes.Clear();

                    // Populate the tree view with the selected directory
                    PopulateTreeView(selectedDirectory, treeView1.Nodes.Add(Path.GetFileName(selectedDirectory)));
                }
            }
        }
    }
}