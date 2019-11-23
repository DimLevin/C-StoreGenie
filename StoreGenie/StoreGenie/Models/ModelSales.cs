using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreGenie
{
    class ModelSales : ModelUser
    {
        // PRIVATE PROPERTIES
        private static string[] _ALLOWED_TABS = { "Clients", "Orders", "Products" };
        private static ModelSales _instance;


        // CONSTR.
        private ModelSales()
        {
            base.AllowedTabs = _ALLOWED_TABS;  // set tabs
        }

        // Singleton initiator
        public static ModelSales Init()
        {
            if (ModelSales._instance == null)
            {
                ModelSales._instance = new ModelSales();
            }

            return ModelSales._instance;
        }


        // METHODS

        // Allowed buttons in a spec. tab
        public override string[] GetAllowedButtons(string tab)
        {
            string[] tArr = null;

            switch (tab)
            {
                case "Clients":
                    tArr = new string[] { "Edit", "Add", "Refresh", "Search" };
                    break;
                case "Orders":
                    tArr = new string[] { "Add", "Refresh", "Search", "Report" };
                    break;
                case "Products":
                    tArr = new string[] { "Refresh", "Search" };
                    break;
                default:
                    tArr = new string[] { "" };
                    break;
            }

            return tArr;
        }
    }
}
