# Dashboard for WinForms - How to Customize the Data Inspector Dialog

This example illustrates how to handle the `DataInspectorFormLoad` and `DataInspectorFormClosing` events to get access to the Grid controls in the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window and change the grid settings.

![Dashboard for WinForms - Data Inspector Cuatomization](/images/screenshot.png)

## Files to Look At:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## Documentation

* [Manage Data Inspector in the WinForms Viewer](https://docs.devexpress.com/Dashboard/403975/winforms-dashboard/winforms-viewer/manage-data-inspector-in-win-forms-viewer)
* [Obtaining Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/creating-the-designer-and-viewer-applications/winforms-viewer/obtaining-underlying-and-displayed-data)

## API

* The [DashboardViewer.DataInspectorFormLoad](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataInspectorFormLoad) event.
* The [DashboardViewer.DataInspectorFormClosing](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataInspectorFormClosing) event.
* The [DataInspectorFormLoadEventArgs.AggregatedGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormLoadEventArgs.AggregatedGrid) property.
* The [DataInspectorFormClosingEventArgs.AggregatedGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormClosingEventArgs.AggregatedGrid) property.
* The [DataInspectorFormLoadEventArgs.RawGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormLoadEventArgs.RawGrid) property.
* The [DataInspectorFormClosingEventArgs.RawGrid](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DataInspectorFormClosingEventArgs.RawGrid) property.
* The [GridView.OptionsCustomization](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsCustomization) property.
* The [GridView.OptionsView](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsView) property.
* The [GridView.OptionsBehavior](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsBehavior) property.
* The [GridView.SaveLayoutToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.SaveLayoutToStream(System.IO.Stream)) method.
* The [GridView.RestoreLayoutFromStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.RestoreLayoutFromStream(System.IO.Stream)) method.

## More Examples

* [Dashboard for WinForms - How to Get and Process the Dashboard Item's Client Data](https://github.com/DevExpress-Examples/how-to-obtain-a-dashboard-items-client-data-in-the-winforms-viewer-t140553)
* [Dashboard for WinForms - How to Implement Custom Interactivity](https://github.com/DevExpress-Examples/how-to-add-custom-interactivity-to-a-dashboard-displayed-in-the-winforms-viewer-t189795)
* [Dashboard for WinForms - How to calculate and display totals for the hidden measure](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-display-hidden-field-totals)
* [Dashboard for WinForms - How to Display the Total Value Above Each Pie Chart](https://github.com/DevExpress-Examples/how-to-display-the-total-value-above-each-pie-chart)

