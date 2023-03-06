using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataAccess.MSSQL.Models
{
    public sealed class Manufacturer : IEquatable<Manufacturer>
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string DescriptionPath { get; set; }

        public Manufacturer() { }
        public Manufacturer(Manufacturer manufacturer)
        {
            ID = manufacturer.ID;
            Name = manufacturer.Name;
            ImagePath = manufacturer.ImagePath;
            DescriptionPath = manufacturer.DescriptionPath;
        }
        public Manufacturer(int id, string name, string imagePath, string descriptionPath)
        {
            ID = id;
            Name = name;
            ImagePath = imagePath;
            DescriptionPath = descriptionPath;
        }

        public bool Equals([AllowNull] Manufacturer other)
        {
            return other == null ? false : ID == other.ID;
        }
        public sealed override bool Equals(object obj)
        {
            Manufacturer manufacturer = obj as Manufacturer;
            return manufacturer == null ? false : Equals(manufacturer);
        }
        public sealed override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Manufacturer: ");
            stringBuilder.Append("[ID]: " + ID + ", ");
            stringBuilder.Append("[Name]: " + Name + ", ");
            stringBuilder.Append("[ImagePath:] " + ImagePath + ", ");
            stringBuilder.Append("[DescriptionPath]:  " + DescriptionPath + " ]");
            return stringBuilder.ToString();
        }
        public sealed override int GetHashCode()
        {
            return HashCode.Combine(ID, Name, ImagePath, DescriptionPath);
        }
    }
}
