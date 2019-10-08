Namespace DataInspectorCustomizationExample
	Partial Public Class SampleDashboard
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim valueMap1 As New DevExpress.DashboardCommon.ValueMap()
			Dim uniformScale1 As New DevExpress.DashboardCommon.UniformScale()
			Dim deltaMap1 As New DevExpress.DashboardCommon.DeltaMap()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SampleDashboard))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn2 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.choroplethMapDashboardItem1 = New DevExpress.DashboardCommon.ChoroplethMapDashboardItem()
			Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
			Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' choroplethMapDashboardItem1
			' 
			Me.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA
			dimension1.DataMember = "State"
			Me.choroplethMapDashboardItem1.AttributeDimension = dimension1
			Me.choroplethMapDashboardItem1.AttributeName = "NAME"
			Me.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1"
			measure1.DataMember = "RevenueYTD (Sum)"
			measure2.DataMember = "RevenueYTD (Sum)"
			measure3.DataMember = "RevenueYTDTarget (Sum)"
			Me.choroplethMapDashboardItem1.DataItemRepository.Clear()
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
			Me.choroplethMapDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			valueMap1.Name = "Revenue YTD"
			valueMap1.Scale = uniformScale1
			valueMap1.ValueName = "Revenue"
			valueMap1.AddDataItem("Value", measure1)
			deltaMap1.ActualValueName = "Revenue"
			deltaMap1.DeltaName = "vs Target"
			deltaMap1.Name = "Revenue YTD vs Target"
			deltaMap1.AddDataItem("ActualValue", measure2)
			deltaMap1.AddDataItem("TargetValue", measure3)
			Me.choroplethMapDashboardItem1.Maps.AddRange(New DevExpress.DashboardCommon.ChoroplethMap() { valueMap1, deltaMap1})
			Me.choroplethMapDashboardItem1.Name = "Sales by State"
			Me.choroplethMapDashboardItem1.ShapeTitleAttributeName = "ABBREV"
			Me.choroplethMapDashboardItem1.ShowCaption = True
			Me.choroplethMapDashboardItem1.Viewport.BottomLatitude = 25.31399686804809R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.298652216525717R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -99.1736207753099R
			Me.choroplethMapDashboardItem1.Viewport.CreateViewerPaddings = False
			Me.choroplethMapDashboardItem1.Viewport.LeftLongitude = -114.64010379808356R
			Me.choroplethMapDashboardItem1.Viewport.RightLongitude = -83.707137752536212R
			Me.choroplethMapDashboardItem1.Viewport.TopLatitude = 47.640614567674412R
			' 
			' dashboardExcelDataSource1
			' 
			Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
			Me.dashboardExcelDataSource1.FileName = "|DataDirectory|\Data\Sales.xlsx"
			Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
			Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "Category"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Product"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "State"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "UnitsSoldYTD (Sum)"
			fieldInfo4.Type = GetType(Double)
			fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
			fieldInfo5.Type = GetType(Double)
			fieldInfo6.Name = "RevenueQTD (Sum)"
			fieldInfo6.Type = GetType(Double)
			fieldInfo7.Name = "RevenueQTDTarget (Sum)"
			fieldInfo7.Type = GetType(Double)
			fieldInfo8.Name = "RevenueYTD (Sum)"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "RevenueYTDTarget (Sum)"
			fieldInfo9.Type = GetType(Double)
			Me.dashboardExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Sheet1"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' gridDashboardItem1
			' 
			dimension2.DataMember = "Category"
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension2)
			dimension3.DataMember = "Product"
			gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn2.AddDataItem("Dimension", dimension3)
			measure4.DataMember = "UnitsSoldYTD (Sum)"
			measure5.DataMember = "UnitsSoldYTDTarget (Sum)"
			gridDeltaColumn1.Name = "UnitsSold YTD vs Target"
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure4)
			gridDeltaColumn1.AddDataItem("TargetValue", measure5)
			Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDimensionColumn2, gridDeltaColumn1})
			Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
			Me.gridDashboardItem1.DataItemRepository.Clear()
			Me.gridDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0")
			Me.gridDashboardItem1.DataItemRepository.Add(measure4, "DataItem1")
			Me.gridDashboardItem1.DataItemRepository.Add(measure5, "DataItem2")
			Me.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem3")
			Me.gridDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridDashboardItem1.Name = "Product Units Sold"
			Me.gridDashboardItem1.ShowCaption = True
			' 
			' SampleDashboard
			' 
			Me.CurrencyCultureName = Nothing
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExcelDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.choroplethMapDashboardItem1, Me.gridDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.choroplethMapDashboardItem1
			dashboardLayoutItem1.Weight = 53.152039555006183R
			dashboardLayoutItem2.DashboardItem = Me.gridDashboardItem1
			dashboardLayoutItem2.Weight = 46.847960444993817R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sample Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private choroplethMapDashboardItem1 As DevExpress.DashboardCommon.ChoroplethMapDashboardItem
		Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource
		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
	End Class
End Namespace
