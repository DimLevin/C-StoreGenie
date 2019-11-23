using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace StoreGenie
{
    class ModelManage : ModelUser
    {
        // PRIVATE PROPERTIES
        private static string[] _ALLOWED_TABS = { "Clients", "Orders", "Products", "Suppliers", "Users", "Prices Policy" };
        private static ModelManage _instance;


        // CONSTR.
        private ModelManage()
        {
            base.AllowedTabs = _ALLOWED_TABS;  // set tabs
        }

        // Singleton initiator
        public static ModelManage Init()
        {
            if (ModelManage._instance == null)
            {
                ModelManage._instance = new ModelManage();
            }

            return ModelManage._instance;
        }


        // METHODS

        // Allowed buttons in a spec. tab
        public override string[] GetAllowedButtons(string tab)
        {
            string[] tArr = null;

            switch (tab)
            {
                case "Clients":
                    tArr = new string[] { "Edit", "Refresh", "Search" };
                    break;
                case "Orders":
                    tArr = new string[] { "Edit", "Refresh", "Search" };
                    break;
                case "Products":
                    tArr = new string[] { "Edit", "Refresh", "Search" };
                    break;
                case "Suppliers":
                    tArr = new string[] { "Edit", "Refresh", "Search" };
                    break;
                case "Users":
                    tArr = new string[] { "Edit", "Add", "Refresh" };
                    break;
                case "Prices Policy":
                    tArr = new string[] { "Edit" };
                    break;
                default:
                    tArr = new string[] { "" };
                    break;
            }

            return tArr;
        }
    }
}
