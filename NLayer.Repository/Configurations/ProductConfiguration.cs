using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ProductStock).IsRequired();
            builder.Property(x => x.ProductPrice).IsRequired().HasColumnType("decimal(18,2)"); // ################,## TOPLAM 18 VİRGÜLDEN SONRADA 2 OLARAK PRICE TUTULACAK
            builder.ToTable("Products");

            //BİR KATEGORİ VAR VE BU KATEGORİNİN ALTINDA BİR ÇOK PRODUCTLAR ( .WithMany(x => x.Products) ) VAR (BİRE ÇOK İLİŞKİ)
            builder.HasOne(x => x.Category).WithMany(x => x.Products); //.HasForeignKey(x=>x.CategoryID) 
        }
    }
}