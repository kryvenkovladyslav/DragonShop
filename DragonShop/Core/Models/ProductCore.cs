using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Core.Models
{
    public sealed class ProductCore : IEquatable<ProductCore>
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public string ImagePath { get; set; }

        public ProductCore() { }
        public ProductCore(ProductCore product)
        {
            ID = product.ID;
            Name = product.Name;
            Price = product.Price;
            IsAvailable = product.IsAvailable;
            Discount = product.Discount;
            ImagePath = product.ImagePath;
        }
        public ProductCore(long id, string name, decimal price, bool isAvailable, int discount, string imagePath)
        {
            ID = id;
            Name = name;
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
            return HashCode.Combine(ID, Name, Price, IsAvailable, Discount, ImagePath);
        }
        public sealed override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Product: ");
            stringBuilder.Append("[ID]: " + ID + ", ");
            stringBuilder.Append("[Name]: " + Name + ", ");
            stringBuilder.Append("[Price]: " + Price + ", ");
            stringBuilder.Append("[IsAvailable]: " + IsAvailable + ", ");
            stringBuilder.Append("[Discount]: " + Discount + ", ");
            stringBuilder.Append("[ImagePath]: " + ImagePath + " ]");
            return stringBuilder.ToString();
        }
    }
}
