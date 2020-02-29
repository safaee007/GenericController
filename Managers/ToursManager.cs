using GenericController.Models;
using GenericController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace GenericController.Managers
{
    public class ToursManager : Services.ITourService
    {
        public async Task<List<Tour>> GetList(Filter model)
        {
            return new List<Tour>
            {
                new Tour{
                    ID = 1,
                    Title = "Product 1",
                    Price = 10
                },
                new Tour{
                    ID = 2,
                    Title = "Product 2",
                    Price = 20
                }
            };
        }

        public bool AddItem(Tour model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tour> EditItem(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Tour> GetItem(int ID)
        {
            throw new NotImplementedException();
        }

        
    }
}
