using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class ChallengeYourSelf
    {
        public int ChallengeYourSelfID { get; set; }
        public DateTime DateTime { get; set; }
        public ChallengeYourSelfEnum ChallengeYourSelfEnum { get; set; }

        public int UserInfoID { get; set; }
        public UserInfo UserInfo { get; set; }
        

        


    }
}
