using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreGenie
{
    /*
      Holds various data

      Used for data transfer between modules
    */
    public abstract class DataHolder
    {
        private DataTable _dt;
        private DataClass _dc;
        private List<int> _selectedIds;

        // CONSTR.
        public DataHolder() { }
        public DataHolder(DataTable dt)
        {
            _dt = dt;
            _selectedIds = new List<int>();     // init. list
        }


        // PROPERTIES
        public DataTable DataTbl { get => _dt; set => _dt = value; }
        public DataClass DataCls { get => _dc; set => _dc = value; }
        public List<int> SelectedIds { get => _selectedIds; set => _selectedIds = value; }
    }

    /*
     General data holder
    */
    public  class DataHolderGeneral : DataHolder
    {
        // CONSTR.
        public DataHolderGeneral() { }
        public DataHolderGeneral(DataTable dt) : base(dt) { }
    }

    /*
     Prices policy data holder
    */
    public class DataHolderPricesP : DataHolder
    {
        #region Private Properties
        private int _id;
        // prices
        private double _vat;
        private double _commission;
        // customer discount
        private double _cust1yrDscnt;
        private double _cust2yrDscnt;
        private double _cust3yrDscnt;
        // season discount
        private bool _isDscntActive;
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _optCusDcnt;
        private bool _optStoreCms;
        #endregion

        // CONSTR.
        public DataHolderPricesP(DataTable dt) : base(dt)
        {
            _FillData();
        }

        #region Public Properties
        public int ID { get => _id; set => _id = value; }
        // Prices
        public double Vat { get => _vat; set => _vat = value; }
        public double Commision { get => _commission; set => _commission = value; }
        // Customer discount
        public double CusDscnt1 { get => _cust1yrDscnt; set => _cust1yrDscnt = value; }
        public double CusDscnt2 { get => _cust2yrDscnt; set => _cust2yrDscnt = value; }
        public double CusDscnt3 { get => _cust3yrDscnt; set => _cust3yrDscnt = value; }
        // Season discount
        public bool SeasonDscntActive { get => _isDscntActive; set => _isDscntActive = value; }
        public DateTime DateStart { get => _startDate; set => _startDate = value; }
        public DateTime DateEnd
        {
            get => _endDate;
            set
            {
                // value is further/equal than/to today
                if (value.CompareTo(DateTime.Now) >= 0)
                {
                    _endDate = value;
                }
                else
                {
                    _isDscntActive = false;
                    _endDate = DateTime.Now.AddDays(1);
                    _startDate = DateTime.Now;
                }
            }
        }
        
        public bool OptionCustDcnt { get => _optCusDcnt; set => _optCusDcnt = value; }
        public bool OptionStoreCms { get => _optStoreCms; set => _optStoreCms = value; }
        #endregion

        // METHODS

        // Fill data
        private void _FillData()
        {
            // if data table presents
            if (DataTbl != null)
            {
                DataRow dr = DataTbl.Rows[0];

                int.TryParse(dr["ID"].ToString(), out _id);
                // Prices
                double.TryParse(dr["vat"].ToString(), out _vat);
                double.TryParse(dr["store_commission"].ToString(), out _commission);
                // Customer discount
                double.TryParse(dr["cu_discsnt1"].ToString(), out _cust1yrDscnt);
                double.TryParse(dr["cu_discsnt2"].ToString(), out _cust2yrDscnt);
                double.TryParse(dr["cu_discsnt3"].ToString(), out _cust3yrDscnt);
                // Season discount
                bool.TryParse(dr["season_dscnt_active"].ToString(), out _isDscntActive);
                DateTime.TryParse(dr["start_date"].ToString(), out _startDate);
                
                // end date
                DateTime.TryParse(dr["end_date"].ToString(), out DateTime dVal);
                DateEnd = dVal;

                // options
                bool.TryParse( dr["opt_cus_dscnt_incl"].ToString(), out _optCusDcnt);
                bool.TryParse( dr["opt_str_cms_incl"].ToString(), out _optStoreCms);
            }
        }
    }
}
