using KillerApp.Data.Context;
using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Repository
{
    public class AccountRepository
    {
        IAccountContext accountContext = new AccountSQLContext();
        public User GetAccount(string username)
        {
            return accountContext.GetAccount(username);
        }

        public bool CheckLogin(string username, string password)
        {
            return accountContext.CheckLogin(username, password);
        }
    }
}
