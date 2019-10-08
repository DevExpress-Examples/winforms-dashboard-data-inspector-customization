Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DashboardWin
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DataInspectorCustomizationExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private aggregatedGridLayoutDictionary As New Dictionary(Of String, Stream)()
		Private rawGridLayoutDictionary As New Dictionary(Of String, Stream)()
		Public Sub New()
			InitializeComponent()
			dashboardViewer1.AllowInspectAggregatedData = True
			dashboardViewer1.AllowInspectRawData = True
			AddHandler dashboardViewer1.DataInspectorFormLoad, AddressOf DashboardViewer1_DataInspectorFormLoad
			AddHandler dashboardViewer1.DataInspectorFormClosing, AddressOf DashboardViewer1_DataInspectorFormClosing
		End Sub

		Private Sub DashboardViewer1_DataInspectorFormClosing(ByVal sender As Object, ByVal e As DataInspectorFormClosingEventArgs)
			SaveGridLayout(e.DashboardItemName, e.AggregatedGrid.FocusedView, aggregatedGridLayoutDictionary)
			SaveGridLayout(e.DashboardItemName, e.RawGrid.FocusedView, rawGridLayoutDictionary)
		End Sub
		Private Sub DashboardViewer1_DataInspectorFormLoad(ByVal sender As Object, ByVal e As DataInspectorFormLoadEventArgs)
			CustomizeGrid(e.AggregatedGrid)
			CustomizeGrid(e.RawGrid)

			RestoreGridLayout(e.DashboardItemName, e.AggregatedGrid.FocusedView, aggregatedGridLayoutDictionary)
			RestoreGridLayout(e.DashboardItemName, e.RawGrid.FocusedView, rawGridLayoutDictionary)
		End Sub
		Private Sub CustomizeGrid(ByVal grid As GridControl)
			Dim view As GridView = TryCast(grid.MainView, GridView)
			view.OptionsCustomization.AllowGroup = True
			view.OptionsView.ShowGroupPanel = True
			view.OptionsBehavior.AutoExpandAllGroups = True
		End Sub
		Private Sub SaveGridLayout(ByVal itemName As String, ByVal gridView As BaseView, ByVal layouts As Dictionary(Of String, Stream))
			Dim str As New MemoryStream()
			gridView.SaveLayoutToStream(str)
			layouts(itemName) = str
			str.Seek(0, SeekOrigin.Begin)
		End Sub
		Private Sub RestoreGridLayout(ByVal itemName As String, ByVal gridView As BaseView, ByVal layouts As Dictionary(Of String, Stream))
			Dim stream As Stream = Nothing
			If layouts.TryGetValue(itemName, stream) Then
				gridView.RestoreLayoutFromStream(stream)
				stream.Seek(0, System.IO.SeekOrigin.Begin)
			End If
		End Sub
	End Class
End Namespace
