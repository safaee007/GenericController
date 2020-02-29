using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericController.Controllers
{
    public class ToursController : GenericController<Models.Tour>
    {
        public ToursController(Services.ITourService service, IHttpContextAccessor context) : base(service, context)
        {

        }
    }
}