using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Villa_Businesss.Abstract;
using Villa_DataAccess.Abstract;
using Villa_Entity.Entities;

namespace Villa_Businesss.Concrete
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        public BannerManager(IGenericDal<Banner> genericDal) : base(genericDal)
        {
        }
    }
}
