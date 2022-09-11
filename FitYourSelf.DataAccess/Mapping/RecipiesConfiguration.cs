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
    public class RecipiesConfiguration:EntityTypeConfiguration<Recipies>
    {
        public RecipiesConfiguration()
        {
            HasKey(r => r.RecipiesID);

            Property(r => r.RecipiesID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(r => r.RecipiesName)
                .HasColumnType("nvarchar")
                .HasColumnName("Tarif Başlığı")
                .HasMaxLength(250)
                .IsRequired();

            Property(r => r.RecipeIngredients)
                .HasColumnType("ntext")
                .HasColumnName("Tarif Malzemeleri")
                .IsRequired();

            Property(r => r.RecipeDetail)
                .HasColumnType("ntext")
                .HasColumnName("Tarif Detayları")
                .IsRequired();



            HasRequired(ui => ui.UserInfo)
                .WithMany(r => r.Recipies)
                .HasForeignKey(ui => ui.UserInfoID);
        }
    }
}
