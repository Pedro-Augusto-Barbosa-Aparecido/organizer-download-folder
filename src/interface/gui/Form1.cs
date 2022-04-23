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
        public String folderName = "";
        public Organizer()
        {
            InitializeComponent();
        }

        private void deleteNode (TreeView nd, bool selected = true, TreeNode node = null)
        {
            if (selected)
            {
                var nodeSelectedName = nd.SelectedNode.Name;
                nd.SelectedNode.Remove();
                this.successMessage("Node " + nodeSelectedName + " removed with success!", "Operation Remove");
            } 
            else if (node != null)
            {
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    node.Remove();
                }
            }
            
        }

        private void successMessage (String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (extentionDropBox.FindString(fileExt) == -1)
                        extentionDropBox.Items.Add(fileExt);
                    
                }

            }

        }

        private void addFolder_Move(object sender, EventArgs e)
        {

        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            
        }

        private void Organizer_Click(object sender, EventArgs e)
        {
            
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            SelectNameFolderWindow dialogFolder = new SelectNameFolderWindow(extentionDropBox.Text, this);
            dialogFolder.ShowDialog();

        }

        private void btnGenerateByExt_MouseHover(object sender, EventArgs e)
        {
            btnGenerateByExt.Cursor = Cursors.Hand;
        }

        private void btnClearNode_Click(object sender, EventArgs e)
        {
            if (foldersList.SelectedNode != null)
            {
                this.deleteNode(foldersList);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < foldersList.Nodes.Count; i++)
            {
                for (int j = 0; j < foldersList.Nodes[i].Nodes.Count; j++)
                {
                    this.deleteNode(foldersList, false, foldersList.Nodes[i].Nodes[j]);
                }
            }
            this.successMessage("Nodes removed with success!", "Operation Remove");
        }
    }
}
