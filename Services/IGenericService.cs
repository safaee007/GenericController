using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Services
{
    public interface IGenericService<T> where T : Models.BaseModel
    {
        Task<List<T>> GetList(Models.Filter model);
        Task<T> EditItem(int ID);
        bool AddItem(T model);
        bool DeleteItem(int id);
        Task<T> GetItem(int ID);
    }
}
