namespace WF_FileCopyFacility
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblFileCopyInformation = new System.Windows.Forms.Label();
            this.btnCopyZip = new System.Windows.Forms.Button();
            this.btnXCopy = new System.Windows.Forms.Button();
            this.lblSourcemsg = new System.Windows.Forms.Label();
            this.lblDestinationmsg = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lsbFileInfo = new System.Windows.Forms.ListBox();
            this.lblCopyFromTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(58, 266);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 43);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy Files";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(55, 38);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(167, 17);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Specify a Source Folder: ";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(58, 87);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(358, 22);
            this.txtSource.TabIndex = 2;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(55, 132);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(189, 17);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Specify a Destination Folder:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(58, 181);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(358, 22);
            this.txtDestination.TabIndex = 4;
            this.txtDestination.Text = "C:\\CopiedFiles";
            // 
            // lblFileCopyInformation
            // 
            this.lblFileCopyInformation.AutoSize = true;
            this.lblFileCopyInformation.Location = new System.Drawing.Point(55, 310);
            this.lblFileCopyInformation.Name = "lblFileCopyInformation";
            this.lblFileCopyInformation.Size = new System.Drawing.Size(0, 17);
            this.lblFileCopyInformation.TabIndex = 5;
            // 
            // btnCopyZip
            // 
            this.btnCopyZip.Location = new System.Drawing.Point(187, 267);
            this.btnCopyZip.Name = "btnCopyZip";
            this.btnCopyZip.Size = new System.Drawing.Size(101, 42);
            this.btnCopyZip.TabIndex = 7;
            this.btnCopyZip.Text = "Zip Copy";
            this.btnCopyZip.UseVisualStyleBackColor = true;
            this.btnCopyZip.Click += new System.EventHandler(this.btnCopyZip_Click);
            // 
            // btnXCopy
            // 
            this.btnXCopy.Location = new System.Drawing.Point(313, 266);
            this.btnXCopy.Name = "btnXCopy";
            this.btnXCopy.Size = new System.Drawing.Size(123, 43);
            this.btnXCopy.TabIndex = 8;
            this.btnXCopy.Text = "XCopy Copy";
            this.btnXCopy.UseVisualStyleBackColor = true;
            this.btnXCopy.Click += new System.EventHandler(this.btnXCopy_Click);
            // 
            // lblSourcemsg
            // 
            this.lblSourcemsg.AutoSize = true;
            this.lblSourcemsg.Location = new System.Drawing.Point(55, 55);
            this.lblSourcemsg.Name = "lblSourcemsg";
            this.lblSourcemsg.Size = new System.Drawing.Size(435, 17);
            this.lblSourcemsg.TabIndex = 10;
            this.lblSourcemsg.Text = "You must define a Source Drive and Folder Path , C:\\Folder\\Source\\";
            // 
            // lblDestinationmsg
            // 
            this.lblDestinationmsg.AutoSize = true;
            this.lblDestinationmsg.Location = new System.Drawing.Point(55, 149);
            this.lblDestinationmsg.Name = "lblDestinationmsg";
            this.lblDestinationmsg.Size = new System.Drawing.Size(487, 17);
            this.lblDestinationmsg.TabIndex = 11;
            this.lblDestinationmsg.Text = "You must define a Destination Drive and Folder Path , C:\\Folder\\Destination\\";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(58, 374);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(0, 17);
            this.lblFiles.TabIndex = 12;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(55, 218);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(676, 17);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Use button \'Copy Files\' for recursive copy and to print out all files being copie" +
    "d during the copying process";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(58, 235);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(498, 17);
            this.lblMessage2.TabIndex = 14;
            this.lblMessage2.Text = "\'Zip Copy\' uses ZipFile.ExtractToDirectory, \'XCopy Copy\' uses utility xcopy.exe";
            // 
            // lsbFileInfo
            // 
            this.lsbFileInfo.FormattingEnabled = true;
            this.lsbFileInfo.ItemHeight = 16;
            this.lsbFileInfo.Location = new System.Drawing.Point(58, 360);
            this.lsbFileInfo.Name = "lsbFileInfo";
            this.lsbFileInfo.ScrollAlwaysVisible = true;
            this.lsbFileInfo.Size = new System.Drawing.Size(673, 68);
            this.lsbFileInfo.TabIndex = 16;
            // 
            // lblCopyFromTo
            // 
            this.lblCopyFromTo.AutoSize = true;
            this.lblCopyFromTo.Location = new System.Drawing.Point(62, 337);
            this.lblCopyFromTo.Name = "lblCopyFromTo";
            this.lblCopyFromTo.Size = new System.Drawing.Size(149, 17);
            this.lblCopyFromTo.TabIndex = 17;
            this.lblCopyFromTo.Text = "Copy From File To File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopyFromTo);
            this.Controls.Add(this.lsbFileInfo);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblDestinationmsg);
            this.Controls.Add(this.lblSourcemsg);
            this.Controls.Add(this.btnXCopy);
            this.Controls.Add(this.btnCopyZip);
            this.Controls.Add(this.lblFileCopyInformation);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "File Copy Facility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblFileCopyInformation;
        private System.Windows.Forms.Button btnCopyZip;
        private System.Windows.Forms.Button btnXCopy;
        private System.Windows.Forms.Label lblSourcemsg;
        private System.Windows.Forms.Label lblDestinationmsg;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.ListBox lsbFileInfo;
        private System.Windows.Forms.Label lblCopyFromTo;
    }
}
