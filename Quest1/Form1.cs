using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void LongName()
        {
            MessageBox.Show("Name Too Long");
        }
        public void NameValidation()
        {
            MessageBox.Show("Invalid first name");
        }

        private void NameBox_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.WrongNameSyntaxEvent += NameValidation;
            person.TooLOngNameEvent += LongName;
            person.Name = NameBox.Text;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
