using Core.Exceptions;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace BusinessLogic.Infrastructure
{
    public class XmlDataLoader : IDataLoader
    {
        private readonly IFile file;
        public XmlDataLoader(IFile file) => this.file = file;
        public IFile Load(string path)
        {
            if (File.Exists(path))
            {
                throw new FileDoesNotExistException("The file does not exist", path);
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(path);

            XmlElement root = xmlDocument.DocumentElement;
            var title = root.GetElementsByTagName(nameof(file.Titile).ToLower())[0];
            var lines = root.GetElementsByTagName(nameof(file.Lines).ToLower());

            for (int i = 0; i < lines.Count; i++)
            {
                file.Lines.Add(lines[i].InnerText);
            }

            return file;
        }
    }
}
