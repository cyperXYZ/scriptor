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
                    parentNode.Nodes.Add(directoryNode);

                    // Recursively populate the tree view with subdirectories
                    PopulateTreeView(subDirectory, directoryNode);
                }

                // Get all files in the current directory
                string[] files = Directory.GetFiles(directory);

                foreach (string file in files)
                {
                    // Create a new node for the file
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void form1_load(object sender, EventArgs e)
        {
            // Specify the root directory
            string rootDirectory = @"C:\Users\Ryan\Desktop\CyperSite"; // Change this to your desired directory

            // Create a root node for the tree view
            TreeNode rootNode = new TreeNode(rootDirectory);
            treeView1.Nodes.Add(rootNode);

            // Populate the tree view with files and subdirectories
            PopulateTreeView(rootDirectory, rootNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Check if the selected node represents a file
            if (File.Exists(selectedNode.FullPath))
            {
                try
                {
                    // Read the contents of the file
                    string fileContents = File.ReadAllText(selectedNode.FullPath);

                    // Display the contents in a TextBox
                    TxtEditor.Text = fileContents;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }
    }
}