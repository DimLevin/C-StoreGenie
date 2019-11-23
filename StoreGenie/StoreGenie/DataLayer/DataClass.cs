using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreGenie
{
    /*
     Data class

     Encapsulate data for further transfer or proccessing
    */
    public abstract class DataClass
    {
        // PRIVATE PROPERTIES
        private int _id;


        // CONSTR.
        public DataClass()
        {
            _id = -1;
        }

        // PUBLIC PROPERTIES
        public int Id { get => _id; set => _id = value; }
    }

    /* Various data classes */

    // User
    public class DclassUser : DataClass
    {
        // PRIVATE PROPERTIES
        private string _userName, _userPsw, _firstName, _lastName, _email, _phone, _userType;
        private DateTime _empDate;
        private bool _isActive;
        
        // PUBLIC PROPERTIES
        public DateTime EmployDate { get => _empDate; set => _empDate = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserPsw { get => _userPsw; set => _userPsw = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string UserType { get => _userType; set => _userType = value; }
        public bool Status { get => _isActive; set => _isActive = value; }
    }

    // Client
    public class DclassClient : DataClass
    {
        // PRIVATE PROPERTIES
        private string _firstName, _lastName, _email, _phone, _address;
        private DateTime _joinDate;


        // PUBLIC PROPERTIES
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public DateTime JoinDate { get => _joinDate; set => _joinDate = value; }
    }

    // Supplier
    public class DclassSupplier : DataClass
    {
        // PRIVATE PROPERTIES
        private string _compName, _contactName, _phone, _email,  _address;
        private DateTime _joinDate;
        private bool _status;


        // PUBLIC PROPERTIES
        public string CompanyName { get => _compName; set => _compName = value; }
        public string ContactName { get => _contactName; set => _contactName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public DateTime JoinDate { get => _joinDate; set => _joinDate = value; }
        public bool Status { get => _status; set => _status = value; }
    }

    // Product
    public class DclassProduct : DataClass
    {
        // PRIVATE PROPERTIES
        private DclassSupplier _supplier;
        private string _pName, _category, _catNumber, _description, _imagePath;
        private double _price;
        private int _quantity;
        private DateTime _addDate;
        private bool _status;


        // PUBLIC PROPERTIES
        public DclassSupplier Supplier { get => _supplier; set => _supplier = value; }
        public string ProductName { get => _pName; set => _pName = value; }
        public string Category { get => _category; set => _category = value; }
        public string CatNumber { get => _catNumber; set => _catNumber = value; }
        public string Description { get => _description; set => _description = value; }
        public string ImagePath { get => _imagePath; set => _imagePath = value; }
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public DateTime AddDate { get => _addDate; set => _addDate = value; }
        public bool Status { get => _status; set => _status = value; }
    }

    // Order
    public class DclassOrder : DataClass
    {
        #region Private Properties
        private DclassClient _client;
        private List<DclassProduct> _products;
        private List<int> _productsQty;
        private string _description;
        private double _total;
        private DateTime _orderDate;
        private bool _status;
        #endregion

        // CONSTR.
        public DclassOrder()
        {
            _products = new List<DclassProduct>();  // init. prod. list
            _productsQty = new List<int>();
        }

        #region Public Properties
        public DclassClient Client { get => _client; set => _client = value; }
        public List<DclassProduct> Products { get => _products; }
        public List<int> Quantity { get => _productsQty; }
        public string Description { get => _description; set => _description = value; }
        public double Total { get => _total; set => _total = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public bool Status { get => _status; set => _status = value; }
        #endregion

        #region Methods
        // Add product to order
        public void AddProduct(DclassProduct product, int quantity)
        {
            if (product != null)
            {
                int foundInd = FindProductById(product.Id);

                // same product found
                if (foundInd >= 0)
                {
                    _productsQty[foundInd] += quantity;       // update quantity
                }
                else
                {
                    _products.Add(product);         // add the product to the list
                    _productsQty.Add(quantity);     // add quantity
                }

                _UpdateTotal();         // update total
                _UpdateDescription();   // update description
            }
        }

        // Update description
        private void _UpdateDescription()
        {
            _description = "Items: " + _products.Count
                + "Total: " + _total;
        }

        // Find product in order
        public int FindProductById(int productId)
        {
            bool isFound = false;
            int i;

            // find product
            for (i = 0; i < _products.Count && !isFound; i++)
            {
                isFound = _products[i].Id == productId;   // compare id's
            }

            return (isFound) ? i - 1 : -1;
        }

        // Upade total
        private void _UpdateTotal()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                _total += ProductTotalCostByIndex(i);    // total per product
            }
        }

        // Product total cost by index
        public double ProductTotalCostByIndex(int itemInd)
        {
            return _products[itemInd].Price * _productsQty[itemInd];
        }
        #endregion
    }

    // Report -orders
    public class DclassReport : DataClass
    {
        // PRIVATE PROPERTIES
        private string _name;
        private string _type;
        private List<int> _xVal;
        private List<int> _yVal;


        // CONSTR.
        public DclassReport()
        {
            // init. lists
            _xVal = new List<int>();
            _yVal = new List<int>();
        }


        // PUBLIC PROPERTIES
        public string ReportName { get => _name; set => _name = value; }
        public string ReportType { get => _type; set => _type = value; }
        public List<int> XVal { get => _xVal; }
        public List<int> YVal { get => _yVal; }
   }
}
