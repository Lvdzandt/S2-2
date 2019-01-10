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

        public User GetAccount(string email)
        {
            return accountrep.GetAccount(email);
        }

        public bool CheckLogin(string email, string password)
        {
            return accountrep.CheckLogin(email,password);
        }
    }
}
