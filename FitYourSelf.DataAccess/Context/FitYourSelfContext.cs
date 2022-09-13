using FitYorSelf.Entities.Concrete;
using FitYourSelf.DataAccess.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Context
{
    public class FitYourSelfContext:DbContext
    {
        public FitYourSelfContext():base("Server=LAPTOP-RONOC5PG\\FURKANAYDIN;Database=FitYourSelf;Trusted_Connection=True;")
        {

        }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Water> Water { get; set; }
        public DbSet<Recipies> Recipies { get; set; }
        public DbSet<ChallengeYourSelf> ChallengeYourSelf { get; set; }        
        public DbSet<UserMeals> UserMeals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ChallengeYourselfConfiguration());
            modelBuilder.Configurations.Add(new FoodCategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodsConfiguration());
            modelBuilder.Configurations.Add(new RecipiesConfiguration());
            modelBuilder.Configurations.Add(new UserInfoConfiguration());
            modelBuilder.Configurations.Add(new UserMealsConfiguration());
            modelBuilder.Configurations.Add(new WaterConfiguration());
            
        }


    }
}
