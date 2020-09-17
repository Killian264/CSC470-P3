using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public interface IAppUser
    {
        bool Login(string UserName, string Password);
        void SetAuthentication(string UserName, bool IsAuthenticated);
        AppUser GetByUserName(string UserName);
    }
}
