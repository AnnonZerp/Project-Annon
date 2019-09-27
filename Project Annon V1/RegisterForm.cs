using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NETLock;
using System.Diagnostics;

namespace Project_Annon_V1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            RegisterResponse register = new RegisterResponse();
            if (register.PaidRegister(flatTextBox1.Text, flatTextBox2.Text, flatTextBox3.Text))
            {
                MessageBox.Show("Registration was successful!");
                Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show(register.info, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


           protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }
    }
}