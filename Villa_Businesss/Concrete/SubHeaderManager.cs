using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;
using Villa_Businesss.Abstract;
using Villa_DataAccess.Abstract;

namespace Villa_Businesss.Concrete
{
    public class SubHeaderManager : GenericManager<SubHeader>, ISubHeaderService
    {
        public SubHeaderManager(IGenericDal<SubHeader> genericDal) : base(genericDal)
        {
        }
    }
}
