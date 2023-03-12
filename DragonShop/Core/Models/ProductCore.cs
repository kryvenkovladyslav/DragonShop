using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    public sealed class ProductCore : IEquatable<ProductCore>
    {
        [Key]
        [ForeignKey("Tobacco")]
        [Column("ID")]
        public long ID { get; set; }


        [Column("Price")]
        public decimal Price { get; set; }

        [Column("Is_Available")]
        public bool IsAvailable { get; set; }

        [Column("Discount")]
        public int Discount { get; set; }

        [Column("Image_Path")]
        public string ImagePath { get; set; }

        [Column("Description_Path")]
        public string DescriptionPath { get; set; }

        public TobaccoCore Tobacco { get; set; }

        public ProductCore() { }

        public ProductCore(ProductCore product)
        {
            ID = product.ID;
            Price = product.Price;
            IsAvailable = product.IsAvailable;
            Discount = product.Discount;
            ImagePath = product.ImagePath;
        }

        public ProductCore(long id, decimal price, bool isAvailable, int discount, string imagePath)
        {
            ID = id;
            Price = price;
            IsAvailable = isAvailable;
            Discount = discount;
            ImagePath = imagePath;
        }

        public bool Equals([AllowNull] ProductCore other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as ProductCore);
        }

        public sealed override int GetHashCode()
        {
            return HashCode.Combine(ID, Price, IsAvailable, Discount, ImagePath);
        }

        public sealed override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Product: ");
            stringBuilder.Append("[ID]: " + ID + ", ");
            stringBuilder.Append("[Price]: " + Price + ", ");
            stringBuilder.Append("[IsAvailable]: " + IsAvailable + ", ");
            stringBuilder.Append("[Discount]: " + Discount + ", ");
            stringBuilder.Append("[ImagePath]: " + ImagePath + " ]");
            return stringBuilder.ToString();
        }
    }
}
