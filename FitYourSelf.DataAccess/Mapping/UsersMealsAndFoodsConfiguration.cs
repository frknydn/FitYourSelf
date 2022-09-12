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
            HasKey(x => new
            {
                x.UserMealID,
                x.FoodID
            });

            HasRequired(u => u.UserMeals)
                .WithMany(u => u.UserMealsAndFoods)
                .HasForeignKey(u => u.UserMealID);

            HasRequired(u => u.Foods)
                .WithMany(u => u.UserMealsAndFoods)
                .HasForeignKey(u => u.FoodID);
        }
    }
}
