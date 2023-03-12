using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    [Table("Tobacco")]
    public sealed class TobaccoCore : IEquatable<TobaccoCore>
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Weight")]
        public double Weight { get; set; }

        [Column("Leaf")]
        public string Leaf { get; set; }
       
        [Column("Package")]
        public string Package { get; set; }

        [Column("IsSmoky")]
        public bool IsSmoky { get; set; }

        [Column("IsMixed")]
        public bool IsMixed { get; set; }

        [Column("IsMint")]
        public bool IsMint { get; set; }

        [Column("IsSweet")]
        public bool IsSweet { get; set; }

        [Column("IsIced")]
        public bool IsIced { get; set; }

        [ForeignKey("Manufacturer_ID")]
        [Column("Manufacturer_ID")]
        public long ManufacturerID { get; set; }
        public ManufacturerCore Manufacturer { get; set; }

        [ForeignKey("Strength_ID")]
        [Column("Strength_ID")]
        public long StrengthID { get; set; }
        public StrengthCore Strength { get; set; }

        public ProductCore Product { get; set; }

        public TobaccoCore() { }

        public TobaccoCore(TobaccoCore tobacco)
        {
            ID = tobacco.ID;
            Name = tobacco.Name;
            Weight = tobacco.Weight;
            Leaf = tobacco.Leaf;
            Package = tobacco.Package;
            IsSmoky = tobacco.IsSmoky;
            IsMixed = tobacco.IsMixed;
            IsMint = tobacco.IsMint;
            IsSweet = tobacco.IsSweet;
            IsIced = tobacco.IsIced;
        }

        public TobaccoCore(long id, string name, string leaf, double weight, string package, 
            bool isSmoky, bool isMixed, bool isMint, bool isSweet, bool isIced)
        {
            ID = id;
            Name = name;
            Weight = weight;
            Leaf = leaf;
            Package = package;
            IsSmoky = isSmoky;
            IsMixed = isMixed;
            IsMint = isMint;
            IsSweet = isSweet;
            IsIced = isIced;
        }

        public bool Equals([AllowNull] TobaccoCore other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as TobaccoCore);
        }

        public sealed override int GetHashCode()
        {
            return HashCode.Combine(ID, Name, Leaf, Weight, IsSmoky, IsMixed, IsSweet, IsMint);
        }

        public sealed override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Tobacco: ");
            stringBuilder.Append("[ID]: " + ID + ", ");
            stringBuilder.Append("[Name]: " + Name + ", ");
            stringBuilder.Append("[Weight:] " + Weight + ", ");
            stringBuilder.Append("[Leaf]:  " + Leaf + ", ");
            stringBuilder.Append("[Package]: " + Package + ", ");
            stringBuilder.Append("[IsSmoky]: " + IsSmoky + ", ");
            stringBuilder.Append("[IsMixed]: " + IsMixed + ", ");
            stringBuilder.Append("[IsMint]: " + IsMint + ", ");
            stringBuilder.Append("[IsSweet]: " + IsSweet + ", ");
            stringBuilder.Append("[IsIced]: " + IsIced + " ]");
            return stringBuilder.ToString();
        }
    }
}
