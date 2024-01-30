using System.Reflection;
using System.Xml;
using System.Drawing;

namespace scriptor;

public partial class Form1 : Form
{

    public XmlDocument doc = new XmlDocument();
    public Form1()
    {
        InitializeComponent();
        LoadTheme("Themes/Vanilla.xml");

    }

    public string currentFilePath = "NewFile.txt";
    public string oldtxt = "";


    private void LoadTheme(string themeFileName)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(themeFileName);

            XmlNode root = doc.DocumentElement;
            string editor_color = root.SelectSingleNode("editor_color").InnerText;
            string editor_text_color = root.SelectSingleNode("editor_text_color").InnerText;
            string editor_indent_color = root.SelectSingleNode("editor_indent_color").InnerText;
            string main_color = root.SelectSingleNode("main_color").InnerText;
            string editor_indent_number_color = root.SelectSingleNode("editor_indent_number_color").InnerText;
            string text_color = root.SelectSingleNode("text_color").InnerText;
            string Document_map_color = root.SelectSingleNode("Document_map_color").InnerText;

            // Apply theme to controls

            // edditor themes
            TxtEditor.BackColor = ColorTranslator.FromHtml(editor_color);
            TxtEditor.ForeColor = ColorTranslator.FromHtml(editor_text_color);
            TxtEditor.IndentBackColor = ColorTranslator.FromHtml(editor_indent_color);
            TxtEditor.LineNumberColor = ColorTranslator.FromHtml(editor_indent_number_color);
            TxtMap.BackColor = ColorTranslator.FromHtml(editor_color);
            TxtMap.ForeColor = ColorTranslator.FromHtml(Document_map_color);
            // theme settings for the top and side bar
            menuStrip1.BackColor = ColorTranslator.FromHtml(main_color);
            treeView1.BackColor = ColorTranslator.FromHtml(main_color);
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = ColorTranslator.FromHtml(text_color);
            }
            treeView1.ForeColor = ColorTranslator.FromHtml(text_color);
            // Apply theme to other controls as needed...
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading theme: " + ex.Message);
        }
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
            MessageBox.Show("Error: " + ex.Message, "Error");
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
                    currentFilePath = fullPath;
                    Text = "Scriptor - " + selectedNode.FullPath;
                    string fileContents = File.ReadAllText(fullPath);
                    oldtxt = fileContents;
                    TxtEditor.Text = fileContents;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error");
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

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
    {

        Text = "Scriptor - NewFile";

        TxtEditor.Text = "";

    }

    private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        // Check if the current file path is not empty and if it matches the selected file path
        if (!string.IsNullOrEmpty(currentFilePath))
        {
            // Check if the current file path matches the selected file path
            if (currentFilePath != saveFileDialog1.FileName)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(TxtEditor.Text);
                    }

                    // Update the current file path with the path of the newly saved file
                    currentFilePath = saveFileDialog1.FileName;
                }
            }
            else
            {
                // Save the content directly without showing the dialog
                using (Stream s = File.Open(currentFilePath, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(TxtEditor.Text);
                }
            }
        }

    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TxtEditor.Undo();
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TxtEditor.Redo();
    }

    private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
    {

        AboutBox1 aboutBox1 = new AboutBox1();
        aboutBox1.ShowDialog();

    }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // All i know is this code was from a previous project of mine and it works :)
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            openFileDialog1.Title = "Open";
            TxtEditor.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }
    private void SwitchThemeButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "XML Files|*.xml";
        openFileDialog.Title = "Select Theme File";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            LoadTheme(openFileDialog.FileName);
        }
    }
}