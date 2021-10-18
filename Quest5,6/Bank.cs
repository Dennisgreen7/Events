using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest5
{
    public delegate void BankBalance(double Balance);
    class Bank
    {
        public event BankBalance BankBalanceEvent;
        private void OnBankBalanceEvent(UsersManagement BankObj)
        {
            double Balance = 0;
            for (int i = 0; i < BankObj.UsersList.Count; i++)
            {
                Balance += BankObj.UsersList[i].Account.Balance;
            }
            BankBalanceEvent?.Invoke(Balance);
        }
    }
}
