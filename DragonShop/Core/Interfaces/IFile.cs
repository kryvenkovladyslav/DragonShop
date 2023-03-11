using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IFile
    {
        public string? Titile { get; set; }
        public ISet<string> Lines { get; set; }
    }
}
