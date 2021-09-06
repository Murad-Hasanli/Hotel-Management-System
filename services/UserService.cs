using Hotel_Management_System.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.services
{
    class UserService : ICrud<User>
    {
        private static bool _isLoggedIn = false;
        private static User _loggedInUser = null;

        public static int lastId = 0;

        public bool Create(User model)
        {
            try
            {
                Database.users.Add(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Database.users.Remove(GetById(id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> GetAll() => Database.users;

        public User GetById(int id)
        {
            foreach (User user in Database.users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public bool Update(int id, User model)
        {
            try
            {
                for (int i = 0; i < Database.users.Count; i++)
                {
                    if (Database.users[i].Id == id)
                    {
                        Database.users[i] = new User(model.Name, model.Surname, model.Username, model.Email, model.Password, model.PassportNo, Database.users[i].Id);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool isLoggedIn => _isLoggedIn;
        public static User getLoggedInUser => _loggedInUser;

        public bool Login(string email, string password)
        {
            foreach(User user in Database.users)
            {
                if(user.Email == email && user.Password == password)
                {
                    _isLoggedIn = true;
                    _loggedInUser = user;
                    return true;
                }
            }

            return false;
        }

        public bool Register(User user)
        {
            return Create(user);
        }
    }
}
