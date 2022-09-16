using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitYorSelf.Entities.Enums
{
    public enum MealTimes
    {
        [Display(Name = "Kahvaltı")]
        Breakfast = 1,
        [Display(Name = "Öğle Yemeği")]
        Lunch,
        [Display(Name = "Akşam Yemeği")]
        Dinner,
        [Display(Name = "Ara Öğün")]
        Snack
    }
}
