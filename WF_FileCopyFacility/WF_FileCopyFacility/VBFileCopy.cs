using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;

namespace WF_FileCopyFacility
{
    public class VBFileCopy : IVBFileCopy
    {

        public string VBCopyFolder(string fromDirectory, string toDirectory)
        {
            string message = "0";
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(fromDirectory, toDirectory);
            }
            catch (Exception e)
            {
                message = "Please make sure drive and folder path is correct for source and destination folder\n";
                return message;
            }
            return message;
        }

    }
}
