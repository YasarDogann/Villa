using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa_Businesss.Abstract;
using Villa_DataAccess.Abstract;
using Villa_Entity.Entities;

namespace Villa_Businesss.Concrete
{
    public class CounterManager : GenericManager<Counter>, ICounterService
    {
        public CounterManager(IGenericDal<Counter> genericDal) : base(genericDal)
        {
        }
    }
}
