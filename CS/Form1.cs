using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.DashboardWin;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DataInspectorCustomizationExample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<string, Stream> aggregatedGridLayoutDictionary = new Dictionary<string, Stream>();
        Dictionary<string, Stream> rawGridLayoutDictionary = new Dictionary<string, Stream>();
        public Form1() {
            InitializeComponent();
            dashboardViewer1.AllowInspectAggregatedData = true;
            dashboardViewer1.AllowInspectRawData = true;
            dashboardViewer1.DataInspectorFormLoad += DashboardViewer1_DataInspectorFormLoad;
            dashboardViewer1.DataInspectorFormClosing += DashboardViewer1_DataInspectorFormClosing;
        }

        private void DashboardViewer1_DataInspectorFormClosing(object sender, DataInspectorFormClosingEventArgs e) {
            SaveGridLayout(e.DashboardItemName, e.AggregatedGrid.FocusedView, aggregatedGridLayoutDictionary);
            SaveGridLayout(e.DashboardItemName, e.RawGrid.FocusedView, rawGridLayoutDictionary);
        }
        private void DashboardViewer1_DataInspectorFormLoad(object sender, DataInspectorFormLoadEventArgs e) {
            CustomizeGrid(e.AggregatedGrid);
            CustomizeGrid(e.RawGrid);

            RestoreGridLayout(e.DashboardItemName, e.AggregatedGrid.FocusedView, aggregatedGridLayoutDictionary);
            RestoreGridLayout(e.DashboardItemName, e.RawGrid.FocusedView, rawGridLayoutDictionary);
        }
        void CustomizeGrid(GridControl grid) {
            GridView view = grid.MainView as GridView;
            view.OptionsCustomization.AllowGroup = true;
            view.OptionsView.ShowGroupPanel = true;
            view.OptionsBehavior.AutoExpandAllGroups = true;
        }
        void SaveGridLayout(string itemName, BaseView gridView, Dictionary<string, Stream> layouts) {
            MemoryStream str = new MemoryStream();
            gridView.SaveLayoutToStream(str);
            layouts[itemName] = str;
            str.Seek(0, SeekOrigin.Begin);
        }
        void RestoreGridLayout(string itemName, BaseView gridView, Dictionary<string, Stream> layouts) {
            Stream stream = null;
            if(layouts.TryGetValue(itemName, out stream)) {
                gridView.RestoreLayoutFromStream(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
            }
        }
    }
}
