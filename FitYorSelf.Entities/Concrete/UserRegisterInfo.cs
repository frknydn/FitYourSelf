
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserRegisterInfo 
    {
        public int RegisterID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public UserInfo UserInfo { get; set; }
    }
}
