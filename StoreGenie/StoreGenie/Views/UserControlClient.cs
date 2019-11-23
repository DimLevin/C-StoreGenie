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
    public partial class UserControlClient : UserControl
    {
        private bool _isSearchWindow;

        public UserControlClient()
        {
            InitializeComponent();
        }
        
        #region Public Properties
        public TextBox ClientId { get => tBoxClientId; }
        public TextBox FirstName { get => tBoxClientFname; }
        public TextBox LastName { get => tBoxClientLname; }
        public TextBox Phone { get => tBoxClientPhone; }
        public TextBox Email { get => tBoxClientEmail; }
        public TextBox Address { get => tBoxClientAddress; }
        public Button BtnAction { get => btnClientAction; }
        public bool AllFieldsIsFilled { get => _CheckFields(); }
        public bool IsSearchWindow
        {
            set
            {
                // is search window
                if (value)
                {
                    _isSearchWindow = true;
                    tBoxClientId.TextChanged += _IdFieldCheck;  // add id field listener
                }
                else
                {
                    _isSearchWindow = false;
                    tBoxClientId.Enabled = false;       // disable id field
                }
            }
        }
        #endregion

        // METHODS

        // Get data class
        public DataClass GetData()
        {
            DclassClient client = new DclassClient();

            // search window and id field not empty
            if (_isSearchWindow && !tBoxClientId.Text.Equals(string.Empty))
            {
                client.Id = int.Parse(tBoxClientId.Text);
            }
            else
            {
                client.FirstName = tBoxClientFname.Text;
                client.LastName = tBoxClientLname.Text;
                client.Phone = tBoxClientPhone.Text;
                client.Email = tBoxClientEmail.Text;
                client.Address = tBoxClientAddress.Text;
            }
            
            return client;
        }

        // Number field check
        private void _IdFieldCheck(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;

            int val;
            bool valIsInt = int.TryParse(tBox.Text, out val);

            // false value
            if (!valIsInt || valIsInt && val <= 0)
            {
                tBox.Text = string.Empty;   // empty string
            }

            // the filed is not empty
            if (tBox.Text.Length > 0)
            {
                // lock other fields
                _SetFieldsState(false);
            }
            else
            {
                // release other fields
                _SetFieldsState(true);
            }
        }

        // Set fields state active/non active (except Id field)
        private void _SetFieldsState(bool state)
        {
            ControlCollection controls = gBoxClient.Controls;

            // all controls
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.Equals("non_id"))
                {
                    control.Enabled = state;
                }
            }
        }

        // Checks a "non-id" fields, return true if all of them is filled, if else returns false
        private bool _CheckFields()
        {
            ControlCollection controls = gBoxClient.Controls;
            bool res = true;

            // all controls
            foreach (Control control in controls)
            {
                // control has a tag "non_id" and empty text
                if (control.Tag != null && control.Tag.Equals("non_id") && control.Text.Equals(string.Empty))
                {
                    res = false;
                }
            }

            return res;
        }
    }
}
