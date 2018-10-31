using KillerApp.Data.Repository;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Logic
{
    public class AccountLogic
    {
        private AccountRepository accountrep = new AccountRepository();

        public User GetAccount(string username)
        {
            return accountrep.GetAccount(username);
        }

        public bool CheckLogin(string username, string password)
        {
            return accountrep.CheckLogin(username,password);
        }
    }
}
