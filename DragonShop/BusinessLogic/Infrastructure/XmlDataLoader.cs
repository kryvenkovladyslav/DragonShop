using Core.Exceptions;
using Core.Interfaces;
using System.IO;
using System.Xml;

namespace BusinessLogic.Infrastructure
{
    public class XmlDataLoader : IDataLoader
    {
        private readonly IFile file;
        public XmlDataLoader(IFile file)
        {
            this.file = file;
        }
        public IFile Load(string path)
        {
            /*if (File.Exists(@"C:\Users\user\source\repos\DragonShop\DragonShop\Web\wwwroot\" + path))
            {
                throw new FileDoesNotExistException("The file does not exist", path);
            }*/

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Users\user\source\repos\DragonShop\DragonShop\Web\wwwroot\" + path);

            XmlElement root = xmlDocument.DocumentElement;
            var titles = root.GetElementsByTagName("Title");
            var lines = root.GetElementsByTagName("Article");

            for (int i = 0; i < titles.Count; i++)
            {
                file.Titiles.Add(titles[i].InnerText);
                file.Lines.Add(lines[i].InnerText);
            }

            return file;
        }
    }
}
