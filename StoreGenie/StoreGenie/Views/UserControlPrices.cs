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
    public partial class UserControlPrices : UserControl
    {
        #region Constr. + Properties
        private DataHolderPricesP _prices;

        public UserControlPrices()
        {
            InitializeComponent();
        }

        public DataHolder PricesData
        {
            get
            {
                _SaveData();
                return _prices;
            }

            set
            {
                _prices = value as DataHolderPricesP;
                _LoadData();            // load data
            }
        }
        #endregion

        // METHODS

        #region Data Load/Save
        // Load data
        private void _LoadData()
        {
            if (_prices != null)
            {
                // Prices
                tBoxPricesVat.Text = _prices.Vat.ToString();
                tBoxPricesStoreCms.Text = _prices.Commision.ToString();
                // Customer discount
                cmbPricesCustomer1yr.Text = _prices.CusDscnt1.ToString();
                cmbPricesCustomer2yr.Text = _prices.CusDscnt2.ToString();
                cmbPricesCustomer3yr.Text = _prices.CusDscnt3.ToString();
                // Season discount
                dtpPricesSdscntStart.Value = _prices.DateStart;
                dtpPricesSdscntEnd.Value = _prices.DateEnd;

                // discount on/off
                if (_prices.SeasonDscntActive)
                {
                    rbtnPricesSdscntOn.Checked = true;
                    rbtnPricesSdscntOff.Checked = false;
                }
                else
                {
                    rbtnPricesSdscntOn.Checked = false;
                    rbtnPricesSdscntOff.Checked = true;
                }
                chkbPricesSdscntCdiscountIncl.Checked = _prices.OptionCustDcnt;
                chkbPricesSdscntStoreCmsIncl.Checked = _prices.OptionStoreCms;
            }
        }

        // Save data
        private void _SaveData()
        {
            if (_prices != null)
            {
                // Prices
                _prices.Vat = double.Parse(tBoxPricesVat.Text);
                _prices.Commision = double.Parse(tBoxPricesStoreCms.Text);
                // Customer discount
                _prices.CusDscnt1 = double.Parse(cmbPricesCustomer1yr.Text);
                _prices.CusDscnt2 = double.Parse(cmbPricesCustomer2yr.Text);
                _prices.CusDscnt3 = double.Parse(cmbPricesCustomer3yr.Text);
                // Season discount
                _prices.SeasonDscntActive = rbtnPricesSdscntOn.Checked;
                _prices.DateStart = dtpPricesSdscntStart.Value;
                _prices.DateEnd = dtpPricesSdscntEnd.Value;
                _prices.OptionCustDcnt = chkbPricesSdscntCdiscountIncl.Checked;
                _prices.OptionStoreCms = chkbPricesSdscntStoreCmsIncl.Checked;
            }
        }
        #endregion

        // Control loads
        private void UserControlPrices_Load(object sender, EventArgs e)
        {
            // Add listeners

            // number fields
            tBoxPricesVat.TextChanged += _NumberFieldCheck;
            tBoxPricesStoreCms.TextChanged += _NumberFieldCheck;

            // dates fields
            dtpPricesSdscntStart.ValueChanged += _DatesCheck;
            dtpPricesSdscntEnd.ValueChanged += _DatesCheck;
        }

        // String to double num. conversion check
        private bool _StrToDoubleChk(string value)
        {
            bool res = false;
            
            // conversion
            if (double.TryParse(value, out double tNum))
            {
                // range
                if (tNum >= 0 && tNum <= 100)
                {
                    res = true;
                }
            }

            return res;
        }

        // Number field check
        private void _NumberFieldCheck(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;

            // false value
            if (!_StrToDoubleChk(tBox.Text))
            {
                tBox.Text = string.Empty;   // empty string
            }
        }

        // Dates check
        private void _DatesCheck(object sender, EventArgs e)
        {
            // check end date
            if (dtpPricesSdscntEnd.Value.CompareTo(DateTime.Now) < 0)
            {
                rbtnPricesSdscntOff.Checked = true;
                dtpPricesSdscntStart.Value = DateTime.Now;
                dtpPricesSdscntEnd.Value = dtpPricesSdscntStart.Value.AddDays(1);
            }
        }

        // Set controls active or non active
        public void SetControls(bool state)
        {
            ControlCollection controls = this.Controls;

            // set all control state
            foreach (Control control in controls)
            {
                control.Enabled = state;
            }
        }
    }
}
