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
    public partial class UserControlOrderSearch : UserControl
    {
        public UserControlOrderSearch()
        {
            InitializeComponent();
        }

        // PROPERTIES
        public Button BtnAction { get => btnOrderSearchAction; }


        // METHODS

        // Form loads
        private void UserControlOrderSearch_Load(object sender, EventArgs e)
        {
            // add listeners
            tBoxOrderSearchId.TextChanged += _IdFieldCheck;
            tBoxOrderSearchClientId.TextChanged += _NumericFieldCheck;
            tBoxOrderSearchTotal.TextChanged += _NumericFieldCheck;
        }

        // Price field check
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

        // Set fields state active/non active (except Id field)
        private void _SetFieldsState(bool state)
        {
            ControlCollection controls = gBoxOrderSearch.Controls;

            // all controls
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.Equals("non_id"))
                {
                    control.Enabled = state;
                }
            }
        }

        // Get data class
        public DataClass GetData()
        {
            DclassOrder order = new DclassOrder();
            order.Client = new DclassClient();

            // Id field not empty
            if (!tBoxOrderSearchId.Text.Equals(string.Empty))
            {
                order.Id = int.Parse(tBoxOrderSearchId.Text);
            }
            else
            {
                // client id field
                int.TryParse(tBoxOrderSearchClientId.Text, out int iNum);
                order.Client.Id = (iNum > 0) ? iNum : -1;

                // total field
                double.TryParse(tBoxOrderSearchTotal.Text, out double dNum);
                order.Total = (dNum > 0) ? dNum : -1;

                order.OrderDate = dtpOrderSearchOrderDate.Value.Date;
                order.Description = tBoxOrderSearchDesc.Text;
            }

            return order;
        }
    }
}
