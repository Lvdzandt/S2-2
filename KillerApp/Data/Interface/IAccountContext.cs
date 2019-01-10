using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Interface
{
    public interface IAccountContext
    {
        User GetAccount(string email);
        bool CheckLogin(string email, string password);
    }
}
