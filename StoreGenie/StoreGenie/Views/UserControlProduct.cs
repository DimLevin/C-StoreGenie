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
    public partial class UserControlProduct : UserControl
    {
        // PRIVATE PROPERTIES
        private bool _isSearchWindow;
        private DclassSupplier[] _suppliers;

        public UserControlProduct()
        {
            InitializeComponent();
        }

        #region Public Properties
        public TextBox ProdId { get => tBoxProductId; }
        public TextBox ProdName { get => tBoxProductName; }
        public TextBox ProdCategory { get => tBoxProductCategory; }
        public TextBox CtlNumber { get => tBoxProductCatNum; }
        public TextBox Description { get => tBoxProductDescription; }
        public TextBox Price { get => tBoxProductPrice; }
        public TextBox Qty { get => tBoxProductQuantity; }
        public ComboBox Supplier { get => cmbProductSuppliers; }
        public Button BtnAction { get => btnProductAction; }
        public bool AllFieldsIsFilled { get => _CheckFields(); }
        public bool IsSearchWindow
        {
            set
            {
                // is search window
                if (value)
                {
                    _isSearchWindow = true;
                    tBoxProductId.TextChanged += _IdFieldCheck;     // add id field listener

                    // disable numerical fields
                    tBoxProductPrice.Enabled = false;
                    tBoxProductQuantity.Enabled = false;
                }
                else
                {
                    _isSearchWindow = false;
                    tBoxProductId.Enabled = false;  // disable id field
                }
            }
        }
        #endregion

        // METHODS
        
        #region Fields Checks
        // Numeric field check
        private void _NumericFieldCheck(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;

            double val;
            bool valIsDouble = double.TryParse(tBox.Text, out val);

            // false value
            if (!valIsDouble || valIsDouble && val < 0)
            {
                tBox.Text = string.Empty;   // empty string
            }
        }
        
        // Id field check
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
            ControlCollection controls = gBoxProduct.Controls;
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

        // Form loads
        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            // add listeners
            tBoxProductPrice.TextChanged += _NumericFieldCheck;
            tBoxProductQuantity.TextChanged += _NumericFieldCheck;

            // add items to the suppliers list
            _AddSuppliers();
        }

        // Add suppliers to the supplier combo box
        private void _AddSuppliers()
        {
            // request suppliers list form the controller
            Controller ctrl = Controller.Init();

            // curr. session exists
            if (ctrl.CurrSession != null)
            {
                _suppliers = (ctrl.CurrSession.Controller.DataRequest("Suppliers") as DclassSupplier[]);

                // add supplier names to the supplier tab
                foreach (DclassSupplier supplier in _suppliers)
                {
                    cmbProductSuppliers.Items.Add(supplier.CompanyName);
                }
            }
        }

        // Get data class
        public DataClass GetData()
        {
            DclassProduct product = new DclassProduct();

            // search window and id field not empty
            if (_isSearchWindow && !tBoxProductId.Text.Equals(string.Empty))
            {
                product.Id = int.Parse(tBoxProductId.Text);
            }
            else
            {
                // supplier combo box index
                if (cmbProductSuppliers.SelectedIndex >= 0)
                {
                    product.Supplier = _suppliers[cmbProductSuppliers.SelectedIndex];   // supplier data
                }

                product.ProductName = tBoxProductName.Text;
                product.Category = tBoxProductCategory.Text;
                product.CatNumber = tBoxProductCatNum.Text;
                //product.ImagePath = tBoxProductImagePath.Text;
                product.Description = tBoxProductDescription.Text;

                // is search window
                if (!_isSearchWindow)
                {
                    // numeric fields
                    product.Quantity = int.Parse(tBoxProductQuantity.Text);
                    product.Price = double.Parse(tBoxProductPrice.Text);
                }
            }

            return product;
        }
        
        // Set fields state active/non active (except Id field)
        private void _SetFieldsState(bool state)
        {
            ControlCollection controls = gBoxProduct.Controls;

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
