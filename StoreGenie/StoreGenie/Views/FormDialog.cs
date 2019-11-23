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
    public partial class FormDialog : Form
    {
        // PRIVATE PROPERTIES
        private UserControl _uc;
        private bool _isSearch;

        // CONSTR.
        public FormDialog()
        {
            InitializeComponent();
        }

        #region Public Properties
        public UserControl UsrCntr
        {
            get => _uc;
            set
            {
                _uc = value;
                this.Controls.Add(_uc);
            }
        }
        public bool IsSearch
        {
            get => _isSearch;
            set
            {
                _isSearch = value;
                _SetAsSearch(value);
            }
        }
        #endregion

        #region Methods
        // Get data class
        public DataClass GetDataCls()
        {
            DataClass cl = null;

            // dett. type (abstract UserControl will be added further https://stackoverflow.com/questions/6817107/abstract-usercontrol-inheritance-in-visual-studio-designer)
            if (_uc is UserControlClient)
            {
                cl = (_uc as UserControlClient).GetData();
            }
            else if (_uc is UserControlSupplier)
            {
                cl = (_uc as UserControlSupplier).GetData();
            }
            else if (_uc is UserControlProduct)
            {
                cl = (_uc as UserControlProduct).GetData();
            }
            else if (_uc is UserControlOrderSearch)
            {
                cl = (_uc as UserControlOrderSearch).GetData();
            }
            else if (_uc is UserControlOrderAdd)
            {
                cl = (_uc as UserControlOrderAdd).GetData();
            }

            return cl;
        }

        // Set window type
        private void _SetAsSearch(bool IsSearchWindow)
        {
            // dett. type (abstract UserControl will be added further https://stackoverflow.com/questions/6817107/abstract-usercontrol-inheritance-in-visual-studio-designer)
            if (_uc is UserControlClient)
            {
                (_uc as UserControlClient).IsSearchWindow = IsSearchWindow;
            }
            else if (_uc is UserControlSupplier)
            {
                (_uc as UserControlSupplier).IsSearchWindow = IsSearchWindow;
            }
            else if (_uc is UserControlProduct)
            {
                (_uc as UserControlProduct).IsSearchWindow = IsSearchWindow;
            }
        }

        // Check if all fields is filled in the user control
        public bool FormFilled()
        {
            bool res = false;

            // dett. type (abstract UserControl will be added further https://stackoverflow.com/questions/6817107/abstract-usercontrol-inheritance-in-visual-studio-designer)
            if (_uc is UserControlClient)
            {
                res = (_uc as UserControlClient).AllFieldsIsFilled;
            }
            else if (_uc is UserControlSupplier)
            {
                res = (_uc as UserControlSupplier).AllFieldsIsFilled;
            }
            else if (_uc is UserControlProduct)
            {
                res = (_uc as UserControlProduct).AllFieldsIsFilled;
            }
            else if (_uc is UserControlOrderAdd)
            {
                res = (_uc as UserControlOrderAdd).AllFieldsIsFilled;
            }

            return res;
        }
        #endregion
    }
}
