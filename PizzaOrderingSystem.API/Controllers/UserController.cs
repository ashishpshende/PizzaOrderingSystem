using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaOrderingSystem.API.DataManagers;
using PizzaOrderingSystem.Models.Classes.Users;
using PizzaOrderingSystem.Utils.Security;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUsersDataManager _usersDataManager;
        public UserController(IUsersDataManager usersDataManager)
        {
            _usersDataManager = usersDataManager;
        }
        [HttpGet("profile")]
        public User GetUser()
        {           
            return _usersDataManager.Get(1);
        }

        [HttpPost("login")]
        public User Login([FromBody] User user)
        {       
            if(string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return user;
            }
            if (_usersDataManager.Login(user))
            {
                Dictionary<string, string> tokenDictionary = new Dictionary<string, string>();
                tokenDictionary["user_id"] = user.Id.ToString();
                tokenDictionary["user_name"] = user.Name;
                user.Password = String.Empty;
                user.Id = 0;
                user.UserName = String.Empty;
                user.Token = SecurityUtils.Encrypt(JsonConvert.SerializeObject(tokenDictionary).ToString());
                return user;
            }
            return user;
        }
        [HttpPost("logout")]
        public bool Logout()
        {          
            return true;
        }
    }
}
