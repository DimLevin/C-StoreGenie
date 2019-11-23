using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace StoreGenie
{
    /*
    Store manager controller 
    */
    class ControllerManage : ControllerUser
    {
        private static ControllerManage _instance;


        // CONSTR.
        private ControllerManage() { }

        // Singleton initiator
        public static ControllerManage Init()
        {
            if (ControllerManage._instance == null)
            {
                ControllerManage._instance = new ControllerManage();
            }

            return ControllerManage._instance;
        }


        // METHODS
        #region Buttons
        // Add
        protected override void _BtnAdd(string currentTab)
        {
            switch (currentTab)
            {
                case "Users":
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
                case "Orders":
                case "Products":
                case "Users":
                case "Suppliers":
                case "Prices Policy":
                    View.EditData();
                    break;
            }
        }
        // Report
        protected override void _BtnReport(string currentTab)
        {
            switch (currentTab)
            {
                case "Clients":
                    break;
                case "Orders":
                    break;
                case "Products":
                    break;
                case "Users":
                    break;
                case "Suppliers":
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
                case "Users":
                case "Suppliers":
                    View.SearchWindow();
                    break;
            }
        }
        #endregion
    }
}
