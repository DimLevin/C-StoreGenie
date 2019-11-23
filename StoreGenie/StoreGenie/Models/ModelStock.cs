using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreGenie
{
    class ModelStock : ModelUser
    {
        // PRIVATE PROPERTIES
        private static string[] _ALLOWED_TABS = { "Products", "Suppliers" };
        private static ModelStock _instance;


        // CONSTR.
        private ModelStock()
        {
            base.AllowedTabs = _ALLOWED_TABS;  // set tabs
        }

        // Singleton initiator
        public static ModelStock Init()
        {
            if (ModelStock._instance == null)
            {
                ModelStock._instance = new ModelStock();
            }

            return ModelStock._instance;
        }


        // METHODS

        // Allowed buttons in a spec. tab
        public override string[] GetAllowedButtons(string tab)
        {
            string[] tArr = null;

            switch (tab)
            {
                case "Products":
                    tArr = new string[] { "Edit", "Add", "Refresh", "Search" };
                    break;
                case "Suppliers":
                    tArr = new string[] { "Edit", "Add", "Refresh", "Search" };
                    break;
                default:
                    tArr = new string[] { "" };
                    break;
            }

            return tArr;
        }
    }
}
