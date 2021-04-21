﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserFinder.DataAccess.Abstract;
using UserFinder.Entities;

namespace UserFinder.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreatUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                var deletedUser = GetUserById(id);
                userDbContext.Users.Remove(deletedUser);
                userDbContext.SaveChanges();
            }
        }

        public List<User> GetAllUser()
        {
            using(var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }
    }
}
