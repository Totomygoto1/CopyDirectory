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
using WF_FileCopyFacility;
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

            FileCopyFacility cf = new FileCopyFacility();

            string result = cf.DirectoryCopy(@source, @destination, true);

            if (result == "0")
            {
                lblFileCopyInformation.Text += "File Copy successfull ..";
                foreach (string s in cf._listFiles)
                {
                    lblFiles.Text += s;
                }
            }
            else
            {
                lblFileCopyInformation.Text += result;

            }
        }

        private void btnCopyZip_Click(object sender, EventArgs e)
        {
            lblFileCopyInformation.Text = "";
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            string startPath = @source;
            string zipPath = startPath + ".zip";
            string extractPath = @destination;

            FileCopyFacility cf = new FileCopyFacility();
            string result = cf.ZipCopyFolder(startPath, extractPath, zipPath);
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

            FileCopyFacility cf = new FileCopyFacility();

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

        private void btnVBCopy_Click(object sender, EventArgs e)
        {
            lblFileCopyInformation.Text = "";
            string fromDirectory = txtSource.Text;
            string toDirectory = txtDestination.Text;
            FileCopyFacility cf = new FileCopyFacility();
            string result = cf.VBCopyFolder(fromDirectory, toDirectory);
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
