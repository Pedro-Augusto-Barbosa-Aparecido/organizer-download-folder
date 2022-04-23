
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
            this.newFolderName = new System.Windows.Forms.TextBox();
            this.extentionDropBox = new System.Windows.Forms.ComboBox();
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
            this.addFolder.Location = new System.Drawing.Point(12, 50);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(173, 20);
            this.addFolder.TabIndex = 3;
            this.addFolder.Text = "Add Folder";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Move += new System.EventHandler(this.addFolder_Move);
            // 
            // newFolderName
            // 
            this.newFolderName.Location = new System.Drawing.Point(191, 51);
            this.newFolderName.Name = "newFolderName";
            this.newFolderName.Size = new System.Drawing.Size(173, 20);
            this.newFolderName.TabIndex = 4;
            this.newFolderName.Text = "Digite o nome da pasta....";
            this.newFolderName.Enter += new System.EventHandler(this.newFolderName_Enter);
            this.newFolderName.Leave += new System.EventHandler(this.newFolderName_Leave);
            // 
            // extentionDropBox
            // 
            this.extentionDropBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extentionDropBox.FormattingEnabled = true;
            this.extentionDropBox.Location = new System.Drawing.Point(370, 51);
            this.extentionDropBox.Name = "extentionDropBox";
            this.extentionDropBox.Size = new System.Drawing.Size(154, 21);
            this.extentionDropBox.TabIndex = 5;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.extentionDropBox);
            this.Controls.Add(this.newFolderName);
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
        private System.Windows.Forms.TextBox newFolderName;
        private System.Windows.Forms.ComboBox extentionDropBox;
    }
}

