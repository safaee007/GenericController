using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericController.Controllers
{
    public class UsersController : GenericController<Models.User>
    {
        public UsersController(Services.IUserService service): base (service)
        {

        }
    }
}