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

        private bool folderSelected = false;

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

        private void generateByExtention ()
        {
            try
            {
                foreach (var item in extentionDropBox.Items)
                {
                    var node = foldersList.Nodes.Add(item.ToString().ToUpper());
                    node.Name = item.ToString().ToUpper();

                    var childNode = node.Nodes.Add(item.ToString());
                    childNode.Name = item.ToString();

                }
                successMessage("Folders was generate with success!", "Success Operation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.HelpLink, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleterFolder_Click(object sender, EventArgs e)
        {
            folderSelected = false;
            DialogResult result = folderSearch.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathSelected.Text = folderSearch.SelectedPath;
                folderSelected = true;
                var files = Directory.GetFiles(pathSelected.Text);

                foreach(string file in files)
                {
                    string fileExt = new FileInfo(file).Extension.Replace('.', ' ').TrimStart('.');
                    if (extentionDropBox.FindString(fileExt) == -1)
                        extentionDropBox.Items.Add(fileExt);
                    
                }

            } 
            else
            {
                folderSelected = false;
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
            if (pathSelected.Text == "No Folder Select")
            {
                MessageBox.Show("No Folder Selected, please select a path to organizer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                seleterFolder_Click(sender, e);
            }
            else
            {
                SelectNameFolderWindow dialogFolder = new SelectNameFolderWindow(extentionDropBox.Text, this);
                dialogFolder.ShowDialog();
            }

        }

        private void btnGenerateByExt_MouseHover(object sender, EventArgs e)
        {
            btnGenerateByExt.Cursor = Cursors.Hand;
        }

        private void BtnClearNode_Click(object sender, EventArgs e)
        {
           try
                {
                var result = MessageBox.Show("You want delete this node?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var confirm = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        foldersList.SelectedNode.Parent.Remove();
                        this.successMessage("Node removed with success!", "Operation Remove");
                    }
                }
                else
                {
                    var confirm = MessageBox.Show("Are you sure remove childs of this node?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        foldersList.SelectedNode.Parent.Nodes.Clear();
                        this.successMessage("Nodes removed with success!", "Operation Remove");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.HelpLink, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if ((result != DialogResult.Yes) || (foldersList.Nodes.Count == 0))
                {
                    if ((result == DialogResult.Yes) && (foldersList.Nodes.Count == 0))
                    {
                        MessageBox.Show("No Nodes to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return;
                }

                for (int i = 0; i < foldersList.Nodes.Count; i++)
                {
                    for (int j = 0; j < foldersList.Nodes[i].Nodes.Count; j++)
                    {
                        foldersList.Nodes[i].Nodes[j].Remove();
                    }
                }
                this.successMessage("Nodes removed with success!", "Operation Remove");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.HelpLink, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                foldersList.Nodes.Clear();
                this.successMessage("Tree View has cleared!", "Success Operation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.HelpLink, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (foldersList.SelectedNode != null)
            {
                this.deleteNode(foldersList);
            }
        }

        private void extentionDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void extentionDropBox_Click(object sender, EventArgs e)
        {
            if (pathSelected.Text == "No Folder Select")
            {
                MessageBox.Show("No Folder Selected, please select a path to organizer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                seleterFolder_Click(sender, e);
            }
        }

        private void btnGenerateByExt_Click(object sender, EventArgs e)
        { 
            if (pathSelected.Text == "No Folder Select")
            {
                seleterFolder_Click(sender, e);
                if (!folderSelected)
                {
                    MessageBox.Show("No Folder Selected!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
            if (foldersList.Nodes.Count > 0)
            {
                var res = MessageBox.Show("Are you sure? This action going to clear currents separations!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    var result = MessageBox.Show("Are you sure? This action going to create folders with extention!!\n\nEx: .png -> PNG", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        foldersList.Nodes.Clear();
                        generateByExtention();
                    }
                } 
            }
            else
            {
                var res = MessageBox.Show("Are you sure? This action going to create folders with extention!!\n\nEx: .png -> PNG", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    generateByExtention();
                }
            }
        }
    }
}
