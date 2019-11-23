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
    public partial class FormMain : Form
    {
        #region Constr. + Properties
        private Controller _controller;

        public FormMain()
        {
            InitializeComponent();
            
            // controller
            _controller = Controller.Init();
            _controller.MainForm = this;
        }

        public ToolStripMenuItem LogOut { get => mnuItemSnLogout; }
        #endregion

        // METHODS
        
        #region Buttons
        // 'Exit'
        private void mnuItemSnExit_Click(object sender, EventArgs e)
        {
            _Exit();
        }

        // 'Log Out'
        private void mnuItemSnLogout_Click(object sender, EventArgs e)
        {
            // Confirm user wants to exit
            var res = MessageBox.Show(this, "Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                _controller.LogOut();
            }
        }

        // 'View help'
        private void mnuItemHpViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users:\n\n'sales'\t -Sales Manager\n'stock'\t -Stock Manager\n'manage' -Store Manager\n\nPassword: 123456", "Help");
        }

        // 'About'
        private void mnuItemHpAbout_Click(object sender, EventArgs e)
        {
            string message = "This program was created as a part of my studies in the Technion for semestrial project in 2019 on C# class."
                + "The program simulates a Store Management System, that has multiple modules for managing the store(sales manager, stock"
                + " manager and a store manager), allowing to add new customers, make orders, add new products and a lot more. \n\nDima(2019)";

            MessageBox.Show(message, "About");
        }
        #endregion

        // Form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            _controller.StartSession();     // start controller
        }
        
        // Show message
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // Form closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel closing event

            _Exit();
        }

        // Exit
        private void _Exit()
        {
            // Confirm user wants to exit
            var res = MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                _controller.Exit();
            }
        }
    }
}
