using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace StoreGenie
{
    public abstract class ModelUser : Model
    {
        // PRIVATE PROPERTIES
        private string[] _allowedTabs;
        
        // PUBLIC PROPERTIES
        public string[] AllowedTabs { get => _allowedTabs; protected set => _allowedTabs = value; }
        
        // METHODS

        public abstract string[] GetAllowedButtons(string tab);     // return allowed buttons array

        #region Table data queries
        // Get spec. tab data from db
        public DataHolder GetTabData(string tab)
        {
            DataHolder dh = null;
            string command = string.Empty;

            switch (tab)
            {
                case "Clients":
                    command = "SELECT client_id AS 'ID', first_name AS 'First Name', last_name AS 'Last Name', phone AS 'Phone', "
                        + "email AS 'Email', address AS 'Address', joined AS 'Client since' "
                        + "FROM Clients";
                    break;

                case "Orders":
                    command = "SELECT order_id AS 'ID', client_id AS 'Client Id', order_date AS 'Date', order_desc AS 'Description', order_total AS 'Total', status AS 'Status' "
                        + "FROM Orders";
                    break;

                case "Products":
                    command = "SELECT prod_id AS 'ID', catalog_number AS 'MKT', prod_name AS 'Name', category AS 'Category', "
                        + "comp_name AS 'Supplier', price AS 'Price', quantity AS 'QTY', add_date AS 'Added', description AS 'Description', "
                        + "pr.status AS 'Status' "
                        + "FROM Products pr INNER JOIN Suppliers sp ON pr.supp_id=sp.supp_id";
                    break;

                case "Suppliers":
                    command = "SELECT supp_id AS 'ID', comp_name AS 'Company Name', contact_name AS 'Contact Name', phone AS 'Phone', "
                        + "email AS 'Email', address AS 'Address', joined AS 'Joined', status AS 'Status' "
                        + "FROM Suppliers";
                    break;

                case "Users":
                    command = "SELECT user_id AS 'ID', user_name AS 'Username', first_name AS 'First Name', last_name AS 'Last Name', "
                        + "email AS 'Email', phone_number AS 'Phone', user_type AS 'Department', employment_date AS 'Start date', "
                        + "status AS 'Status' "
                        + "FROM Users";
                    break;

                case "Prices Policy":
                    command = "SELECT * FROM PricesPolicy";
                    break;
            }

            // command not empty
            if (!command.Equals(string.Empty))
            {
                dh = new DataHolderGeneral(GetTableDT(command));
            }

            return dh;
        }
        #endregion

        #region Data filtering
        // Filter data
        public void FilterData(string tab, DataHolder dh)
        {
            switch (tab)
            {
                case "Clients":
                    _FilterClients(dh);
                    break;
                case "Orders":
                    _FilterOrders(dh);
                    break;
                case "Products":
                    _FilterProducts(dh);
                    break;
                case "Users":
                    _FilterUsers(dh);
                    break;
                case "Suppliers":
                    _FilterSuppliers(dh);
                    break;
            }
        }
        // Filter clients data table
        private void _FilterClients(DataHolder dh)
        {
            // data exists
            if (dh?.DataCls != null && dh.DataTbl != null)
            {
                DclassClient client = dh.DataCls as DclassClient;

                // id is set
                if (client.Id >= 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['ID'] = " + client.Id;
                }
                else
                {
                    dh.DataTbl.DefaultView.RowFilter = "['First Name'] LIKE '%" + client.FirstName + "%' AND ['Last Name'] LIKE '%"
                        + client.LastName + "%' AND ['Phone'] LIKE '%" + client.Phone + "%' AND ['Email'] LIKE '%" + client.Email
                        + "%' AND ['Address'] LIKE '%" + client.Address + "%'";
                }
            }
        }
        // Filter orders data table
        private void _FilterOrders(DataHolder dh)
        {
            // data exists
            if (dh?.DataCls != null && dh.DataTbl != null)
            {
                DclassOrder order = dh.DataCls as DclassOrder;

                // id is set
                if (order.Id >= 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['ID'] = " + order.Id;
                }
                else if (order.Client.Id > 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['Client Id'] = " + order.Client.Id;
                }
                else if (order.Total > 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['Total'] = " + order.Total;
                }
                else
                {
                    dh.DataTbl.DefaultView.RowFilter = "['Description'] LIKE '%" + order.Description + "%'";
                }
            }
        }
        // Filter products data table
        private void _FilterProducts(DataHolder dh)
        {
            // data exists
            if (dh?.DataCls != null && dh.DataTbl != null)
            {
                DclassProduct product = dh.DataCls as DclassProduct;

                // id is set
                if (product.Id >= 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['ID'] = " + product.Id;
                }
                else
                {
                    dh.DataTbl.DefaultView.RowFilter = "['MKT'] LIKE '%" + product.CatNumber + "%' AND ['Name'] LIKE '%"
                        + product.ProductName + "%' AND ['Category'] LIKE '%" + product.Category + "%' AND ['Description'] LIKE '%"
                        + product.Description + "%' AND ['Supplier'] LIKE '%" + (product.Supplier?.CompanyName ?? "") + "%'";
                }
            }
        }
        // Filter users data table
        private void _FilterUsers(DataHolder dh)
        {

        }
        // Filter suppliers data table
        private void _FilterSuppliers(DataHolder dh)
        {
            // data exists
            if (dh?.DataCls != null && dh.DataTbl != null)
            {
                DclassSupplier supplier = dh.DataCls as DclassSupplier;

                // id is set
                if (supplier.Id >= 0)
                {
                    dh.DataTbl.DefaultView.RowFilter = "['ID'] = " + supplier.Id;
                }
                else
                {
                    dh.DataTbl.DefaultView.RowFilter = "['Company Name'] LIKE '%" + supplier.CompanyName + "%' AND ['Contact Name'] LIKE '%"
                        + supplier.ContactName + "%' AND ['Phone'] LIKE '%" + supplier.Phone + "%' AND ['Email'] LIKE '%" + supplier.Email
                        + "%' AND ['Address'] LIKE '%" + supplier.Address + "%'";
                }
            }
        }
        #endregion

        #region Data adding
        // Add data to the database
        public void AddData(string tab, DataHolder dh)
        {
            switch (tab)
            {
                case "Clients":
                    _AddClient(dh.DataCls as DclassClient);
                    break;
                case "Orders":
                    _AddOrder(dh.DataCls as DclassOrder);
                    _ProductsUpd(dh.DataCls as DclassOrder);
                    break;
                case "Products":
                    _AddProduct(dh.DataCls as DclassProduct);
                    break;
                case "Users":
                    _AddUser(dh);
                    break;
                case "Suppliers":
                    _AddSupplier(dh.DataCls as DclassSupplier);
                    break;
            }
        }
        // Add client to the database
        private void _AddClient(DclassClient client)
        {
            // data exists
            if (client != null)
            {
                
                OleDbCommand cmd = new OleDbCommand();

                // parameters
                cmd.Parameters.AddWithValue("@var1", client.FirstName);
                cmd.Parameters.AddWithValue("@var2", client.LastName);
                cmd.Parameters.AddWithValue("@var3", client.Phone);
                cmd.Parameters.AddWithValue("@var4", client.Email);
                cmd.Parameters.AddWithValue("@var5", client.Address);
                cmd.Parameters.AddWithValue("@var6", DateTime.Now.Date.ToString());

                // command
                cmd.CommandText = "INSERT INTO Clients (first_name, last_name, phone, email, address, joined) VALUES" +
                    "(@var1, @var2, @var3, @var4, @var5, @var6)";
                
                ExecuteSimpleQuery(cmd);
            }
        }
        // Add order to the database
        private void _AddOrder(DclassOrder order)
        {
            // data exists
            if (order != null)
            {
                OleDbCommand cmd = new OleDbCommand();

                // parameters
                cmd.Parameters.AddWithValue("@var1", order.Client.Id);
                cmd.Parameters.AddWithValue("@var2", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@var3", order.Total);
                cmd.Parameters.AddWithValue("@var4", order.Description ?? "");
                cmd.Parameters.AddWithValue("@var5", true);

                // command
                cmd.CommandText = "INSERT INTO Orders (client_id, order_date, order_total, order_desc, status) VALUES" +
                    "(@var1, @var2, @var3, @var4, @var5)";
                    
                ExecuteSimpleQuery(cmd);
            }
        }
        // Add product to the database
        private void _AddProduct(DclassProduct product)
        {
            // data exists
            if (product != null)
            {

                OleDbCommand cmd = new OleDbCommand();

                // parameters
                cmd.Parameters.AddWithValue("@var1", product.Supplier.Id);
                cmd.Parameters.AddWithValue("@var2", product.ProductName);
                cmd.Parameters.AddWithValue("@var3", product.Category);
                cmd.Parameters.AddWithValue("@var4", product.CatNumber);
                cmd.Parameters.AddWithValue("@var5", product.Price);
                cmd.Parameters.AddWithValue("@var6", product.Quantity);
                cmd.Parameters.AddWithValue("@var7", product.Description);
                cmd.Parameters.AddWithValue("@var8", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@var9", true);
                //cmd.Parameters.AddWithValue("@var7", product.ImagePath);

                // command
                cmd.CommandText = "INSERT INTO Products (supp_id, prod_name, category, catalog_number, price, quantity, description, add_date, status) VALUES" +
                    "(@var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8, @var9)";

                ExecuteSimpleQuery(cmd);
            }
        }
        // Add user to the database
        private void _AddUser(DataHolder dh)
        {
            
        }
        // Add supplier to the database
        private void _AddSupplier(DclassSupplier supplier)
        {
            // data exists
            if (supplier != null)
            {

                OleDbCommand cmd = new OleDbCommand();

                // parameters
                cmd.Parameters.AddWithValue("@var1", supplier.CompanyName);
                cmd.Parameters.AddWithValue("@var2", supplier.ContactName);
                cmd.Parameters.AddWithValue("@var3", supplier.Phone);
                cmd.Parameters.AddWithValue("@var4", supplier.Email);
                cmd.Parameters.AddWithValue("@var5", supplier.Address);
                cmd.Parameters.AddWithValue("@var6", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@var7", true);

                // command
                cmd.CommandText = "INSERT INTO Suppliers (comp_name, contact_name, phone, email, address, joined, status) VALUES" +
                    "(@var1, @var2, @var3, @var4, @var5, @var6, @var7)";

                ExecuteSimpleQuery(cmd);
            }
        }
        #endregion

        #region Data update/delete
        // Update table in the database
        public void UpdateDb(string tab, DataHolder dh)
        {
            switch (tab)
            {
                case "Clients":
                    _ClientsUpd(dh);
                    _DeleteRows("Clients", "client_id", dh.SelectedIds.ToArray());
                    break;
                case "Orders":
                    break;
                case "Products":
                    _ProductsUpd(dh);
                    _DeleteRows("Products", "prod_id", dh.SelectedIds.ToArray());
                    break;
                case "Users":
                    _UsersUpd(dh);
                    break;
                case "Suppliers":
                    _SuppliersUpd(dh);
                    _DeleteRows("Suppliers", "supp_id", dh.SelectedIds.ToArray());
                    break;
                case "Prices Policy":
                    _PricesPolicyUpd(dh);
                    break;
            }
        }

        // Delete rows by id
        private void _DeleteRows(string table, string field, int[] ids)
        {
            foreach (int id in ids)
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "DELETE FROM " + table + " WHERE " + field + "=" + id;    // command
                ExecuteSimpleQuery(cmd);
            }
        }

        // Products table update -dh
        private void _ProductsUpd(DataHolder dh)
        {
            DclassProduct[] products = null;

            if (dh != null)
            {
                products = _DataRowClToProducts(dh.DataTbl?.GetChanges(DataRowState.Modified)?.Rows); // get changed users
            }

            // data exists
            if (products != null)
            {
                foreach (DclassProduct product in products)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    // parameters
                    cmd.Parameters.AddWithValue("@var1", product.ProductName);
                    cmd.Parameters.AddWithValue("@var2", product.Category);
                    cmd.Parameters.AddWithValue("@var3", product.CatNumber);
                    cmd.Parameters.AddWithValue("@var4", product.Price);
                    cmd.Parameters.AddWithValue("@var5", product.Quantity);
                    cmd.Parameters.AddWithValue("@var6", product.Description);
                    cmd.Parameters.AddWithValue("@var7", product.Status);
                    //cmd.Parameters.AddWithValue("@var8", product.ImagePath);

                    // command
                    cmd.CommandText = "UPDATE Products SET prod_name=@var1, category=@var2, catalog_number=@var3,"
                        + "price=@var4, quantity=@var5, description=@var6, status=@var7 WHERE prod_id=" + product.Id.ToString();

                    ExecuteSimpleQuery(cmd);
                }
            }
        }

        // Products table update -based on order
        private void _ProductsUpd(DclassOrder order)
        {
            // data exists
            if (order != null)
            {
                for (int i = 0; i < order.Products.Count; i++)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    // parameters
                    cmd.Parameters.AddWithValue("@var1", (order.Products[i].Quantity - order.Quantity[i]));

                    // command
                    cmd.CommandText = "UPDATE Products SET quantity=@var1 WHERE prod_id=" + order.Products[i].Id.ToString();

                    ExecuteSimpleQuery(cmd);
                }
            }
        }

        // Users table update
        private void _UsersUpd(DataHolder dh)
        {
            DclassUser[] users = null;

            if (dh != null)
            {
                users = _DataRowClToUsers(dh.DataTbl?.GetChanges(DataRowState.Modified)?.Rows); // get changed users
            }
            
            // users exists
            if (users != null)
            {
                foreach (DclassUser user in users)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    // parameters
                    cmd.Parameters.AddWithValue("@var1", user.UserName);
                    cmd.Parameters.AddWithValue("@var2", user.FirstName);
                    cmd.Parameters.AddWithValue("@var3", user.LastName);
                    cmd.Parameters.AddWithValue("@var4", user.Email);
                    cmd.Parameters.AddWithValue("@var5", user.Phone);
                    cmd.Parameters.AddWithValue("@var6", user.UserType);
                    cmd.Parameters.AddWithValue("@var7", user.Status);

                    // command
                    cmd.CommandText = "UPDATE Users SET user_name=@var1, first_name=@var2, last_name=@var3,"
                        + "email=@var4, phone_number=@var5, user_type=@var6, "
                        + " status=@var7 WHERE user_id=" + user.Id.ToString();

                    ExecuteSimpleQuery(cmd);
                }
            }
        }

        // Clients table update
        private void _ClientsUpd(DataHolder dh)
        {
            DclassClient[] clients = null;

            if (dh != null)
            {
                clients = _DataRowClToClients(dh.DataTbl?.GetChanges(DataRowState.Modified)?.Rows); // get changed clients
            }

            // clients exists
            if (clients != null)
            {
                foreach (DclassClient client in clients)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    
                    // parameters
                    cmd.Parameters.AddWithValue("@var1", client.FirstName);
                    cmd.Parameters.AddWithValue("@var2", client.LastName);
                    cmd.Parameters.AddWithValue("@var3", client.Phone);
                    cmd.Parameters.AddWithValue("@var4", client.Email);
                    cmd.Parameters.AddWithValue("@var5", client.Address);

                    // command
                    cmd.CommandText = "UPDATE Clients SET first_name=@var1, last_name=@var2,"
                        + "phone=@var3, email=@var4, address=@var5 WHERE client_id=" + client.Id.ToString();
                        
                    ExecuteSimpleQuery(cmd);
                }
            }
        }

        // Suppliers table update
        private void _SuppliersUpd(DataHolder dh)
        {
            DclassSupplier[] suppliers = null;

            if (dh != null)
            {
                suppliers = _DataRowClToSuppliers(dh.DataTbl?.GetChanges(DataRowState.Modified)?.Rows); // get changed suppliers
            }

            // clients exists
            if (suppliers != null)
            {
                foreach (DclassSupplier supplier in suppliers)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    // parameters
                    cmd.Parameters.AddWithValue("@var1", supplier.CompanyName);
                    cmd.Parameters.AddWithValue("@var2", supplier.ContactName);
                    cmd.Parameters.AddWithValue("@var3", supplier.Phone);
                    cmd.Parameters.AddWithValue("@var4", supplier.Email);
                    cmd.Parameters.AddWithValue("@var5", supplier.Address);
                    cmd.Parameters.AddWithValue("@var6", supplier.Status);

                    // command
                    cmd.CommandText = "UPDATE Suppliers SET comp_name=@var1, contact_name=@var2,"
                        + "phone=@var3, email=@var4, address=@var5, status=@var6 WHERE supp_id=" + supplier.Id.ToString();

                    ExecuteSimpleQuery(cmd);
                }
            }
        }

        // Prices policy update
        private void _PricesPolicyUpd(DataHolder dh)
        {
            // data is present
            if (dh != null)
            {
                DataHolderPricesP prices = dh as DataHolderPricesP;

                OleDbCommand cmd = new OleDbCommand();

                // parameters
                cmd.Parameters.AddWithValue("@var1", prices.Vat);
                cmd.Parameters.AddWithValue("@var2", prices.Commision);
                cmd.Parameters.AddWithValue("@var3", prices.CusDscnt1);
                cmd.Parameters.AddWithValue("@var4", prices.CusDscnt2);
                cmd.Parameters.AddWithValue("@var5", prices.CusDscnt3);
                cmd.Parameters.AddWithValue("@var6", prices.SeasonDscntActive);
                cmd.Parameters.AddWithValue("@var7", prices.OptionCustDcnt);
                cmd.Parameters.AddWithValue("@var8", prices.OptionStoreCms);
                cmd.Parameters.AddWithValue("@var9", prices.DateStart.ToString());
                cmd.Parameters.AddWithValue("@var10", prices.DateEnd.ToString());

                // command
                cmd.CommandText = "UPDATE PricesPolicy SET vat=@var1, store_commission=@var2, cu_discsnt1=@var3,"
                    + "cu_discsnt2=@var4, cu_discsnt3=@var5, season_dscnt_active=@var6, opt_cus_dscnt_incl=@var7,"
                    + " opt_str_cms_incl=@var8, start_date=@var9, end_date=@var10 WHERE ID=" + prices.ID;

                ExecuteSimpleQuery(cmd);
            }
        }
        #endregion

        #region Data request
        // Get data form the database as data class
        public DataClass[] GetData(string dataType)
        {
            DataClass[] dc = null;

            switch (dataType)
            {
                case "Suppliers":
                    DataHolder dh = GetTabData("Suppliers");
                    dc = _DataRowClToSuppliers(dh.DataTbl.Rows);
                    break;
            }

            return dc;
        }
        
        // Get data form the database as data class
        public DataClass[] GetDataFiltered(string dataType, DataClass filter)
        {
            DataClass[] dc = null;

            DataHolder dh = GetTabData(dataType);
            dh.DataCls = filter;    // set data class

            switch (dataType)
            {
                case "Clients":
                    _FilterClients(dh);     // filter table
                    dc = _DataRowClToClients(dh.DataTbl.DefaultView.ToTable().Rows);    // get filtered data
                    break;
                case "Products":
                    _FilterProducts(dh);     // filter table
                    dc = _DataRowClToProducts(dh.DataTbl.DefaultView.ToTable().Rows);    // get filtered data
                    break;
            }

            return dc;
        }
        #endregion

        #region Other
        // Get users from data row collection
        private DclassUser[] _DataRowClToUsers(DataRowCollection rows)
        {
            DclassUser[] users = null;

            // data present
            if (rows != null)
            {
                // rows present
                if (rows != null && rows.Count > 0)
                {
                    int totalRows = rows.Count;     // total rows
                    users = new DclassUser[totalRows];

                    // each row
                    for (int i = 0; i < totalRows; i++)
                    {
                        DclassUser tUser = new DclassUser();

                        // fill data
                        tUser.Id = int.Parse(rows[i][0].ToString());
                        tUser.UserName = rows[i][1].ToString();
                        tUser.FirstName = rows[i][2].ToString();
                        tUser.LastName = rows[i][3].ToString();
                        tUser.Email = rows[i][4].ToString();
                        tUser.Phone = rows[i][5].ToString();
                        tUser.UserType = rows[i][6].ToString();
                        tUser.EmployDate = DateTime.Parse(rows[i][7].ToString());
                        tUser.Status = bool.Parse(rows[i][8].ToString());

                        users[i] = tUser;
                    }
                }
            }

            return users;
        }

        // Get products from data row collection
        private DclassProduct[] _DataRowClToProducts(DataRowCollection rows)
        {
            DclassProduct[] products = null;

            // data present
            if (rows != null)
            {
                // rows present
                if (rows != null && rows.Count > 0)
                {
                    int totalRows = rows.Count;     // total rows
                    products = new DclassProduct[totalRows];

                    // each row
                    for (int i = 0; i < totalRows; i++)
                    {
                        DclassProduct tProduct = new DclassProduct();

                        // fill data
                        tProduct.Id = int.Parse(rows[i][0].ToString());
                        tProduct.CatNumber = rows[i][1].ToString();
                        tProduct.ProductName = rows[i][2].ToString();
                        tProduct.Category = rows[i][3].ToString();
                        tProduct.Price = double.Parse(rows[i][5].ToString());
                        tProduct.Quantity = int.Parse(rows[i][6].ToString());
                        tProduct.Description = rows[i][8].ToString();
                        tProduct.Status = bool.Parse(rows[i][9].ToString());

                        // Supplier
                        tProduct.Supplier = new DclassSupplier();
                        tProduct.Supplier.CompanyName = rows[i][4].ToString();

                        products[i] = tProduct;
                    }
                }
            }

            return products;
        }

        // Get clients from data row collection
        private DclassClient[] _DataRowClToClients(DataRowCollection rows)
        {
            DclassClient[] clients = null;

            // data present
            if (rows != null)
            {
                // rows present
                if (rows != null && rows.Count > 0)
                {
                    int totalRows = rows.Count;     // total rows
                    clients = new DclassClient[totalRows];

                    // each row
                    for (int i = 0; i < totalRows; i++)
                    {
                        DclassClient tClient = new DclassClient();

                        // fill data
                        tClient.Id = int.Parse(rows[i][0].ToString());
                        tClient.FirstName = rows[i][1].ToString();
                        tClient.LastName = rows[i][2].ToString();
                        tClient.Phone = rows[i][3].ToString();
                        tClient.Email = rows[i][4].ToString();
                        tClient.Address = rows[i][5].ToString();
                        clients[i] = tClient;
                    }
                }
            }

            return clients;
        }

        // Get supplierss from data row collection
        private DclassSupplier[] _DataRowClToSuppliers(DataRowCollection rows)
        {
            DclassSupplier[] suppliers = null;

            // data present
            if (rows != null)
            {
                // rows present
                if (rows != null && rows.Count > 0)
                {
                    int totalRows = rows.Count;     // total rows
                    suppliers = new DclassSupplier[totalRows];

                    // each row
                    for (int i = 0; i < totalRows; i++)
                    {
                        DclassSupplier tSupplier = new DclassSupplier();

                        // fill data
                        tSupplier.Id = int.Parse(rows[i][0].ToString());
                        tSupplier.CompanyName = rows[i][1].ToString();
                        tSupplier.ContactName = rows[i][2].ToString();
                        tSupplier.Phone = rows[i][3].ToString();
                        tSupplier.Email = rows[i][4].ToString();
                        tSupplier.Address = rows[i][5].ToString();
                        tSupplier.Status = bool.Parse(rows[i][7].ToString());

                        suppliers[i] = tSupplier;
                    }
                }
            }

            return suppliers;
        }
        #endregion

        #region Reports
        // Create a report from the db
        public DataHolder GetReport(string currentTab)
        {
            DataHolder dh = null;

            switch (currentTab)
            {
                case "Orders":
                    dh = _ReportOrders();
                    break;
            }

            return dh;
        }

        // Return a dataholder class with a report created from the db data
        public DataHolder _ReportOrders()
        {
            int years = 5;  // amount of years to produce the report for

            DclassReport report = new DclassReport();

            // set name
            report.ReportName = "Orders Report";
            report.ReportType = "Sales";

            // get data for each year
            for (int i = years -1; i >= 0; i--)
            {
                OleDbCommand cmd = new OleDbCommand();

                // date range
                DateTime dateTimeStart = new DateTime(DateTime.Now.Date.Year - i, 1, 1);
                DateTime dateTimeEnd = new DateTime(dateTimeStart.Year, 12, 31);

                // parameters
                cmd.Parameters.AddWithValue("@var1", dateTimeStart.Date);
                cmd.Parameters.AddWithValue("@var2", dateTimeEnd.Date);

                // command
                cmd.CommandText = "SELECT COUNT(order_id) FROM Orders WHERE order_date BETWEEN @var1 AND @var2";


                int res = ExecuteScalarIntQuery(cmd);   // query result

                // add to report
                report.XVal.Add(dateTimeStart.Year);
                report.YVal.Add(res);
            }

            // create data holder class
            DataHolder dh = new DataHolderGeneral();
            dh.DataCls = report;

            return dh;
        }
        #endregion
    }
}
