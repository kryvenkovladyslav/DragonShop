using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IFile
    {
        public IList<string> Titiles { get; set; }
        public IList<string> Lines { get; set; }
    }
}
