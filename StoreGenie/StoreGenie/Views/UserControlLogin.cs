using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    public delegate void LoginEvent(string st1, string st2);

    public partial class UserControlLogin : UserControl
    {
        public event LoginEvent LoginEventHandler;

        public UserControlLogin()
        {
            InitializeComponent();
        }
        
        // User control loads
        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tBoxLoginUsername;   // set focus to username
        }

        // 'Login' button clicked
        private void btnLgnLogin_Click(object sender, EventArgs e)
        {
            LoginEventHandler(tBoxLoginUsername.Text, tBoxLoginPassword.Text);
        }

        // 'Username' tbox text changed
        private void tBoxLgnUsername_TextChanged(object sender, EventArgs e)
        {
            // username and password fields not empty
            if (tBoxLoginUsername.Text.Length > 0 && tBoxLoginPassword.Text.Length > 0)
            {
                btnLoginLogin.Enabled = true;
            }
            else
            {
                btnLoginLogin.Enabled = false;
            }
        }
        
        // 'Password' tbox text changed
        private void tBoxLgnPassword_TextChanged(object sender, EventArgs e)
        {
            // username and password fields not empty
            if (tBoxLoginUsername.Text.Length > 0 && tBoxLoginPassword.Text.Length > 0)
            {
                btnLoginLogin.Enabled = true;
            }
            else
            {
                btnLoginLogin.Enabled = false;
            }
        }
    }
}
