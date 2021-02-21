﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    public class FileCopyFacility : ICopyFacility
    {
        public List<string> _listFiles = new List<string>();

        public int DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {

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
                        Console.WriteLine("Please make sure drive and folder path is correct for destination folder\n");
                        return 0;
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
                Console.WriteLine("Please make sure drive and folder path is correct for source folder\n");
                return 0;
            }

            return 1;

        }
   

    }
}
