using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest5
{
    public delegate void SendMessage(string message);
    public delegate void DepositMoney(User user, double desposit);
    public class UsersManagement
    {
        public List<User> UsersList { get; set; } = new List<User>();
        public event SendMessage SuccessLoginEvent;
        public event SendMessage UnsuccessLoginEvent;
        public event DepositMoney BalanceChangedEvent;
        public void Add(User obj)
        {
            UsersList.Add(obj);
        }
        public User Login(string userName, string password)
        {
            User user = UsersList.FirstOrDefault(usr => usr.Username == userName);
            if (user != null)
            {
                if (user.Password == password)
                {
                    OnLoginSuccess("Login Success");
                    user.IsLogin = true;
                    return user;
                }
                else
                {
                    OnLoginFailed("Password Not Exists");
                    return null;
                }
            }
            else
            {
                OnLoginFailed("User Name Not Exists");
                return null;
            }
           
        }

        public void Deposit(User user, double amount)
        {
            user.Account.Balance += amount;
            OnMoneyDepositedEvent(user,amount);
            user.OnBalanceChangedEvent(user.Account.Balance);
        }

        private void OnLoginFailed(string message)
        {
            UnsuccessLoginEvent?.Invoke(message);
        }

        private void OnLoginSuccess(string message)
        {
            SuccessLoginEvent?.Invoke(message);
        }

        private void OnMoneyDepositedEvent(User user, double desposit)
        {
            BalanceChangedEvent?.Invoke(user, desposit);
        }
    }
}
