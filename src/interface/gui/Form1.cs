using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace gui
{
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
        }

        private void seleterFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderSearch.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathSelected.Text = folderSearch.SelectedPath;
                var files = Directory.GetFiles(pathSelected.Text);

                foreach(string file in files)
                {
                    string fileExt = new FileInfo(file).Extension.Replace('.', ' ').TrimStart('.');
                    
                }

            }

        }

        private void newFolderName_Enter(object sender, EventArgs e)
        {
            if (newFolderName.Text == "Digite o nome da pasta....")
                newFolderName.Text = "";
        }

        private void newFolderName_Leave(object sender, EventArgs e)
        {
            if (newFolderName.Text == "")
                newFolderName.Text = "Digite o nome da pasta....";
        }

        private void addFolder_Move(object sender, EventArgs e)
        {

        }

        private void Organizer_Load(object sender, EventArgs e)
        {

        }

        private void Organizer_Click(object sender, EventArgs e)
        {
            Organizer
        }
    }
}
