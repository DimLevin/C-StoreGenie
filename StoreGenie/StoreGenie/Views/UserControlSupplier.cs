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
    public partial class UserControlSupplier : UserControl
    {
        #region Constr. + Properties
        private bool _isSearchWindow;

        public UserControlSupplier()
        {
            InitializeComponent();
        }

        public Button BtnAction { get => btnSupplierAction; }
        public bool AllFieldsIsFilled { get => _CheckFields(); }
        public bool IsSearchWindow
        {
            set
            {
                // is search window
                if (value)
                {
                    _isSearchWindow = true;
                    tBoxSupplierId.TextChanged += _IdFieldCheck;     // add id field listener
                }
                else
                {
                    _isSearchWindow = false;
                    tBoxSupplierId.Enabled = false;  // disable id field
                }
            }
        }
        #endregion

        // METHODS

        #region Fields Checks
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

        // Checks a "non-id" fields, return true if all of them is filled, if else returns false
        private bool _CheckFields()
        {
            ControlCollection controls = gBoxSupplier.Controls;
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
        #endregion

        // Get data class
        public DataClass GetData()
        {
            DclassSupplier supplier = new DclassSupplier();

            // search window and id field not empty
            if (_isSearchWindow && !tBoxSupplierId.Text.Equals(string.Empty))
            {
                supplier.Id = int.Parse(tBoxSupplierId.Text);
            }
            else
            {
                supplier.CompanyName = tBoxSupplierCompName.Text;
                supplier.ContactName = tBoxSupplierContactName.Text;
                supplier.Phone = tBoxSupplierPhone.Text;
                supplier.Email = tBoxSupplierEmail.Text;
                supplier.Address = tBoxSupplierAddress.Text;
            }

            return supplier;
        }
        
        // Set fields state active/non active (except Id field)
        private void _SetFieldsState(bool state)
        {
            ControlCollection controls = gBoxSupplier.Controls;

            // all controls
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.Equals("non_id"))
                {
                    control.Enabled = state;
                }
            }
        }
    }
}
