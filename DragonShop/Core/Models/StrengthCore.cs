using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    public sealed class StrengthCore : IEquatable<StrengthCore>
    {
        public long ID { get; set; }
        public string Kind { get; set; }

        public StrengthCore() { }
        public StrengthCore(StrengthCore strength)
        {
            ID = strength.ID;
            Kind = strength.Kind;
        }
        public StrengthCore(int id, string kind)
        {
            ID = id;
            Kind = kind;
        }

        public bool Equals([AllowNull] StrengthCore other)
        {
            return other == null ? false : ID == other.ID;
        }
        public sealed override bool Equals(object obj)
        {
            return Equals(obj as StrengthCore);
        }
        public sealed override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Strength: ");
            stringBuilder.Append("[ID]: " + ID + ", ");
            stringBuilder.Append("[Kind]: " + Kind + " ]");
            return stringBuilder.ToString();
        }
        public sealed override int GetHashCode()
        {
            return HashCode.Combine(ID, Kind);
        }
    }
}
