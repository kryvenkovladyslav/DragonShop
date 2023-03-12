using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    [Table("Strength")]
    public sealed class StrengthCore : IEquatable<StrengthCore>
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }

        [Column("Kind")]
        public string Kind { get; set; }

        public IEnumerable<TobaccoCore> Tobaccos { get; set; }

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
