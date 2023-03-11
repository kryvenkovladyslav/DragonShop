using System;
using System.IO;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    [Serializable]
    public class FileDoesNotExistException : Exception
    {
        private static readonly string path = "";

        public FileDoesNotExistException() { }

        public FileDoesNotExistException(string message, string path) : base(string.Concat(message, string.Empty, "path: ", path))
        {
            WriteToFile(string.Concat(message, string.Empty, "path: ", path));
        }

        public FileDoesNotExistException(string message, Exception inner) : base(message, inner)
        {
            WriteToFile(message);
        }

        private void WriteToFile(string message)
        {
            using (var stream = new StreamWriter(path))
            {
                stream.WriteLine(DateTime.Now + ": " + message);
            }
        }
    }
}
