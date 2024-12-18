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
    public class EfVideoDal : GenericRepository<Video>, IVideoDal
    {
        public EfVideoDal(VillaContext context) : base(context)
        {
        }
    }
}