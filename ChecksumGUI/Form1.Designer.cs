
namespace ChecksumGUI
{
    partial class ChecksumGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecksumGui));
            this.upload = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.uploadFile = new System.Windows.Forms.Label();
            this.completeMsg = new System.Windows.Forms.Label();
            this.exportNavigation = new System.Windows.Forms.LinkLabel();
            this.debug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.White;
            this.upload.Font = new System.Drawing.Font("Dubai", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(499, 41);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(155, 59);
            this.upload.TabIndex = 0;
            this.upload.Text = "Choose file";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.Firebrick;
            this.convert.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.White;
            this.convert.Location = new System.Drawing.Point(499, 106);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(155, 59);
            this.convert.TabIndex = 1;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(19, 187);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(635, 371);
            this.console.TabIndex = 3;
            this.console.Text = "";
            // 
            // uploadFile
            // 
            this.uploadFile.AutoSize = true;
            this.uploadFile.BackColor = System.Drawing.Color.Gainsboro;
            this.uploadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFile.ForeColor = System.Drawing.Color.DimGray;
            this.uploadFile.Location = new System.Drawing.Point(19, 56);
            this.uploadFile.MinimumSize = new System.Drawing.Size(450, 30);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(450, 30);
            this.uploadFile.TabIndex = 5;
            this.uploadFile.Text = "No file selected...";
            // 
            // completeMsg
            // 
            this.completeMsg.AutoSize = true;
            this.completeMsg.Location = new System.Drawing.Point(15, 573);
            this.completeMsg.Name = "completeMsg";
            this.completeMsg.Size = new System.Drawing.Size(237, 20);
            this.completeMsg.TabIndex = 6;
            this.completeMsg.Text = "Checksum conversion complete!";
            // 
            // exportNavigation
            // 
            this.exportNavigation.AutoSize = true;
            this.exportNavigation.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportNavigation.Location = new System.Drawing.Point(444, 569);
            this.exportNavigation.Name = "exportNavigation";
            this.exportNavigation.Size = new System.Drawing.Size(210, 30);
            this.exportNavigation.TabIndex = 7;
            this.exportNavigation.TabStop = true;
            this.exportNavigation.Text = "Navigate to Exported file";
            this.exportNavigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exportNavigation_LinkClicked);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(19, 106);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(127, 24);
            this.debug.TabIndex = 8;
            this.debug.Text = "Debug mode";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.CheckedChanged += new System.EventHandler(this.debug_CheckedChanged);
            // 
            // ChecksumGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(666, 608);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.exportNavigation);
            this.Controls.Add(this.completeMsg);
            this.Controls.Add(this.uploadFile);
            this.Controls.Add(this.console);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.upload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(688, 664);
            this.MinimumSize = new System.Drawing.Size(688, 664);
            this.Name = "ChecksumGui";
            this.Text = "Checksum Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label uploadFile;
        private System.Windows.Forms.Label completeMsg;
        private System.Windows.Forms.LinkLabel exportNavigation;
        private System.Windows.Forms.CheckBox debug;
    }
}

