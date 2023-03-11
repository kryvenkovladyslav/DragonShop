using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    [Table("Manufacturer")]
    public sealed class ManufacturerCore : IEquatable<ManufacturerCore>
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Image_Path")]
        public string ImagePath { get; set; }

        [Column("Description_Path")]
        public string DescriptionPath { get; set; }

        public IEnumerable<TobaccoCore> Tobaccos { get; set; } 

        public ManufacturerCore() { }

        public ManufacturerCore(ManufacturerCore manufacturer)
        {
            ID = manufacturer.ID;
            Name = manufacturer.Name;
            ImagePath = manufacturer.ImagePath;
            DescriptionPath = manufacturer.DescriptionPath;
        }

        public ManufacturerCore(int id, string name, string imagePath, string descriptionPath)
        {
            ID = id;
            Name = name;
            ImagePath = imagePath;
            DescriptionPath = descriptionPath;
        }

        public bool Equals([AllowNull] ManufacturerCore other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as ManufacturerCore);
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
