using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<int, AppUser> Users;

        public FakeAppUserRepository()
        {
            if(Users == null)
            {
                Users = new Dictionary<int, AppUser>();

                Users.Add(1, new AppUser
                {
                    UserName = "John240",
                    Password = "password123",
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "JohnDoe@gmail.com",
                    isAuthenticated = false,
                });
            }
        }
        bool IAppUser.Login(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        void IAppUser.SetAuthentication(string UserName, bool IsAuthenticated)
        {
            throw new NotImplementedException();
        }

        AppUser IAppUser.GetByUserName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
