using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class SelectNameFolderWindow : Form
    {
        String extention;
        Organizer organizer;
        public SelectNameFolderWindow(String ext, Organizer org)
        {
            InitializeComponent();  
            extention = ext;
            organizer = org;

        }

        private void SelectNameFolderWindow_Load(object sender, EventArgs e)
        {
            if ((extention == null) || (extention == ""))
            {
                labelExt.Text = "No Data";
            } 
            
            else
            {
                labelExt.Text = extention;
            }
        }

        private void addFolderOnTreeView ()
        {
            organizer.folderName = textFolderName.Text;
            if ((organizer.extentionDropBox.Text != "") 
                && (organizer.extentionDropBox.Text != null)
                && (textFolderName.Text != "")
                && (textFolderName.Text != null))
            {
                if (!organizer.foldersList.Nodes.ContainsKey(organizer.folderName))
                {
                    TreeNode folder = organizer.foldersList.Nodes.Add(organizer.folderName);
                    folder.Name = textFolderName.Text;

                    folder.Nodes.Add(new TreeNode(organizer.extentionDropBox.Text));

                }
                else
                {
                    var folder = organizer.foldersList.Nodes[organizer.foldersList.Nodes.IndexOfKey(organizer.folderName)];
                    TreeNode[] treeNodes = folder.Nodes.Find(organizer.extentionDropBox.Text, true);
                    if (treeNodes.Length > 0)
                    {
                        var node = folder.Nodes.Add(organizer.extentionDropBox.Text);
                        node.Name = organizer.extentionDropBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Extention Already exist in this folder!", "Duplicate Extention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                var button = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Error;
                String title = (textFolderName.Text != "") ? "Extention Error" : "Folder Error";
                String msg = (textFolderName.Text != "") ? "Extention not selected!" : "Folder Field is empty";
                MessageBox.Show(msg, title, button, icon);

            }

            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.addFolderOnTreeView();
        }

        private void textFolderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addFolderOnTreeView();
            }
        }
    }
}
