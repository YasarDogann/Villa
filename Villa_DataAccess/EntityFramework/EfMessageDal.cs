﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa_DataAccess.Abstract;
using Villa_DataAccess.Context;
using Villa_DataAccess.Repositories;
using Villa_Entity.Entities;

namespace Villa_DataAccess.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public EfMessageDal(VillaContext context) : base(context)
        {
        }
    }
}