using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations.SeedData
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                ID = 1,
                CategoryName = "Kalemler",
                CreatedDate = DateTime.Now,
            },
            new Category
            {
                ID = 2,
                CategoryName = "Kitaplar",
                CreatedDate = DateTime.Now,
            },
            new Category
            {
                ID = 3,
                CategoryName = "Defterler",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
