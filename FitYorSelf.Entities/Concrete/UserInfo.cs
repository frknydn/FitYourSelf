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
        public string UserName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BodyMassIndex { get; set; }
        public BMIStatus BMIStatus { get; set; }

        public decimal DailyCalorie { get; set; }
        public decimal RequireCalorie { get; set; }

        public UserRegisterInfo UserRegister { get; set; }

        public List<UserMeals> UserMeals { get; set; }

        public List<Water> Water { get; set; }

        public List<Recipies> Recipies { get; set; }
        public List<ChallengeYourSelf> ChallengeYourSelf { get; set; }
    }
}