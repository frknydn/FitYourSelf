using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class Water
    {
        public int WaterID {get;set;}
        public double? WaterAmount { get; set; }
        public int GlassOfWater { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;

        public UserInfo UserInfo { get; set; }
        public int UserInfoID { get; set; }
     


    }
}
