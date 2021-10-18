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
        static User Active = new User();
        static UsersManagement ActiveManagement = new UsersManagement();
        private void WhenDeposit(User obj)
        {
            MessageBox.Show("UserName: " + obj.Username + " Balance: " + obj.Account.Balance);
        }
        public DepositControl(User activeuser, UsersManagement activemanagement)
        {
            InitializeComponent();
            Active = activeuser;
            ActiveManagement = activemanagement;
            ActiveManagement.BalanceChangedEvent += WhenDeposit;
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
