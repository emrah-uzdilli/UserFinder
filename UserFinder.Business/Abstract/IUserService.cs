using System;
using System.Collections.Generic;
using System.Text;
using UserFinder.Entities;

namespace UserFinder.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUser();
        User GetUserById(int id);

        User CreatUser(User user);
        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
