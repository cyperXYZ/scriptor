namespace scriptor
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            pictureBox1 = new PictureBox();
            AboutName = new Label();
            Version = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AboutName
            // 
            AboutName.AutoSize = true;
            AboutName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AboutName.ForeColor = Color.White;
            AboutName.Location = new Point(119, 13);
            AboutName.Name = "AboutName";
            AboutName.Size = new Size(76, 22);
            AboutName.TabIndex = 1;
            AboutName.Text = "Scriptor";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Version.ForeColor = Color.White;
            Version.Location = new Point(119, 35);
            Version.Name = "Version";
            Version.Size = new Size(74, 18);
            Version.TabIndex = 2;
            Version.Text = "Ver. 0.0.1";
            // 
            // AboutBox1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(507, 146);
            Controls.Add(Version);
            Controls.Add(AboutName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AboutName;
        private Label Version;
    }
}
