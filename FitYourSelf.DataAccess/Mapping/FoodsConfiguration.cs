using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class FoodsConfiguration : EntityTypeConfiguration<Foods>
    {
        public FoodsConfiguration()
        {
            HasKey(f => f.FoodID);
            Property(f => f.FoodName).HasColumnType("nvarchar").HasColumnName("Yiyecek İsmi").HasMaxLength(100).IsRequired();
            Property(f => f.Calorie).HasColumnType("decimal").HasPrecision(6, 2).HasColumnName("Kalori").IsRequired();
            Property(f => f.Carbonhidrate).HasColumnType("decimal").HasPrecision(6, 2).HasColumnName("Karbonhidrat").IsRequired();
            Property(f=>f.Sugar).HasColumnType("decimal").HasPrecision(6, 2).HasColumnName("Şeker").IsRequired();
            Property(f=>f.Fat).HasColumnType("decimal").HasPrecision(6, 2).HasColumnName("Yağ").IsRequired();

            HasRequired(f => f.FoodCategory)
                .WithMany(fc => fc.Foods)
                .HasForeignKey(f => f.FoodCategoryID);




        }
    }
}
