namespace scriptor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            TxtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            documentMap1 = new FastColoredTextBoxNS.DocumentMap();
            ((System.ComponentModel.ISupportInitialize)TxtEditor).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(11, 11, 11);
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Dock = DockStyle.Left;
            treeView1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ForeColor = Color.White;
            treeView1.LineColor = Color.White;
            treeView1.Location = new Point(0, 24);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeView1.Scrollable = false;
            treeView1.Size = new Size(175, 426);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // TxtEditor
            // 
            TxtEditor.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            TxtEditor.AutoScrollMinSize = new Size(200, 16);
            TxtEditor.BackBrush = null;
            TxtEditor.BackColor = Color.Transparent;
            TxtEditor.BookmarkColor = Color.FromArgb(128, 255, 255);
            TxtEditor.CharHeight = 16;
            TxtEditor.CharWidth = 9;
            TxtEditor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            TxtEditor.Dock = DockStyle.Fill;
            TxtEditor.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEditor.ForeColor = Color.White;
            TxtEditor.IndentBackColor = Color.FromArgb(15, 15, 15);
            TxtEditor.IsReplaceMode = false;
            TxtEditor.LineNumberColor = Color.FromArgb(72, 120, 250);
            TxtEditor.Location = new Point(175, 24);
            TxtEditor.Margin = new Padding(0);
            TxtEditor.Name = "TxtEditor";
            TxtEditor.Paddings = new Padding(0);
            TxtEditor.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            TxtEditor.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("TxtEditor.ServiceColors");
            TxtEditor.ServiceLinesColor = Color.White;
            TxtEditor.Size = new Size(625, 426);
            TxtEditor.TabIndex = 1;
            TxtEditor.Text = "fastColoredTextBox1";
            TxtEditor.Zoom = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(11, 11, 11);
            menuStrip1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newFileToolStripMenuItem, toolStripSeparator1, openFolderToolStripMenuItem, openFileToolStripMenuItem, toolStripSeparator2, saveFileToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.BackColor = Color.Transparent;
            newFileToolStripMenuItem.Image = Properties.Resources.file_plus;
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(180, 22);
            newFileToolStripMenuItem.Text = "New File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Image = Properties.Resources.folder;
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(180, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Image = Properties.Resources.file_text;
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "Open File";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Image = (Image)resources.GetObject("saveFileToolStripMenuItem.Image");
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(180, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(40, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(45, 20);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // documentMap1
            // 
            documentMap1.Dock = DockStyle.Right;
            documentMap1.ForeColor = Color.FromArgb(72, 120, 250);
            documentMap1.Location = new Point(709, 24);
            documentMap1.Name = "documentMap1";
            documentMap1.Scale = 0.5F;
            documentMap1.Size = new Size(91, 426);
            documentMap1.TabIndex = 3;
            documentMap1.Target = TxtEditor;
            documentMap1.Text = "documentMap1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(documentMap1);
            Controls.Add(TxtEditor);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += form1_load;
            ((System.ComponentModel.ISupportInitialize)TxtEditor).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private FastColoredTextBoxNS.FastColoredTextBox TxtEditor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private FastColoredTextBoxNS.DocumentMap documentMap1;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}