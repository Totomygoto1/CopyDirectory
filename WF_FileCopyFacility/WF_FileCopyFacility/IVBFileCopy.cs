using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_FileCopyFacility
{
    public interface IVBFileCopy
    {
        string VBCopyFolder(string fromDirectory, string toDirectory);
    }
}
