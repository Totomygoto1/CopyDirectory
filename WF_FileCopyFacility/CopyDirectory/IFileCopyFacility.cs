using System;
using System.Collections.Generic;
using System.Text;

namespace CopyDirectory
{
    public interface IFileCopyFacility
    {
        int DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);
        int ZipCopyFolder(string startPath, string extractPath);
        int XCopyFolder(string source, string destination);
    }
}
