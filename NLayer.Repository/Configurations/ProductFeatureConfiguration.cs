using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.ID);

            //BİR PRODUCT VAR VE BU PRODUCT'A BAĞLI BİR PRODUCTFEATURE VAR ( .WithOne(x => x.ProductFeature) ) VAR (BİRE BİR İLİŞKİ)
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature); //.HasForeignKey<ProductFeature>(x=>x.ProductID) 
        }
    }
}
