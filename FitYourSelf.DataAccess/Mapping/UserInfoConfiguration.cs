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
            this.HasKey(x => x.UserInfoID);

            this.Property(x => x.UserInfoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            this.Property(x => x.UserName)
                .HasColumnName("Kullanıcı Adı")
                .HasColumnType("nvarchar")
                .HasMaxLength(18)               
                .IsRequired();

            this.Property(x => x.Height)
                .HasColumnType("int")
                .HasColumnName("Boy")
                .IsOptional();

            this.Property(x=>x.Weight)
                .HasColumnType("int")
                .HasColumnName("Kilo")
                .IsOptional();

            this.Property(x => x.BodyMassIndex).HasColumnName("Vücut Kitle İndeksi")
                .HasColumnType("decimal")
                .HasPrecision(2, 2);

            this.Property(x => x.BMIStatus);

            this.Property(x => x.DailyCalorie).HasColumnType("int").IsOptional();
            this.Property(x => x.RequiredCalorie).HasColumnType("int").IsOptional();

            this.HasOptional(x => x.UserRegister)
                .WithRequired(x => x.UserInfo).WillCascadeOnDelete(false);

            this.HasMany(x => x.UserMeals)
            .WithRequired(x => x.UserInfo)
            .HasForeignKey(x => x.UserMealsID);

            this.HasMany(x => x.Water)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.WaterID);

            this.HasMany(x => x.Recipies)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.RecipiesID);

            this.HasMany(x => x.ChallengeYourSelf)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.ChallengeYourSelfID);

           




        }

       
    }
}
