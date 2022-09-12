using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserMeals
    {
        public int UserMealsID { get; set; }

        public DateTime MealDate { get; set; } = DateTime.Now;
        public MealTimes MealTimes { get; set; }

        public UserInfo UserInfo { get; set; }
        public int UserInfoID { get; set; }

        public ICollection<UserMealsAndFoods> UserMealsAndFoods { get; set; }
       



    }
}
