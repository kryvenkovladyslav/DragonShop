using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BusinessLogic.Models
{
    public sealed class  StrengthBL : IEquatable<StrengthBL>
    {
        public long ID { get; set; }
        public string Kind { get; set; }

        public IEnumerable<TobaccoBL> Tobaccos { get; set; }

        public StrengthBL() { }

        public StrengthBL(StrengthBL strengthBL)
        {
            ID = strengthBL.ID;
            Kind = strengthBL.Kind;
        }

        public StrengthBL(int id, string kind)
        {
            ID = id;
            Kind = kind;
        }

        public bool Equals([AllowNull] StrengthBL other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as StrengthBL);
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
