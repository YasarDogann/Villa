using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;
using Villa_DataAccess.Abstract;
using Villa_DataAccess.Context;
using Villa_DataAccess.Repositories;

namespace Villa_DataAccess.EntityFramework
{
    public class EfSubHeaderDal : GenericRepository<SubHeader>, ISubHeaderDal
    {
        public EfSubHeaderDal(VillaContext context) : base(context)
        {
        }
    }
}
