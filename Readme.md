<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# How to Customize the Data Inspector Dialog

This example illustrates how to handle the DataInspectorFormLoad and DataInspectorFormClosing events to get access to the Grid controls in the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window and change the grid settings.

![](/images/screenshot.png)

API in this example:

* [DashboardViewer.DataInspectorFormLoad](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataInspectorFormLoad) event
* [DashboardViewer.DataInspectorFormClosing](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataInspectorFormClosing) event
* [DataInspectorFormLoadEventArgs.AggregatedGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormLoadEventArgs.AggregatedGrid) property
* [DataInspectorFormClosingEventArgs.AggregatedGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormClosingEventArgs.AggregatedGrid) property
* [DataInspectorFormLoadEventArgs.RawGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormLoadEventArgs.RawGrid) property
* [DataInspectorFormClosingEventArgs.RawGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormClosingEventArgs.RawGrid) property
* [GridView.OptionsCustomization](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsCustomization) property
* [GridView.OptionsView](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsView) property
* [GridView.OptionsBehavior](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsBehavior) property
* [GridView.SaveLayoutToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.SaveLayoutToStream(System.IO.Stream)) method
* [GridView.RestoreLayoutFromStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.RestoreLayoutFromStream(System.IO.Stream)) method

See also:

* [Data Inspector](https://docs.devexpress.com/Dashboard/401194)