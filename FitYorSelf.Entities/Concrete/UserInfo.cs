﻿
using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserInfo
    {
        public int UserInfoID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public double BodyMassIndex { get; set; }
        public BMIStatus BMIStatus { get; set; }

        public decimal DailyCalorie { get; set; }
        public decimal RequiredCalorie { get; set; }


        public List<UserMeals> UserMeals { get; set; }

        public List<Water> Water { get; set; }

        public List<Recipies> Recipies { get; set; }
        public List<ChallengeYourSelf> ChallengeYourSelf { get; set; }

        public  List<UserMassInfo> UserMassInfo { get; set; }
    }
}
