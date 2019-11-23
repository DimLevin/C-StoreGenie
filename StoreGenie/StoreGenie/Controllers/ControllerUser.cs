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
     User specific control methods
    */
    public abstract class ControllerUser
    {
        private ModelUser _model;
        private FormView _view; 
        

        // PROPERTIES
        public ModelUser Mdel { get => _model; set => _model = value; }
        public FormView View { get => _view; set => _view = value; }


        // METHODS

        #region Buttons
        protected abstract void _BtnAdd(string currentTab);
        protected abstract void _BtnSearch(string currentTab);
        protected abstract void _BtnEdit(string currentTab);
        protected abstract void _BtnReport(string currentTab);
        // Save
        protected void _BtnSave(string currentTab)
        {
            switch (currentTab)
            {
                case "Clients":
                case "Orders":
                case "Products":
                case "Users":
                case "Suppliers":
                case "Prices Policy":
                    Mdel.UpdateDb(currentTab, View.SaveData());
                    break;
            }
        }
        // ActionAdd
        protected void _BtnActionAdd(string currentTab)
        {
            DataHolder dh = View.GetData();   // get data
            Mdel.AddData(currentTab, dh);     // add data
        }
        // ActionSearch
        protected void _BtnActionSearch(string currentTab)
        {
            DataHolder dh = View.GetData();      // get data
            Mdel.FilterData(currentTab, dh);     // filter data
            
        }
        // Refresh
        protected void _BtnRefresh(string currentTab)
        {
            _SendDataToView();
        }
        // Button pressed
        public void ButtonPressed(string button)
        {
            string currentTab = View.CurrentTabText;

            switch (button)
            {
                case "Add":
                    _BtnAdd(currentTab);
                    break;
                case "Refresh":
                    _BtnRefresh(currentTab);
                    break;
                case "Search":
                    _BtnSearch(currentTab);
                    break;
                case "Edit":
                    _BtnEdit(currentTab);
                    break;
                case "Save":
                    _BtnSave(currentTab);
                    break;
                case "Report":
                    _BtnReport(currentTab);
                    break;
                case "ActionAdd":
                    _BtnActionAdd(currentTab);
                    break;
                case "ActionSearch":
                    _BtnActionSearch(currentTab);
                    break;
            }
        }
        #endregion

        // Tab selected
        public void TabSelected()
        {
            View.SetButtons(_model.GetAllowedButtons(View.CurrentTabText));     // set buttons
            _SendDataToView();  // set data table to view
        }

        // Set data to view
        protected void _SendDataToView()
        {
            DataHolder dh = Mdel.GetTabData(View.CurrentTabText);   // get data as data table

            // data is present
            if (dh != null)
            {
                View.AddToView(dh);
            }
        }

        // Data requested from view
        public DataClass[] DataRequest(string dataRequest)
        {
            DataClass[] dc = null;

            switch (dataRequest)
            {
                case "Suppliers":
                    dc = Mdel.GetData(dataRequest);
                    break;
            }

            return dc;
        }

        // Data requested from view -filtered
        public DataClass[] DataRequest(string data, DataClass filter)
        {
            DataClass[] dc = null;

            switch (data)
            {
                case "Products":
                case "Clients":
                    dc = Mdel.GetDataFiltered(data, filter);
                    break;
            }

            return dc;
        }
    }
}
