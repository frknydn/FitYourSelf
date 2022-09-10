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

        public DateTime MealDate { get; set; } = DateTime.Now.Date;
        public MealTimes mealTimes { get; set; }

        public UserInfo UserInfo { get; set; }
        public int UserInfoID { get; set; }



    }
}
