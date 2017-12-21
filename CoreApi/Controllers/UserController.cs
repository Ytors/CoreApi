using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [Route("[action]")]
        public UserModel QueryUser(int id =3)
        {
            var user = new UserModel()
            {
                Id = id,
                Name = "大神" + id,
                Sex = Convert.ToBoolean(id % 2)
            };
            return user;
        }

        [Route("GetUser")]
        public UserModel QueryUser([FromBody] UserModel um)
        {
            //var user = new UserModel()
            //{
            //    Id = id,
            //    Name = "大神" + id,
            //    Sex = Convert.ToBoolean(id % 2)
            //};
            return um;
        }

    }
}
