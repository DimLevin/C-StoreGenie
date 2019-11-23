using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreGenie
{
    public partial class FormReport : Form
    {
        private Bitmap _chartImage;

        public FormReport()
        {
            InitializeComponent();
        }

        // METHODS

        // Set data
        public void SetData(DataHolder dh)
        {
            DclassReport report = dh.DataCls as DclassReport;

            // label
            lblReport.Text = report.ReportName;

            // create series (chart)
            Series series = new Series(report.ReportType);
            series.Points.DataBindXY(report.XVal.ToArray(), report.YVal.ToArray());

            // set data on chart
            chart.Series.Add(series);

            // chart screen shot
            _chartImage = _CreateChartScreenshot();
        }

        #region Private Methods
        // Create chart screenshot
        private Bitmap _CreateChartScreenshot()
        {
            // create bitmap
            Bitmap bm = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bm, new Rectangle(this.Location, chart.Size));

            return bm;
        }

        // Save button clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();    // show file save dialog
        }

        // Save file dialog ok button pressed
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = Path.GetFullPath((sender as SaveFileDialog).FileName);    // get file path
            _chartImage.Save(path, ImageFormat.Gif);    // save image
        }
        #endregion
    }
}
