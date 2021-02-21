using System;
using System.Collections.Generic;
using System.Text;

namespace CopyDirectory
{
    public interface IFileCopyFacility
    {
        string DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);
        string ZipCopyFolder(string startPath, string extractPath);
        string XCopyFolder(string source, string destination);
    }
}
