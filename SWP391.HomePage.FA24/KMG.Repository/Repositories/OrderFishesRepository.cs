﻿using KMG.Repository.Base;
using KMG.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KMG.Repository.Repositories
{
    public class OrderFishesRepository : GenericRepository<OrderFish>
    {

            private readonly SwpkoiFarmShopContext _context;
            public OrderFishesRepository(SwpkoiFarmShopContext context) => _context = context;

            public async Task<OrderFish> FirstOrDefaultAsync(Expression<Func<OrderFish, bool>> predicate)
            {
                return await _context.OrderFishes.FirstOrDefaultAsync(predicate);
            }


        }
    }

