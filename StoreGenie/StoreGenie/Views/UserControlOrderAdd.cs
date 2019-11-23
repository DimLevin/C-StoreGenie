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
    public partial class UserControlOrderAdd : UserControl
    {
        #region Contr. + Properties
        // Private Properties
        private Session _session;
        private DclassOrder _order;
        private DclassClient[] _foundClients;
        private DclassProduct[] _foundProducts;
        private int _currInd;

        // Constr.
        public UserControlOrderAdd()
        {
            InitializeComponent();
        }

        // Public Properties
        public Button BtnAction { get => btnOrderAddAction; }
        public bool AllFieldsIsFilled { get => _CheckFields(); }
        #endregion

        // METHODS
        
        #region Buttons
        // Client select -left button
        private void btnOrderAddSelectClientLeft_Click(object sender, EventArgs e)
        {
            _currInd--;
            _SetClientData();
        }

        // Client select -right button
        private void btnOrderAddSelectClientRight_Click(object sender, EventArgs e)
        {
            _currInd++;
            _SetClientData();
        }
        
        // Client select -select button
        private void btnOrderAddSelectClient_Click(object sender, EventArgs e)
        {
            if (_foundClients != null)
            {
                // save curr. client
                _order.Client = _foundClients[_currInd];

                // lock controls select client controls
                userControlClient.Enabled = false;
                pnlOrderAddClientSelect.Enabled = false;

                // unlock product and order controls
                userControlProduct.Enabled = true;
                gBoxOrderAddProductAdd.Enabled = true;
                gBoxOrderAddOrder.Enabled = true;
            }
        }
        
        // Find client button clicked
        private void _FindClientBtnClicked(object sender, EventArgs e)
        {
            _foundClients = _session.Controller.DataRequest("Clients", userControlClient.GetData()) as DclassClient[];
            _currInd = 0;       // reset index
            _SetClientData();   // set data to fields
        }
        
        // Find product button clicked
        private void _FindProductBtnClicked(object sender, EventArgs e)
        {
            _foundProducts = _session.Controller.DataRequest("Products", userControlProduct.GetData()) as DclassProduct[];
            _currInd = 0;       // reset index
            _SetProductData();  // set data to fields
            _ResetAddQuantityField(sender, e);
        }

        // Product select -left button
        private void btnOrderAddProductLeft_Click(object sender, EventArgs e)
        {
            _currInd--;
            _SetProductData();
        }

        // Product select -right button
        private void btnOrderAddProductRight_Click(object sender, EventArgs e)
        {
            _currInd++;
            _SetProductData();
        }

        // Product select -add button
        private void btnOrderAddProduct_Click(object sender, EventArgs e)
        {
            if (_foundProducts != null && int.Parse(userControlProduct.Qty.Text) > 0)
            {
                // add curr. product to order list
                _order.AddProduct(_foundProducts[_currInd], cmbOrderAddProdQty.SelectedIndex + 1);
                _UpdateProductQtyField();
                _UpdateOrderField();
            }
        }
        #endregion

        // Form is loaded
        private void UserControlOrderAdd_Load(object sender, EventArgs e)
        {
            // create order
            _order = new DclassOrder();

            // get session
            _session = Session.Init();

            // set windows types
            userControlClient.IsSearchWindow = true;
            userControlProduct.IsSearchWindow = true;

            // set button text
            userControlClient.BtnAction.Text = "Find Client";
            userControlProduct.BtnAction.Text = "Find Product";

            // add listeners
            userControlClient.BtnAction.Click += _FindClientBtnClicked;
            userControlProduct.BtnAction.Click += _FindProductBtnClicked;
            cmbOrderAddProdQty.SelectedIndexChanged += _CheckAddQuantityField;
            btnOrderAddProductRight.Click += _ResetAddQuantityField;
            btnOrderAddProductLeft.Click += _ResetAddQuantityField;

            // set order summary view
            _SetOrderSummaryField();
        }

        // Set listview design
        private void _SetOrderSummaryField()
        {
            // set to details view.
            lstvOrderSummary.View = View.Details;
            // add columns
            lstvOrderSummary.Columns.Add("  ");
            lstvOrderSummary.Columns.Add("Catalog Number");
            lstvOrderSummary.Columns.Add("Product Name");
            lstvOrderSummary.Columns.Add("Category");
            lstvOrderSummary.Columns.Add("Supplier");
            lstvOrderSummary.Columns.Add("Qty");
            lstvOrderSummary.Columns.Add("Total");

            lstvOrderSummary.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // Fill listview
        private void _FillListView()
        {
            // clear items
            lstvOrderSummary.Items.Clear();

            // add items
            for (int i = 0; i < _order.Products.Count; i++)
            {
                string[] row = { (i + 1) + ". ", _order.Products[i].CatNumber, _order.Products[i].ProductName, _order.Products[i].Category,
                    _order.Products[i].Supplier.CompanyName, _order.Quantity[i].ToString(), _order.ProductTotalCostByIndex(i).ToString()};

                // add row
                ListViewItem listViewItem = new ListViewItem(row);
                lstvOrderSummary.Items.Add(listViewItem);
            }
        }

        // Update order field
        private void _UpdateOrderField()
        {
            // update fields
            tBoxOrderAddItems.Text = _order.Products.Count.ToString();  // items count
            tBoxOrderAddTotal.Text = _order.Total.ToString();           // total
            _FillListView(); // fill listview
        }

        // Set the client data to view
        private void _SetClientData()
        {
            // data found
            if (_foundClients != null)
            {
                // check index
                _currInd = (_currInd >= _foundClients.Length) ? _foundClients.Length - 1 : _currInd;
                _currInd = (_currInd < 0) ? 0 : _currInd;

                // fill data fields
                userControlClient.ClientId.Text = _foundClients[_currInd].Id.ToString();
                userControlClient.FirstName.Text = _foundClients[_currInd].FirstName;
                userControlClient.LastName.Text = _foundClients[_currInd].LastName;
                userControlClient.Phone.Text = _foundClients[_currInd].Phone;
                userControlClient.Email.Text = _foundClients[_currInd].Email;
                userControlClient.Address.Text = _foundClients[_currInd].Address;
            }
        }

        // Check add quantity field
        void _CheckAddQuantityField(object sender, EventArgs e)
        {
            // product exists
            if (_foundProducts != null)
            {
                // exceeds max product quantity
                if (cmbOrderAddProdQty.SelectedIndex > _foundProducts[_currInd].Quantity)
                {
                    cmbOrderAddProdQty.SelectedIndex = _foundProducts[_currInd].Quantity - 1;
                }
            }
            else
            {
                cmbOrderAddProdQty.SelectedIndex = -1;
            }
        }

        // Reset add quantity field
        void _ResetAddQuantityField(object sender, EventArgs e)
        {
            cmbOrderAddProdQty.SelectedIndex = (_foundProducts != null) ? 0 : -1;
        }

        // Set the product data to view
        private void _SetProductData()
        {
            // data found
            if (_foundProducts != null)
            {
                // check index
                _currInd = (_currInd >= _foundProducts.Length) ? _foundProducts.Length - 1 : _currInd;
                _currInd = (_currInd < 0) ? 0 : _currInd;

                // fill data fields
                userControlProduct.ProdId.Text = _foundProducts[_currInd].Id.ToString();
                userControlProduct.ProdName.Text = _foundProducts[_currInd].ProductName;
                userControlProduct.ProdCategory.Text = _foundProducts[_currInd].Category;
                userControlProduct.CtlNumber.Text = _foundProducts[_currInd].CatNumber;
                userControlProduct.Description.Text = _foundProducts[_currInd].Description;
                userControlProduct.Price.Text = _foundProducts[_currInd].Price.ToString();
                userControlProduct.Supplier.Text = _foundProducts[_currInd].Supplier.CompanyName;
                _UpdateProductQtyField();   // quantity
            }
        }

        // Update product quantity field
        private void _UpdateProductQtyField()
        {
            int qnt = _foundProducts[_currInd].Quantity;    // in prod. qty.

            // find prod. in added to the order
            int foundInd = _order.FindProductById(_foundProducts[_currInd].Id);

            // product found
            if (foundInd >= 0)
            {
                qnt -= _order.Quantity[foundInd];
            }

            userControlProduct.Qty.Text = qnt.ToString();
        }

        // Checks if order can be submitted
        private bool _CheckFields()
        {
            return _order.Products.Count > 0;
        }

        // Get data from form as data class
        public DataClass GetData()
        {
            return _order;
        }
    }
}
