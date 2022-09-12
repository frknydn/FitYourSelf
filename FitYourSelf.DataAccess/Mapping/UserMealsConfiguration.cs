using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class UserMealsConfiguration:EntityTypeConfiguration<UserMeals>
    {
        public UserMealsConfiguration()
        {
            HasKey(x => x.UserMealsID);
            Property(c => c.UserMealsID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.MealDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("Öğün Zamanı");
            Property(x => x.MealTimes).HasColumnName("Öğün İsmi").IsRequired();

            HasRequired(x => x.UserInfo)
                .WithMany(x => x.UserMeals)
                .HasForeignKey(x => x.UserInfoID);

                
            
        }
    }
}
