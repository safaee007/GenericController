using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericController.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T: Models.BaseModel
    {
        private readonly Services.IGenericService<T> _service;
        private protected HttpContext _httpContext;
        private int _entity;
        public GenericController(Services.IGenericService<T> service, IHttpContextAccessor context)
        {
            _service = service;
            //_entity = entity;

            var aaaa = Request.Query;
            var path = context.HttpContext.Request.Path;
        }

        [HttpGet]
        [Authentication(Entity = 1)]
        public async Task<List<T>> List([FromQuery]Models.Filter filters) 
        {
            var sssssss = _entity;
            var aaa = Request.HttpContext;
            return await _service.GetList(filters);
        }

        [HttpGet("{id}")]
        public async Task<T> Get(int id)
        {
            return await _service.GetItem(id);
        }

        [HttpPost]
        public async Task<bool> Add([FromBody] T model)
        {
            return true;
        }
    }
}

//InvalidOperationException: Unable to resolve service for type 'GenericController.Services.IProductService' 
//while attempting to activate 'GenericController.Controllers.ProductsController'.