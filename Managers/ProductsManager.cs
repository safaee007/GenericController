using GenericController.Models;
using GenericController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Managers
{
    public class ProductsManager : Services.IProductService
    {
        public async Task<List<Product>> GetList(Filter model)
        {
            return new List<Product>
            {
                new Product{
                    ID = 1,
                    Title = "Product 1",
                    Price = 10
                },
                new Product{
                    ID = 2,
                    Title = "Product 2",
                    Price = 20
                }
            };
        }

        public bool AddItem(Product model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> EditItem(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int ID)
        {
            throw new NotImplementedException();
        }

        
    }
}
