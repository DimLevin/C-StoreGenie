using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    /*
    Stock manager controller 
    */
    class ControllerStock : ControllerUser
    {
        private static ControllerStock _instance;


        // CONSTR.
        private ControllerStock() { }

        // Singleton initiator
        public static ControllerStock Init()
        {
            if (ControllerStock._instance == null)
            {
                ControllerStock._instance = new ControllerStock();
            }

            return ControllerStock._instance;
        }


        // METHODS

        #region Buttons
        // Add
        protected override void _BtnAdd(string currentTab)
        {
            switch (currentTab)
            {
                case "Products":
                case "Suppliers":
                    View.AddWindow();
                    break;
            }
        }
        // Edit
        protected override void _BtnEdit(string currentTab)
        {
            switch (currentTab)
            {
                case "Products":
                case "Suppliers":
                    View.EditData();
                    break;
            }
        }
        // Report
        protected override void _BtnReport(string currentTab)
        {
            
        }
        // Search
        protected override void _BtnSearch(string currentTab)
        {
            switch (currentTab)
            {
                case "Products":
                case "Suppliers":
                    View.SearchWindow();
                    break;
            }
        }
        #endregion

    }
}
