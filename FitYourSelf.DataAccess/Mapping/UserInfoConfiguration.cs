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
            HasKey(x => x.UserInfoID);

            Property(x => x.UserInfoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            Property(x => x.UserName)
                .HasColumnName("Kullanıcı Adı")
                .HasColumnType("nvarchar")
                .HasMaxLength(18)               
                .IsRequired();

            Property(x => x.Height)
                .HasColumnType("int")
                .HasColumnName("Boy")
                .IsOptional();

            Property(x=>x.Weight)
                .HasColumnType("int")
                .HasColumnName("Kilo")
                .IsOptional();

            Property(x => x.BodyMassIndex).HasColumnName("Vücut Kitle İndeksi")
                .HasColumnType("decimal")
                .HasPrecision(2, 2);

            Property(x => x.BMIStatus);

            Property(x => x.DailyCalorie).HasColumnType("int").IsOptional();
            Property(x => x.RequiredCalorie).HasColumnType("int").IsOptional();

            HasOptional(x => x.UserRegister)
                .WithRequired(x => x.UserInfo).WillCascadeOnDelete(false);

            HasMany(x => x.UserMeals)
            .WithRequired(x => x.UserInfo)
            .HasForeignKey(x => x.UserMealsID);

            HasMany(x => x.Water)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.WaterID);

            HasMany(x => x.Recipies)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.RecipiesID);
            
            HasMany(x => x.ChallengeYourSelf)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.ChallengeYourSelfID);

           




        }

       
    }
}
