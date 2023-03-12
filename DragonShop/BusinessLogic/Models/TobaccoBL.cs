using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BusinessLogic.Models
{
    public sealed class TobaccoBL : IEquatable<TobaccoBL>
    { 
        public long ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Leaf { get; set; }
        public string Package { get; set; }
        public bool IsSmoky { get; set; }
        public bool IsMixed { get; set; }
        public bool IsMint { get; set; }
        public bool IsSweet { get; set; }
        public bool IsIced { get; set; }

        public long ManufacturerID { get; set; }
        public ManufacturerBL Manufacturer { get; set; }

        public long StrengthID { get; set; }
        public StrengthBL Strength { get; set; }

        public ProductBL Product { get; set; }

        public TobaccoBL() { }

        public TobaccoBL(TobaccoBL tobaccoBL)
        {
            ID = tobaccoBL.ID;
            Name = tobaccoBL.Name;
            Weight = tobaccoBL.Weight;
            Leaf = tobaccoBL.Leaf;
            Package = tobaccoBL.Package;
            IsSmoky = tobaccoBL.IsSmoky;
            IsMixed = tobaccoBL.IsMixed;
            IsMint = tobaccoBL.IsMint;
            IsSweet = tobaccoBL.IsSweet;
            IsIced = tobaccoBL.IsIced;
        }

        public TobaccoBL(long id, string name, string leaf, double weight, string package,
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

        public bool Equals([AllowNull] TobaccoBL other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as TobaccoBL);
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
