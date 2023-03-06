using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataAccess.MSSQL.Models
{
    public sealed class Strength : IEquatable<Strength>
    {
        public long ID { get; set; }
        public string Kind { get; set; }

        public Strength() { }
        public Strength(Strength strength)
        {
            ID = strength.ID;
            Kind = strength.Kind;
        }
        public Strength(int id, string kind)
        {
            ID = id;
            Kind = kind;
        }

        public bool Equals([AllowNull] Strength other)
        {
            return other == null ? false : ID == other.ID;
        }
        public sealed override bool Equals(object obj)
        {
            Strength strength = obj as Strength;
            return strength == null ? false : Equals(strength);
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
