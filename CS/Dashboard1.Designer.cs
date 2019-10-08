﻿namespace DataInspectorCustomizationExample {
    partial class SampleDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ValueMap valueMap1 = new DevExpress.DashboardCommon.ValueMap();
            DevExpress.DashboardCommon.UniformScale uniformScale1 = new DevExpress.DashboardCommon.UniformScale();
            DevExpress.DashboardCommon.DeltaMap deltaMap1 = new DevExpress.DashboardCommon.DeltaMap();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleDashboard));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDeltaColumn gridDeltaColumn1 = new DevExpress.DashboardCommon.GridDeltaColumn();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.choroplethMapDashboardItem1 = new DevExpress.DashboardCommon.ChoroplethMapDashboardItem();
            this.dashboardExcelDataSource1 = new DevExpress.DashboardCommon.DashboardExcelDataSource();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // choroplethMapDashboardItem1
            // 
            this.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA;
            dimension1.DataMember = "State";
            this.choroplethMapDashboardItem1.AttributeDimension = dimension1;
            this.choroplethMapDashboardItem1.AttributeName = "NAME";
            this.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1";
            measure1.DataMember = "RevenueYTD (Sum)";
            measure2.DataMember = "RevenueYTD (Sum)";
            measure3.DataMember = "RevenueYTDTarget (Sum)";
            this.choroplethMapDashboardItem1.DataItemRepository.Clear();
            this.choroplethMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem3");
            this.choroplethMapDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            valueMap1.Name = "Revenue YTD";
            valueMap1.Scale = uniformScale1;
            valueMap1.ValueName = "Revenue";
            valueMap1.AddDataItem("Value", measure1);
            deltaMap1.ActualValueName = "Revenue";
            deltaMap1.DeltaName = "vs Target";
            deltaMap1.Name = "Revenue YTD vs Target";
            deltaMap1.AddDataItem("ActualValue", measure2);
            deltaMap1.AddDataItem("TargetValue", measure3);
            this.choroplethMapDashboardItem1.Maps.AddRange(new DevExpress.DashboardCommon.ChoroplethMap[] {
            valueMap1,
            deltaMap1});
            this.choroplethMapDashboardItem1.Name = "Sales by State";
            this.choroplethMapDashboardItem1.ShapeTitleAttributeName = "ABBREV";
            this.choroplethMapDashboardItem1.ShowCaption = true;
            this.choroplethMapDashboardItem1.Viewport.BottomLatitude = 25.31399686804809D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.298652216525717D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -99.1736207753099D;
            this.choroplethMapDashboardItem1.Viewport.CreateViewerPaddings = false;
            this.choroplethMapDashboardItem1.Viewport.LeftLongitude = -114.64010379808356D;
            this.choroplethMapDashboardItem1.Viewport.RightLongitude = -83.707137752536212D;
            this.choroplethMapDashboardItem1.Viewport.TopLatitude = 47.640614567674412D;
            // 
            // dashboardExcelDataSource1
            // 
            this.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1";
            this.dashboardExcelDataSource1.FileName = "|DataDirectory|\\Data\\Sales.xlsx";
            this.dashboardExcelDataSource1.Name = "Excel Data Source 1";
            this.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "Category";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Product";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "State";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "UnitsSoldYTD (Sum)";
            fieldInfo4.Type = typeof(double);
            fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "RevenueQTD (Sum)";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "RevenueQTDTarget (Sum)";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "RevenueYTD (Sum)";
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "RevenueYTDTarget (Sum)";
            fieldInfo9.Type = typeof(double);
            this.dashboardExcelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // gridDashboardItem1
            // 
            dimension2.DataMember = "Category";
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension2);
            dimension3.DataMember = "Product";
            gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn2.AddDataItem("Dimension", dimension3);
            measure4.DataMember = "UnitsSoldYTD (Sum)";
            measure5.DataMember = "UnitsSoldYTDTarget (Sum)";
            gridDeltaColumn1.Name = "UnitsSold YTD vs Target";
            gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDeltaColumn1.AddDataItem("ActualValue", measure4);
            gridDeltaColumn1.AddDataItem("TargetValue", measure5);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridDimensionColumn2,
            gridDeltaColumn1});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(measure4, "DataItem1");
            this.gridDashboardItem1.DataItemRepository.Add(measure5, "DataItem2");
            this.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem3");
            this.gridDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Product Units Sold";
            this.gridDashboardItem1.ShowCaption = true;
            // 
            // SampleDashboard
            // 
            this.CurrencyCultureName = null;
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExcelDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.choroplethMapDashboardItem1,
            this.gridDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.choroplethMapDashboardItem1;
            dashboardLayoutItem1.Weight = 53.152039555006183D;
            dashboardLayoutItem2.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem2.Weight = 46.847960444993817D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sample Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChoroplethMapDashboardItem choroplethMapDashboardItem1;
        private DevExpress.DashboardCommon.DashboardExcelDataSource dashboardExcelDataSource1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
    }
}