
namespace gui
{
    partial class Organizer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer));
            this.folderSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.seleterFolder = new System.Windows.Forms.Button();
            this.pathSelected = new System.Windows.Forms.TextBox();
            this.addFolder = new System.Windows.Forms.Button();
            this.extentionDropBox = new System.Windows.Forms.ComboBox();
            this.btnGenerateByExt = new System.Windows.Forms.Button();
            this.foldersList = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearNode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderSearch
            // 
            this.folderSearch.Description = "Escolha uma pasta para ser organizada....";
            this.folderSearch.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // seleterFolder
            // 
            this.seleterFolder.AutoEllipsis = true;
            this.seleterFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seleterFolder.BackColor = System.Drawing.SystemColors.Control;
            this.seleterFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seleterFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleterFolder.Location = new System.Drawing.Point(12, 12);
            this.seleterFolder.Name = "seleterFolder";
            this.seleterFolder.Size = new System.Drawing.Size(173, 23);
            this.seleterFolder.TabIndex = 0;
            this.seleterFolder.Text = "Select Folder";
            this.seleterFolder.UseVisualStyleBackColor = false;
            this.seleterFolder.Click += new System.EventHandler(this.seleterFolder_Click);
            // 
            // pathSelected
            // 
            this.pathSelected.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pathSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathSelected.Cursor = System.Windows.Forms.Cursors.No;
            this.pathSelected.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSelected.Location = new System.Drawing.Point(191, 12);
            this.pathSelected.Multiline = true;
            this.pathSelected.Name = "pathSelected";
            this.pathSelected.ReadOnly = true;
            this.pathSelected.Size = new System.Drawing.Size(524, 23);
            this.pathSelected.TabIndex = 1;
            this.pathSelected.Text = "No Folder Select";
            // 
            // addFolder
            // 
            this.addFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFolder.Location = new System.Drawing.Point(191, 39);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(155, 21);
            this.addFolder.TabIndex = 3;
            this.addFolder.Text = "Add Folder";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            this.addFolder.Move += new System.EventHandler(this.addFolder_Move);
            // 
            // extentionDropBox
            // 
            this.extentionDropBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extentionDropBox.FormattingEnabled = true;
            this.extentionDropBox.Location = new System.Drawing.Point(12, 39);
            this.extentionDropBox.Name = "extentionDropBox";
            this.extentionDropBox.Size = new System.Drawing.Size(173, 21);
            this.extentionDropBox.TabIndex = 5;
            this.extentionDropBox.SelectedIndexChanged += new System.EventHandler(this.extentionDropBox_SelectedIndexChanged);
            this.extentionDropBox.Click += new System.EventHandler(this.extentionDropBox_Click);
            // 
            // btnGenerateByExt
            // 
            this.btnGenerateByExt.AutoSize = true;
            this.btnGenerateByExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateByExt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateByExt.Location = new System.Drawing.Point(550, 39);
            this.btnGenerateByExt.Name = "btnGenerateByExt";
            this.btnGenerateByExt.Size = new System.Drawing.Size(165, 46);
            this.btnGenerateByExt.TabIndex = 7;
            this.btnGenerateByExt.Text = "Generate Folders By Extention";
            this.btnGenerateByExt.UseVisualStyleBackColor = true;
            this.btnGenerateByExt.Click += new System.EventHandler(this.btnGenerateByExt_Click);
            this.btnGenerateByExt.MouseHover += new System.EventHandler(this.btnGenerateByExt_MouseHover);
            // 
            // foldersList
            // 
            this.foldersList.Location = new System.Drawing.Point(12, 157);
            this.foldersList.Name = "foldersList";
            this.foldersList.ShowNodeToolTips = true;
            this.foldersList.Size = new System.Drawing.Size(703, 281);
            this.foldersList.TabIndex = 8;
            this.foldersList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.foldersList_AfterSelect);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(352, 61);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 24);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearNode
            // 
            this.btnClearNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearNode.Location = new System.Drawing.Point(12, 61);
            this.btnClearNode.Name = "btnClearNode";
            this.btnClearNode.Size = new System.Drawing.Size(173, 24);
            this.btnClearNode.TabIndex = 10;
            this.btnClearNode.Text = "Clear Selected Folder";
            this.btnClearNode.UseVisualStyleBackColor = true;
            this.btnClearNode.Click += new System.EventHandler(this.BtnClearNode_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(191, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear All Folders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSelected.Location = new System.Drawing.Point(352, 39);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(192, 21);
            this.btnDeleteSelected.TabIndex = 12;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateFolder.Location = new System.Drawing.Point(550, 92);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(165, 59);
            this.btnCreateFolder.TabIndex = 13;
            this.btnCreateFolder.Text = "Create Folders";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveFiles.Location = new System.Drawing.Point(352, 92);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(192, 59);
            this.btnMoveFiles.TabIndex = 14;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearNode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.foldersList);
            this.Controls.Add(this.btnGenerateByExt);
            this.Controls.Add(this.extentionDropBox);
            this.Controls.Add(this.addFolder);
            this.Controls.Add(this.pathSelected);
            this.Controls.Add(this.seleterFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Organizer";
            this.Text = "Organizer";
            this.Load += new System.EventHandler(this.Organizer_Load);
            this.Click += new System.EventHandler(this.Organizer_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button seleterFolder;
        private System.Windows.Forms.TextBox pathSelected;
        private System.Windows.Forms.FolderBrowserDialog folderSearch;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.Button btnGenerateByExt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearNode;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TreeView foldersList;
        public System.Windows.Forms.ComboBox extentionDropBox;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnMoveFiles;
    }
}

