using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BusinessLogic.Models
{
    public sealed class ProductBL : IEquatable<ProductBL>
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public string ImagePath { get; set; }
        public string DescriptionPath { get; set; }

        public TobaccoBL Tobacco { get; set; }

        public ProductBL() { }

        public ProductBL(ProductBL productBL)
        {
            ID = productBL.ID;
            Price = productBL.Price;
            IsAvailable = productBL.IsAvailable;
            Discount = productBL.Discount;
            ImagePath = productBL.ImagePath;
        }

        public ProductBL(long id, decimal price, bool isAvailable, int discount, string imagePath)
        {
            ID = id;
            Price = price;
            IsAvailable = isAvailable;
            Discount = discount;
            ImagePath = imagePath;
        }

        public bool Equals([AllowNull] ProductBL other)
        {
            return other == null ? false : ID == other.ID;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as ProductBL);
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
