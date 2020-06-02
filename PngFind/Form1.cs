using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PngFind
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager matSkinMan = MaterialSkinManager.Instance;
            matSkinMan.AddFormToManage(this);
            matSkinMan.Theme = MaterialSkinManager.Themes.DARK;
            matSkinMan.ColorScheme = new ColorScheme(Primary.Amber400, Primary.Amber400, Primary.Amber400, Accent.Amber400, TextShade.BLACK);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //pbMain.Value = 0;
            pbMain.Minimum = 0;
            pbMain.Maximum = 100;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            //Open Folderbrowser dialog and set selected folder as to the textbox.
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    mtxtFolderName.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Set selected path to the text value of the textbox.
            var path = mtxtFolderName.Text;

            //check whether path is set or not, prevent application from crashing.
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please select the path to search!", "Png Find", MessageBoxButtons.OK);
            }
            else
            {
                //if the path is succssfully set, get png files from that specific path.
                var pngFiles = Directory.GetFiles(path, "*.png");

                //check whether there's png files in the selected path, otherwise show message.
                if (pngFiles != null)
                {
                    foreach (var item in pngFiles)
                    {
                        pbMain.Increment(item.Length);
                        lstImages.Items.Add(item.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Selected path contains no png images!", "Png Find", MessageBoxButtons.OK);
                }
            }
        }
        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display image in the picturebox
            pbImage.ImageLocation = lstImages.SelectedItem.ToString();
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
