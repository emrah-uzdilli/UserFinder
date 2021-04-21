using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFinder.Business.Abstract;
using UserFinder.Business.Concrete;
using UserFinder.Entities;

namespace UserFinder.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController()
        {
            _userService = new UserManager();
        }
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUser();
        }
        /// <summary>
        /// Get User By Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }
        /// <summary>
        /// Create a User Definition
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public User Post([FromBody]User user)
        {
            return _userService.CreatUser(user);
        }
        /// <summary>
        /// Update the user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }
        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
