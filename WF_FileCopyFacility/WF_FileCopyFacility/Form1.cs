using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDirectory;
using System.IO.Compression;


namespace WF_FileCopyFacility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            lblFileCopyInformation.Text = "";
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            CopyDirectory.FileCopyFacility cf = new CopyDirectory.FileCopyFacility();
            int result = cf.DirectoryCopy(@source, @destination, true);

            if (result == 0)
            {
                lblFileCopyInformation.Text += "File Copy successfull ..";

                lsbFileInfo.Items.Clear();
                lsbFileInfo.DataSource = cf._listFiles;

            }
            else
            {
                lblFileCopyInformation.Text += cf.message;

            }
        }

        private void btnCopyZip_Click(object sender, EventArgs e)
        {
            lblFileCopyInformation.Text = "";
            string startPath = txtSource.Text;
            string extractPath = txtDestination.Text;

            CopyDirectory.FileCopyFacility cf = new CopyDirectory.FileCopyFacility();
            string result = cf.ZipCopyFolder(startPath, extractPath);

            if (result == "0")
            {
                lblFileCopyInformation.Text += "File Copy successfull ..";
            }
            else
            {
                lblFileCopyInformation.Text += result;

            }

        }

        private void btnXCopy_Click(object sender, EventArgs e)
        {
            lblFileCopyInformation.Text = "";
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            CopyDirectory.FileCopyFacility cf = new CopyDirectory.FileCopyFacility();
            string result = cf.XCopyFolder(source, destination);

            if (result == "0")
            {
                lblFileCopyInformation.Text += "File Copy successfull ..";
            }
            else
            {
                lblFileCopyInformation.Text += result;

            }
        }


    }
}
