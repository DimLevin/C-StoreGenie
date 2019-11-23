using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    public partial class FormLogin : Form
    {
        private Controller _controller;

        public FormLogin()
        {
            InitializeComponent();

            _controller = Controller.Init();                    // controller
            ctrlLogin.LoginEventHandler += _controller.Login;   // login event
        }
    }
}
