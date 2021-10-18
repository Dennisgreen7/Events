using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest5
{
    public partial class DepositControl : UserControl
    {
        static User Active;
        static UsersManagement ActiveManagement;
        Bank bank = new Bank();
        private void WhenDeposit(User obj,double desposit)
        {
            MessageBox.Show("UserName: " + obj.Username + " Desposit: " + desposit);
        }
        private void ShowBalance(double Balance)
        {
            MessageBox.Show("Balance: " + Balance);
        }
        private void BankBalance(double Balance)
        {
            MessageBox.Show(" Bank Balance: " + Balance);
        }
        public DepositControl(User activeuser, UsersManagement activemanagement)
        {
            InitializeComponent();
            Active = activeuser;
            ActiveManagement = activemanagement;
            ActiveManagement.BalanceChangedEvent += WhenDeposit;
            Active.BalanceChangedEvent += ShowBalance;
            bank.BankBalanceEvent+=BankBalance;
        }

        private void bDeposit_Click(object sender, EventArgs e)
        {
            ActiveManagement.Deposit(Active, Convert.ToDouble(DepositBox.Text));
        }

        private void DepositControl_Load(object sender, EventArgs e)
        {
        }
    }
}
