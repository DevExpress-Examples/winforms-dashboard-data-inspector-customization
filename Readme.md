<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/213673772/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828295)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# Dashboard for WinForms - How to Customize the Data Inspector Dialog

This example illustrates how to handle the DataInspectorFormLoad and DataInspectorFormClosing events to get access to the Grid controls in the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window and change the grid settings.

![](/images/screenshot.png)

## API

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

## Documentation

* [Data Inspector](https://docs.devexpress.com/Dashboard/401194)
* [Obtaining Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/creating-the-designer-and-viewer-applications/winforms-viewer/obtaining-underlying-and-displayed-data)

## More Examples

* [How to: Obtain a Dashboard Item's Client Data in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-obtain-a-dashboard-items-client-data-in-the-winforms-viewer-t140553)
* [How to: Add Custom Interactivity to a Dashboard Displayed in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-add-custom-interactivity-to-a-dashboard-displayed-in-the-winforms-viewer-t189795)
* [How to: Calculate and Display Totals for the Hidden Measure](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-display-hidden-field-totals)
* [How to: Display the Total Value above each Pie Chart in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-display-the-total-value-above-each-pie-chart)

