using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    public interface ICopyFacility
    {
        int DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);
    }
}
