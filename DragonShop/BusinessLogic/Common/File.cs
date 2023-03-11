using Core.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Common
{
    public class File : IFile
    {
        public string Titile { get; set; }
        public ISet<string> Lines { get; set; }
    }
}
