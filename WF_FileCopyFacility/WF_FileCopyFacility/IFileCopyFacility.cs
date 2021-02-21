using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_FileCopyFacility
{
    public interface IFileCopyFacility
    {
        string DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);
        string ZipCopyFolder(string startPath, string extractPath);
        string VBCopyFolder(string fromDirectory, string toDirectory);
        string XCopyFolder(string source, string destination);
    }
}
