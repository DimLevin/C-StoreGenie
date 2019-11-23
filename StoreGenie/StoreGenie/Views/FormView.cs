using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreGenie
{
    public partial class FormView : Form
    {
        private Controller _controller;

        public FormView()
        {
            InitializeComponent();
        }

        // Form loads
        private void FormView_Load(object sender, EventArgs e)
        {
            _controller = Controller.Init();

            // add listeners
            ctrlData.TabCtrl.Selected += new TabControlEventHandler(_TabSelected);
            ctrlData.ToolStripTopButtons.ItemClicked += new ToolStripItemClickedEventHandler(_TlsItemClicked);

            _TabSelected(CurrentTabText);   // set data on start
        }


        // PROPERTIES
        public string CurrentTabText { get => ctrlData.TabCtrl.SelectedTab.Text; }


        #region Methods
        // Tab Selected
        private void _TabSelected(object sender, TabControlEventArgs e)
        {
            _TabSelected(e.TabPage.Text);
        }
        private void _TabSelected(string tab)
        {
            _controller.CurrSession.Controller.TabSelected();
        }

        // Tool strip item clicked
        private void _TlsItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // button
            if (e.ClickedItem.Tag.ToString().Equals("button"))
            {
                _controller.CurrSession.Controller.ButtonPressed(e.ClickedItem.Text);
            }
        }

        // Remove irrelevant tabs
        public void RemoveIrrTabs(string[] allowedTabs)
        {
            TabControl.TabPageCollection pages = ctrlData.TabCtrl.TabPages;     // all tabs

            // each tab
            foreach (TabPage page in pages)
            {
                // not in tabs list
                if (!allowedTabs.Contains(page.Text))
                {
                    ctrlData.TabCtrl.TabPages.Remove(page);     // remove current tab
                }
            }
        }

        // Set buttons
        public void SetButtons(string[] allowedButtons)
        {
            ToolStripItemCollection items = ctrlData.ToolStripTopButtons.Items;

            // each item
            foreach (ToolStripItem item in items)
            {
                // button
                if (item.Tag != null && item.Tag.ToString().Equals("button"))
                {
                    ToolStripButton btn = item as ToolStripButton;

                    // allowed
                    if (allowedButtons.Contains(btn.Text))
                    {
                        btn.Enabled = true;     // enable button
                    }
                    else
                    {
                        btn.Enabled = false;
                    }
                }
            }
        }

        // Add data table to curr. tab
        public void AddToView(DataHolder dh)
        {
            ctrlData.CurrentData = dh;
        }

        // Edit
        public void EditData()
        {
            ctrlData.EnableEdit();
        }

        // Save data
        public DataHolder SaveData()
        {
            ctrlData.DisableEdit();
            return ctrlData.CurrentData;
        }

        // Get data
        public DataHolder GetData()
        {
            return ctrlData.CurrentData;
        }

        // Search window
        public void SearchWindow()
        {
            ctrlData.AddSearchWindow("Search");
        }

        // Add window
        public void AddWindow()
        {
            ctrlData.AddSearchWindow("Add");
        }

        // Show report
        public void ShowReport(DataHolder data)
        {
            // set form
            FormReport frm = new FormReport();

            // set data
            frm.SetData(data);

            // show form
            frm.ShowDialog();
        }
        #endregion
    }
}
