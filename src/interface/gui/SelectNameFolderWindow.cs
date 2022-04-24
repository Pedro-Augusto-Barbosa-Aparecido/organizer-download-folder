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
            try
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

                        bool alreadyExist = false;

                        foreach (TreeNode node in organizer.foldersList.Nodes)
                        {
                            var treeNode = node.Nodes.Find(organizer.extentionDropBox.Text, true);
                            if (treeNode.Length == 1)
                            {
                                var result = MessageBox.Show("Extention Already exist on folder: " + treeNode[0].Parent.Text + ", do you want move the extention of folder?"
                                    , "Move Extention of Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    var origin = treeNode[0].Parent.Text;
                                    treeNode[0].Remove();

                                    var destin = folder.Nodes.Add(organizer.extentionDropBox.Text);
                                    destin.Name = organizer.extentionDropBox.Text;

                                    MessageBox.Show("Extention moved with success, from " + origin + " to " + destin.Name, "Success Operation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                                alreadyExist = true;

                                break;

                            }
                        }

                        if (!alreadyExist)
                        {
                            var newNode = folder.Nodes.Add(organizer.extentionDropBox.Text);
                            newNode.Name = organizer.extentionDropBox.Text;
                        }
                    }
                    else
                    {
                        var folder = organizer.foldersList.Nodes[organizer.foldersList.Nodes.IndexOfKey(organizer.folderName)];
                        TreeNode[] treeNodes = folder.Nodes.Find(organizer.extentionDropBox.Text, true);
                        bool alreadyExist = false;

                        foreach (TreeNode node in organizer.foldersList.Nodes)
                        {
                            var treeNode = node.Nodes.Find(organizer.extentionDropBox.Text, true);
                            if (treeNode.Length == 1)
                            {
                                var result = MessageBox.Show("Extention Already exist on folder: " + treeNode[0].Parent.Text + ", do you want move the extention of folder?"
                                    , "Move Extention of Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    var origin = treeNode[0].Parent.Text;
                                    treeNode[0].Remove();

                                    var destin = folder.Nodes.Add(organizer.extentionDropBox.Text);
                                    destin.Name = organizer.extentionDropBox.Text;

                                    MessageBox.Show("Extention moved with success, from " + origin + " to " + destin.Name, "Success Operation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                                alreadyExist = true;

                                break;

                            }
                        }
                        
                        if (!alreadyExist)
                        {
                            if (treeNodes.Length == 0)
                            {
                                var node = folder.Nodes.Add(organizer.extentionDropBox.Text);
                                node.Name = organizer.extentionDropBox.Text;
                            }
                            else if (treeNodes[0].Parent.Text == organizer.folderName)
                            {
                                MessageBox.Show("Extention Already exist in this folder!", "Duplicate Extention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.HelpLink, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
