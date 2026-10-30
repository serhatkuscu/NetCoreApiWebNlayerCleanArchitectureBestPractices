using App.Repositories;
using App.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    internal class ProductService(IGenericRepository<Product> productRepository)
    {

        Task A()
        {
            var products =productRepository.GetAll().OrderByDescending(x => x.Price).Take(5);
        }
    }
}
