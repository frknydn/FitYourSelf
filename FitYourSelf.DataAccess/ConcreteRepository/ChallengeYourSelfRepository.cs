using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.ConcreteRepository
{
    public class ChallengeYourSelfRepository<T> where T : class
    {
        FitYourSelfContext db;
        public ChallengeYourSelfRepository()
        {
            db = new FitYourSelfContext();
        }

       
    }
}
