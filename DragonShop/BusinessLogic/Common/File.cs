using Core.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Common
{
    public class File : IFile
    {
        public IList<string> Titiles { get; set; }
        public IList<string> Lines { get; set; }

        public File(IList<string> titles, IList<string> lines)
            => (Titiles, Lines) = (titles, lines);
    }
}
