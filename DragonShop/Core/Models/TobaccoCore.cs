using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    public sealed class TobaccoCore : IEquatable<TobaccoCore>
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Leaf { get; set; }
        public string Slicing { get; set; }
        public string HeatResistance { get; set; }
        public string Package { get; set; }
        public bool IsSmoky { get; set; }
        public bool IsMixed { get; set; }
        public bool IsMint { get; set; }
        public bool IsSweet { get; set; }
        public bool IsIced { get; set; }

        public TobaccoCore() { }
        public TobaccoCore(TobaccoCore tobacco)
        {
            ID = tobacco.ID;
            Name = tobacco.Name;
            Weight = tobacco.Weight;
            Leaf = tobacco.Leaf;
            Slicing = tobacco.Slicing;
            HeatResistance = tobacco.HeatResistance;
            Package = tobacco.Package;
            IsSmoky = tobacco.IsSmoky;
            IsMixed = tobacco.IsMixed;
            IsMint = tobacco.IsMint;
            IsSweet = tobacco.IsSweet;
            IsIced = tobacco.IsIced;
        }
        public TobaccoCore(long id, string name, string leaf, double weight, string slicing, string heatResistance,
            string package, bool isSmoky, bool isMixed, bool isMint, bool isSweet, bool isIced)
        {
            ID = id;
            Name = name;
            Weight = weight;
            Leaf = leaf;
            HeatResistance = heatResistance;
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
            stringBuilder.Append("[HeatResistance]: " + HeatResistance + ", ");
            stringBuilder.Append("[Slicing]:  " + Slicing + ", ");
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
