using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataAccess.Models
{
    public sealed class StrengthDAL : IEquatable<StrengthDAL>
    {
        public long ID { get; set; }
        public string Kind { get; set; }

        public StrengthDAL() { }
        public StrengthDAL(StrengthDAL strength)
        {
            ID = strength.ID;
            Kind = strength.Kind;
        }
        public StrengthDAL(int id, string kind)
        {
            ID = id;
            Kind = kind;
        }

        public bool Equals([AllowNull] StrengthDAL other)
        {
            return other == null ? false : ID == other.ID;
        }
        public sealed override bool Equals(object obj)
        {
            return Equals(obj as StrengthDAL);
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
