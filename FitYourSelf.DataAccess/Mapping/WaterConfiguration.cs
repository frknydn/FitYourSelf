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
    public class WaterConfiguration : EntityTypeConfiguration<Water>

    {
        public WaterConfiguration()
        {
            HasKey(x => x.WaterID);
            Property(x => x.WaterID)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.WaterAmount)
                .HasColumnName("İçilen Su Miktarı")
                .HasColumnType("decimal")
                .IsRequired();
            Property(x => x.GlassOfWater)
                .HasColumnName("İçilen Bardak")
                .HasColumnType("int")
                .IsRequired();
            Property(x => x.DateTime).HasColumnName("Su İçilen Zaman")
                .HasColumnType("datetime")
                .IsRequired();

            HasRequired(x => x.UserInfo)
              .WithMany(x => x.Water)
              .HasForeignKey(x => x.UserInfoID);

        }
    }
}
