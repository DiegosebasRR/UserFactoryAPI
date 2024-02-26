using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UserFactoryAPI.Models;
using UserFactoryAPI.Services;

namespace UserFactoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers(int? results, int? seed, int page = 1, int pageSize = 10)
        {
            Random random;

            if (seed.HasValue)
            {
                random = new Random(seed.Value);
            }
            else
            {
                random = new Random();
            }

            List<User> users = UsersServices.GenerateRandomUsers(results ?? 10, random);


            int totalPages = (int)Math.Ceiling((double)results / pageSize);

            var paginatedUsers = users.Skip((page - 1) * pageSize).Take(pageSize);


            return paginatedUsers.ToList();
        }


    }
}
