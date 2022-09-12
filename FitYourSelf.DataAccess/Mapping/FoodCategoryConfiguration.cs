using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class FoodCategoryConfiguration
        : EntityTypeConfiguration<FoodCategory>
    {
        public FoodCategoryConfiguration()
        {
            HasKey(fc => fc.FoodCategoryId);
            Property(fc => fc.FoodCategoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(fc => fc.CategoryName)
                .HasColumnType("nvarchar").HasMaxLength(50).HasColumnName("Yemek Kategorisi").IsRequired();


            //Bir kategorinin bir çok yemeği olur bire çokun çok kısmı!
            HasMany(f => f.Foods)
                .WithRequired(fc => fc.FoodCategory)
                .HasForeignKey(f => f.FoodID);
        }
    }
}
