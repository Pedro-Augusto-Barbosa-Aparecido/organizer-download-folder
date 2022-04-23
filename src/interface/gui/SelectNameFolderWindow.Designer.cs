namespace gui
{
    partial class SelectNameFolderWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectNameFolderWindow));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.textFolderName = new System.Windows.Forms.TextBox();
            this.labelExt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(11, 54);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(278, 37);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Location = new System.Drawing.Point(13, 13);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(230, 13);
            this.labelFolderName.TabIndex = 2;
            this.labelFolderName.Text = "Digite o nome para os arquivos para extenção: ";
            // 
            // textFolderName
            // 
            this.textFolderName.Location = new System.Drawing.Point(11, 28);
            this.textFolderName.Name = "textFolderName";
            this.textFolderName.Size = new System.Drawing.Size(278, 20);
            this.textFolderName.TabIndex = 3;
            this.textFolderName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFolderName_KeyDown);
            // 
            // labelExt
            // 
            this.labelExt.AutoSize = true;
            this.labelExt.Location = new System.Drawing.Point(239, 12);
            this.labelExt.Name = "labelExt";
            this.labelExt.Size = new System.Drawing.Size(0, 13);
            this.labelExt.TabIndex = 4;
            // 
            // SelectNameFolderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 98);
            this.Controls.Add(this.labelExt);
            this.Controls.Add(this.textFolderName);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNameFolderWindow";
            this.Text = "What folder\'s name?";
            this.Load += new System.EventHandler(this.SelectNameFolderWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Label labelExt;
        public System.Windows.Forms.TextBox textFolderName;
    }
}