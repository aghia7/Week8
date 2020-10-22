﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week8Project.Core.Entities;

namespace Week8Project.Core.Exceptions.Repositories
{
    public interface IProductRepository : IEntityRepository<Product>
    {
        Task<Product> GetProductWithMinimumPrice();
    }
}
