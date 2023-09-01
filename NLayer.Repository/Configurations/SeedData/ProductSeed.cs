using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations.SeedData
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                ID = 1,
                CategoryID = 1,
                ProductName = "Lamy Dolma Kalem",
                ProductPrice = 100,
                ProductStock = 300,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                ID = 2,
                CategoryID = 2,
                ProductName = "Nutuk",
                ProductPrice = 250,
                ProductStock = 500,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                ID = 2,
                CategoryID = 2,
                ProductName = "Sapiens",
                ProductPrice = 150,
                ProductStock = 500,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                ID = 3,
                CategoryID = 3,
                ProductName = "FaberCastell Defter",
                ProductPrice = 50,
                ProductStock = 750,
                CreatedDate = DateTime.Now,
            });
        }
    }
}