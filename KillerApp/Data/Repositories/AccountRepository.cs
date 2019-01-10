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
        public User GetAccount(string email)
        {
            return accountContext.GetAccount(email);
        }

        public bool CheckLogin(string email, string password)
        {
            return accountContext.CheckLogin(email, password);
        }
    }
}
