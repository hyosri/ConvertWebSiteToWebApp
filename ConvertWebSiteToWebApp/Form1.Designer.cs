namespace ConvertWebSiteToWebApp
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.chkDesignerFile = new System.Windows.Forms.CheckBox();
            this.chkHandlerCodeBehind = new System.Windows.Forms.CheckBox();
            this.chkUpdateNamespace = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(399, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(31, 43);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(362, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // chkDesignerFile
            // 
            this.chkDesignerFile.AutoSize = true;
            this.chkDesignerFile.Location = new System.Drawing.Point(31, 146);
            this.chkDesignerFile.Name = "chkDesignerFile";
            this.chkDesignerFile.Size = new System.Drawing.Size(120, 17);
            this.chkDesignerFile.TabIndex = 2;
            this.chkDesignerFile.Text = "Create designer file";
            this.chkDesignerFile.UseVisualStyleBackColor = true;
            // 
            // chkHandlerCodeBehind
            // 
            this.chkHandlerCodeBehind.AutoSize = true;
            this.chkHandlerCodeBehind.Location = new System.Drawing.Point(31, 169);
            this.chkHandlerCodeBehind.Name = "chkHandlerCodeBehind";
            this.chkHandlerCodeBehind.Size = new System.Drawing.Size(210, 17);
            this.chkHandlerCodeBehind.TabIndex = 2;
            this.chkHandlerCodeBehind.Text = "Create Handler (ashx) CodeBehind file";
            this.chkHandlerCodeBehind.UseVisualStyleBackColor = true;
            // 
            // chkUpdateNamespace
            // 
            this.chkUpdateNamespace.AutoSize = true;
            this.chkUpdateNamespace.Location = new System.Drawing.Point(31, 192);
            this.chkUpdateNamespace.Name = "chkUpdateNamespace";
            this.chkUpdateNamespace.Size = new System.Drawing.Size(119, 17);
            this.chkUpdateNamespace.TabIndex = 2;
            this.chkUpdateNamespace.Text = "Update Namespace";
            this.chkUpdateNamespace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder path";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(31, 90);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(362, 20);
            this.txtNameSpace.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namespace";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(443, 218);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 32);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar,
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 275);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkUpdateNamespace);
            this.Controls.Add(this.chkHandlerCodeBehind);
            this.Controls.Add(this.chkDesignerFile);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Convert WAS to WAP";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.CheckBox chkDesignerFile;
        private System.Windows.Forms.CheckBox chkHandlerCodeBehind;
        private System.Windows.Forms.CheckBox chkUpdateNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
    }
}

