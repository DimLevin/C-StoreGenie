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
    public partial class UserControlData : UserControl
    {
        private DataGridView _currDgv;
        private DataHolder _currData;
        private FormDialog _dialogForm;

        public UserControlData()
        {
            InitializeComponent();
        }

        #region Public Properties
        public TabControl TabCtrl { get => tbcTabSelector; }            // tab control
        public ToolStrip ToolStripTopButtons { get => tlsTopButtons; }  // tool strip
        public DataHolder CurrentData
        {
            get
            {
                DataHolder dh = null;

                if (tbcTabSelector.SelectedTab.Tag.ToString().Equals("DataGridView"))
                {
                    dh = _currData;
                }
                else
                {
                    if (tbcTabSelector.SelectedTab.Text.Equals("Prices Policy"))
                    {
                        dh = ctrlPrices.PricesData;
                    }
                }

                return dh;
            }
            set
            {
                _currData = value;
                _SetData();
            }
        }
        #endregion

        // METHODS

        // Set data on tab
        private void _SetData()
        {
            if (tbcTabSelector.SelectedTab.Tag.ToString().Equals("DataGridView"))
            {
                // if DataGridView is already created
                if (_currDgv == null)
                {
                    DataGridView dgv = new DataGridView();
                    tbcTabSelector.SelectedTab.Controls.Add(_currDgv);   // add to tab

                    dgv.UserDeletingRow += _DgvDeleteItem_Click;        // add row delete event listener

                    _currDgv = dgv;
                }

                _currDgv.DataSource = _currData.DataTbl;    // set data source

                // restrictions
                _currDgv.ReadOnly = true;                // disable edit
                _currDgv.AllowUserToAddRows = false;     // disable add rows
                _currDgv.AllowDrop = false;              // disable drop
                _currDgv.MultiSelect = false;            // disable multi select

                _currDgv.Parent = tbcTabSelector.SelectedTab;   //set parent
                _currDgv.Dock = DockStyle.Fill;                 // maximize control
            }
            else
            {
                if (tbcTabSelector.SelectedTab.Text.Equals("Prices Policy"))
                {
                    ctrlPrices.SetControls(false);      // disable controls
                    ctrlPrices.PricesData = _currData;  // set data
                }
            }
        }

        // Enable edit
        public void EnableEdit()
        {
            tsbEdit.Enabled = false;    // disable edit button
            tsbSave.Enabled = true;     // enable save button

            // determine control type
            if (tbcTabSelector.SelectedTab.Tag.ToString().Equals("DataGridView"))
            {
                _currDgv.ReadOnly = false;
                _currDgv.Columns[0].ReadOnly = true;    // disable editing the first column
            }
            else
            {
                if (tbcTabSelector.SelectedTab.Text.Equals("Prices Policy"))
                {
                    ctrlPrices.SetControls(true);
                }
            }
        }

        // Disable edit
        public void DisableEdit()
        {
            tsbEdit.Enabled = true;     // enable edit button
            tsbSave.Enabled = false;    // disable save button

            // disable editing
            if (tbcTabSelector.SelectedTab.Tag.ToString().Equals("DataGridView"))
            {
                _currDgv.ReadOnly = true;
            }
            else
            {
                if (tbcTabSelector.SelectedTab.Text.Equals("Prices Policy"))
                {
                    ctrlPrices.SetControls(false);
                }
            }
        }

        // Add/search window
        public void AddSearchWindow(string type)
        {
            string currentTab = tbcTabSelector.SelectedTab.Text;

            UserControl uc = null;
            Button btn = null;

            // create user control
            switch (currentTab)
            {
                case "Clients":
                    uc = new UserControlClient();
                    btn = (uc as UserControlClient).BtnAction;
                    break;
                case "Orders":
                    // search window
                    if (type.Equals("Search"))
                    {
                        uc = new UserControlOrderSearch();
                        btn = (uc as UserControlOrderSearch).BtnAction;
                    }
                    else
                    {
                        uc = new UserControlOrderAdd();
                        btn = (uc as UserControlOrderAdd).BtnAction;
                    }
                    break;
                case "Products":
                    uc = new UserControlProduct();
                    btn = (uc as UserControlProduct).BtnAction;
                    break;
                case "Suppliers":
                    uc = new UserControlSupplier();
                    btn = (uc as UserControlSupplier).BtnAction;
                    break;
                case "Users":
                    break;
            }

            // User control created
            if (uc != null)
            {
                // button
                btn.Text = type;
                btn.Click += _ActionButtonClicked;

                // dialog
                FormDialog frm = new FormDialog();  // create new form
                _dialogForm = frm;
                frm.Text = type;    // change title
                frm.UsrCntr = uc;   // add user control
                frm.IsSearch = type.Equals("Search");     // set window type (search or not)
                frm.ShowDialog();   // show dialog
            }
        }

        // Action button clicked on add/search form
        private void _ActionButtonClicked(object sender, EventArgs e)
        {
            // if it's a search window or all fields is filled
            if (_dialogForm.IsSearch || _dialogForm.FormFilled())
            {
                _dialogForm.Visible = false;                    // hide form
                _currData.DataCls = _dialogForm.GetDataCls();   // save data class
                string btnTxt = (sender as Button).Text;
                _dialogForm.Dispose();                          // close form

                Session session = Session.Init();                       // init session
                session.Controller.ButtonPressed("Action" + btnTxt);    // inform controller
            }
            else
            {
                MessageBox.Show("All the fields should be filled!");
            }
        }

        // Row deleted on DataGridView
        private void _DgvDeleteItem_Click(object sender, DataGridViewRowCancelEventArgs e)
        {
            int idOfDeletedItem = int.Parse((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString());    // get id of a record
            _currData.SelectedIds.Add(idOfDeletedItem);     // add id to list
        }
    }
}
