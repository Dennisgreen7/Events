using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest5
{
    public class Account
    {
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(double balance)
        {
            Balance = balance;
        }
    }
}
