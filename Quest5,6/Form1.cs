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
    public partial class Form1 : Form
    {
        static UsersManagement management = new UsersManagement();
        static User user = new User();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void LoginMessege(string messege)
        {
            MessageBox.Show(messege);

            if(messege == "Login Success")
            {
                user.Username = UsernameBox.Text;
                user.Password = PasswordBox.Text;
                this.Controls.Clear();
                DepositControl uc = new DepositControl(user, management);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
               
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            management.Add(new User("Dennis", "1234"));
            management.Add(new User("Dan", "12"));
            management.SuccessLoginEvent += LoginMessege;
            management.UnsuccessLoginEvent += LoginMessege;
        }
        private void bLogin_Click(object sender, EventArgs e)
        {
           management.Login(UsernameBox.Text, PasswordBox.Text);
        }
    }
}
