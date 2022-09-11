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
    public class UserInfoConfiguration:EntityTypeConfiguration<UserInfo>
    {
        public UserInfoConfiguration()
        {
            HasKey(ui => ui.UserInfoID);

            Property(ui => ui.UserInfoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            Property(ui => ui.UserName)
                .HasColumnName("Kullanıcı Adı")
                .HasColumnType("nvarchar")
                .HasMaxLength(18)               
                .IsRequired();

            Property(ui => ui.Height)
                .HasColumnType("int")
                .HasColumnName("Boy")
                .IsOptional();

            Property(ui=>ui.Weight)
                .HasColumnType("int")
                .HasColumnName("Kilo")
                .IsOptional();

            Property(ui => ui.BodyMassIndex).HasColumnName("Vücut Kitle İndeksi")
                .HasColumnType("decimal")
                .HasPrecision(2, 2);

            Property(ui => ui.BMIStatus);

            Property(ui => ui.DailyCalorie).HasColumnType("int").IsOptional();
            Property(ui => ui.RequireCalorie).HasColumnType("int").IsOptional();

                
            
            
           
        }

       
    }
}
