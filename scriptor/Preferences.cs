using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
// private Form1 form1 = Application.OpenForms["Form1"] as Form1;
namespace scriptor
{


    public partial class Preferences : Form
    {
        private const string ThemesFolder = "Themes";

        Form1 form1 = Application.OpenForms["Form1"] as Form1;
        public Preferences()
        {
            InitializeComponent();

            PopulateThemeListBox();
        }

        private void PopulateThemeListBox()
        {
            try
            {
                // Clear the ListBox
                themeListBox.Items.Clear();

                // Get the list of theme files in the Themes folder
                string[] themeFiles = Directory.GetFiles(ThemesFolder, "*.xml");

                // Extract theme names from file names and add them to the ListBox
                foreach (string themeFile in themeFiles)
                {
                    string themeName = Path.GetFileNameWithoutExtension(themeFile);
                    themeListBox.Items.Add(themeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating theme list: " + ex.Message);
            }
        }

        private void LoadGlobalTheme(string themeFileName)
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


                form1.LoadTheme(themeFileName);

                // Apply theme to controls
                BackColor = ColorTranslator.FromHtml(main_color);
                foreach (TabPage page in tabControl1.TabPages)
                {
                    page.BackColor = ColorTranslator.FromHtml(main_color);
                }

                themeListBox.BackColor = ColorTranslator.FromHtml(editor_color);
                themeListBox.ForeColor = ColorTranslator.FromHtml(editor_text_color);
                // edditor themes

                // Apply theme to other controls as needed...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading theme: " + ex.Message);
            }
        }


        private void ApplyThemeButton_Click(object sender, EventArgs e)
        {
            // Get the selected theme from the ListBox
            string selectedTheme = themeListBox.SelectedItem?.ToString();

            // Apply the selected theme to the main form
            LoadGlobalTheme(ThemesFolder + "/" + selectedTheme + ".xml");

            // Close the theme selection form
        }



    }
}
