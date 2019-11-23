using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    /*
     Controller class

     Manages View and Model modules
    */
    public class Controller
    {
        #region Constr. + Properties
        private FormMain _mainForm;
        private Form _secondForm;
        private Session _currSession;
        private ModelGeneral _dataB;

        // for singleton
        private static Controller _instance = null;

        // CONSTR.
        private Controller()
        {
            _dataB = ModelGeneral.Init();    // database handler
        }

        // Singleton initiator
        public static Controller Init()
        {
            if (Controller._instance == null)
            {
                Controller._instance = new Controller();
            }

            return Controller._instance;
        }
        
        public FormMain MainForm { private get => _mainForm; set => _mainForm = value; }
        public Session CurrSession { get => _currSession; } //set => _currSession = value;
        #endregion

        // METHODS
        #region User Module + Login Check
        // Open user module
        private bool _LoadUserModule()
        {
            FormView tForm = new FormView();

            // load corresponding form
            if (_currSession.CurrentUser.UserType.Equals("manag"))
            {
                _currSession.Controller = ControllerManage.Init();
                _currSession.Controller.Mdel = ModelManage.Init();
                tForm.Text = "Manage";
            }
            else if (_currSession.CurrentUser.UserType.Equals("sales"))
            {
                _currSession.Controller = ControllerSales.Init();
                _currSession.Controller.Mdel = ModelSales.Init();
                tForm.Text = "Sales";
            }
            else if (_currSession.CurrentUser.UserType.Equals("stock"))
            {
                _currSession.Controller = ControllerStock.Init();
                _currSession.Controller.Mdel = ModelStock.Init();
                tForm.Text = "Stock";
            }
            else
            {
                // close t. form
                tForm.Dispose();
                tForm = null;
            }

            // form loaded
            if (tForm != null)
            {
                tForm.RemoveIrrTabs(_currSession.Controller.Mdel.AllowedTabs);     // remove irrelevant tabs
                _currSession.Controller.View = tForm;  // set view instance
                _StartSecondForm(tForm);            // start form
            }

            return tForm != null;
        }

        // Login check
        public void Login(string userName, string userPsw)
        {
            int userId;
            bool loginOk;

            // find user
            userId = _dataB.FindUser(userName);

            // check password
            loginOk = _dataB.CheckPassword(userId, userPsw);

            // login Ok
            if (loginOk)
            {
                _currSession.CurrentUser = _dataB.LoadUser(userId);    // load user

                // user and user module loaded
                if (_currSession != null && _LoadUserModule())
                {
                    // activate logout button
                    _mainForm.LogOut.Enabled = true;
                }
                else
                {
                    _mainForm.ShowMessage("Unable to load user/module.");
                }
            }
            else
            {
                _mainForm.ShowMessage("Wrong Username or Password!");
            }
        }
        #endregion

        // Start session
        public void StartSession()
        {
            _currSession = Session.Init();
            _StartSecondForm(new FormLogin());  // show login form
        }

        // Start new form
        private void _StartSecondForm(Form form)
        {
            _secondForm?.Dispose();     // dispose curr. form

            form.MdiParent = _mainForm;                     // set parent

            form.Show();                                    // show form
            form.WindowState = FormWindowState.Maximized;   // maximize form

            _secondForm = form;
        }
        
        // Exit
        public void Exit()
        {
            _mainForm.Dispose();  // dispose main form
        }

        // Logout
        public void LogOut()
        {
            _mainForm.LogOut.Enabled = false;   // disable logout button
            _currSession.Reset();               // reset curr. session
            _secondForm?.Dispose();             // dispose curr. form
            StartSession();                     // restart session
        }
    }
}
