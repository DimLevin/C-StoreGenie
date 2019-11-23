using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    /*
    Sales manager controller 
    */
    class ControllerSales : ControllerUser
    {
        private static ControllerSales _instance;


        // CONSTR.
        private ControllerSales() { }

        // Singleton initiator
        public static ControllerSales Init()
        {
            if (ControllerSales._instance == null)
            {
                ControllerSales._instance = new ControllerSales();
            }

            return ControllerSales._instance;
        }

        // METHODS

        #region Buttons
        // Add
        protected override void _BtnAdd(string currentTab)
        {
            switch (currentTab)
            {
                case "Clients":
                case "Orders":
                    View.AddWindow();
                    break;
            }
        }
        // Edit
        protected override void _BtnEdit(string currentTab)
        {
            switch (currentTab)
            {
                case "Clients":
                    View.EditData();
                    break;
            }
        }
        // Report
        protected override void _BtnReport(string currentTab)
        {
            switch (currentTab)
            {
                case "Orders":
                    DataHolder dh = Mdel.GetReport(currentTab);
                    View.ShowReport(dh);
                    break;
            }
        }
        // Search
        protected override void _BtnSearch(string currentTab)
        {
            switch (currentTab)
            {
                case "Clients":
                case "Orders":
                case "Products":
                    View.SearchWindow();
                    break;
            }
        }
        #endregion

    }
}
