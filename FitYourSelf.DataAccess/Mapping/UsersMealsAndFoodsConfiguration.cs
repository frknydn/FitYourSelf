using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class UsersMealsAndFoodsConfiguration:EntityTypeConfiguration<UserMealsAndFoods>
    {
        public UsersMealsAndFoodsConfiguration()
        {
            this.HasKey(x => new
            {
                x.UserMealID,
                x.FoodID
            });

            this.HasRequired(u => u.UserMeals)
                .WithMany(u => u.UserMealsAndFoods)
                .HasForeignKey(u => u.UserMealID);

            this.HasRequired(u => u.Foods)
                .WithMany(u => u.UserMealsAndFoods)
                .HasForeignKey(u => u.FoodID);
        }
    }
}
