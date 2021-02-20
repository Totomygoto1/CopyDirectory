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
    public class FileCopyFacility
    {
        public List<string> _listFiles = new List<string>();

        public string DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            string message = "0";

            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                DirectoryInfo[] dirs = dir.GetDirectories();

                FileInfo[] files = dir.GetFiles();

                if (!Directory.Exists(destDirName))
                {
                    try
                    {
                        Directory.CreateDirectory(destDirName);

                    }
                    catch (Exception e)
                    {
                        message = "Please make sure drive and folder path is correct for destination folder\n";
                        return message;
                    }
                }

                foreach (FileInfo file in files)
                {
                    string temppathfrom = Path.Combine(sourceDirName, file.Name);
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                    _listFiles.Add("Copy from: " + temppathfrom + " Copy to: " + temppath);

                }

                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppathfrom = Path.Combine(sourceDirName, subdir.Name);
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                        _listFiles.Add("Copy from: " + temppathfrom + " Copy to: " + temppath);
                    }
                }

            }
            catch (Exception e)
            {
                message = "Please make sure drive and folder path is correct for source folder\n";
                return message;
            }

            return "0";

        }

        public string ZipCopyFolder(string startPath, string extractPath, string zipPath)
        {
            string message = "0";
            try
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            catch (Exception e)
            {
                message = "Please make sure drive and folder path is correct for source and destination folder\n";
                return message;
            }
            return message;
        }

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

        public string XCopyFolder(string source, string destination)
        {
            string message = "0";

            string xcopyPath = Environment.GetEnvironmentVariable("WINDIR") + @"\System32\xcopy.exe";
            ProcessStartInfo info = new ProcessStartInfo(xcopyPath);

            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.Arguments = string.Format("\"{0}\" \"{1}\" /E /I", source, destination);

            Process process = Process.Start(info);
            process.WaitForExit();
            string result = process.StandardOutput.ReadToEnd();

            if (process.ExitCode != 0)
            {
                message = string.Format("Failed to copy {0} to {1}: {2}", source, destination, result);
                return message;
            }

            return "0";
        }

    }
}
