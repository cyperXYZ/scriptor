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
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            documentMap1 = new FastColoredTextBoxNS.DocumentMap();
            imageList1 = new ImageList(components);
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
            treeView1.Indent = 5;
            treeView1.LineColor = Color.White;
            treeView1.Location = new Point(0, 24);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(175, 426);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += TreeView1_AfterSelect;
            // 
            // TxtEditor
            // 
            TxtEditor.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            TxtEditor.AutoScrollMinSize = new Size(29, 16);
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
            newFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newFileToolStripMenuItem.Size = new Size(215, 22);
            newFileToolStripMenuItem.Text = "New File";
            newFileToolStripMenuItem.Click += newFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(212, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Image = Properties.Resources.folder;
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            openFolderToolStripMenuItem.Size = new Size(215, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Image = Properties.Resources.file_text;
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.Size = new Size(215, 22);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(212, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Image = (Image)resources.GetObject("saveFileToolStripMenuItem.Image");
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Space;
            saveFileToolStripMenuItem.Size = new Size(215, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F14;
            exitToolStripMenuItem.Size = new Size(215, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(40, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(45, 20);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(180, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // documentMap1
            // 
            documentMap1.Dock = DockStyle.Right;
            documentMap1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentMap1.ForeColor = Color.FromArgb(72, 120, 250);
            documentMap1.Location = new Point(709, 24);
            documentMap1.Name = "documentMap1";
            documentMap1.Scale = 0.5F;
            documentMap1.Size = new Size(91, 426);
            documentMap1.TabIndex = 3;
            documentMap1.Target = TxtEditor;
            documentMap1.Text = "documentMap1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "file.png");
            imageList1.Images.SetKeyName(1, "file-plus.png");
            imageList1.Images.SetKeyName(2, "file-text.png");
            imageList1.Images.SetKeyName(3, "folder.png");
            imageList1.Images.SetKeyName(4, "save.png");
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Scriptor";
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
        private ToolStripMenuItem aboutToolStripMenuItem1;
        public ImageList imageList1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
    }
}