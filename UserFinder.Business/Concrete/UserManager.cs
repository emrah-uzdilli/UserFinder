using System;
using System.Collections.Generic;
using System.Text;
using UserFinder.Business.Abstract;
using UserFinder.DataAccess.Abstract;
using UserFinder.DataAccess.Concrete;
using UserFinder.Entities;

namespace UserFinder.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository();
        }

        public User CreatUser(User user)
        {
            return _userRepository.CreatUser(user);
        }

        public void DeleteUser(int id)
        {
             _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
                return _userRepository.GetUserById(id);
            }

            throw new Exception("id can't be less than zero");
           
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
