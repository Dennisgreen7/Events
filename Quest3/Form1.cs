using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest3
{
    public partial class Form1 : Form
    {
        static StudenManagment managment = new StudenManagment();
        public Form1()
        {
            InitializeComponent();
            managment.FithStudent += EvreyFithStuden;
        }

        private void NameBox_MouseClick(object sender, MouseEventArgs e)
        {
            NameBox.Text = "";
        }
        private void EvreyFithStuden()
        {
            MessageBox.Show("You got 5% discount");
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            Student student = new Student(NameBox.Text);
            
            managment.Add(student);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
