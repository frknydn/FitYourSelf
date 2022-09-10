using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserMealsAndFoods
    {
        public int UserMealID { get; set; }
        public int FoodID { get; set; }
        public decimal Portion { get; set; }
        public decimal Calorie { get; set; }

        public UserMeals userMeals { get; set; }
        public Foods Foods { get; set; }
    }
}
