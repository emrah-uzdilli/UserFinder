using System;
using System.Collections.Generic;
using System.Text;
using UserFinder.Entities;

namespace UserFinder.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUser();
        User GetUserById(int id);

        User CreatUser(User user);
        User UpdateUser(User user);

        void DeleteUser(int id);

    }
}
