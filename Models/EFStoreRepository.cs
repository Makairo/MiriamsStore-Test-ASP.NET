﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiriamsStoreSln.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;
        public EFStoreRepository(StoreDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}