﻿Namespace SendReportWithMailKit
    Partial Public Class XtraReport1
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

#Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
            Me.ReportHeader.HeightF = 60.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 28.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            '
            'pageInfo1
            '
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(325.0!, 23.0!)
            Me.pageInfo1.StyleName = "PageInfo"
            '
            'pageInfo2
            '
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0!)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(325.0!, 23.0!)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            '
            'label1
            '
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(650.0!, 24.19433!)
            Me.label1.StyleName = "Title"
            Me.label1.Text = "Report Title"
            '
            'table1
            '
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650.0!, 28.0!)
            '
            'tableRow1
            '
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1.0R
            '
            'tableCell1
            '
            Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "DetailCaption1"
            Me.tableCell1.StylePriority.UseBorders = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            Me.tableCell1.Text = "Category ID"
            Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell1.Weight = 0.25569842998798076R
            '
            'tableCell2
            '
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "DetailCaption1"
            Me.tableCell2.Text = "Category Name"
            Me.tableCell2.Weight = 0.32011953500600959R
            '
            'tableCell3
            '
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "DetailCaption1"
            Me.tableCell3.Text = "Description"
            Me.tableCell3.Weight = 0.25153752253605771R
            '
            'tableCell4
            '
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "DetailCaption1"
            Me.tableCell4.Text = "Picture"
            Me.tableCell4.Weight = 0.17264447725736179R
            '
            'table2
            '
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.table2.Name = "table2"
            Me.table2.OddStyleName = "DetailData3_Odd"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            '
            'tableRow2
            '
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 11.5R
            '
            'tableCell5
            '
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "DetailData1"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.StylePriority.UseTextAlignment = False
            Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell5.Weight = 0.25569842998798076R
            '
            'tableCell6
            '
            Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "DetailData1"
            Me.tableCell6.Weight = 0.32011953500600959R
            '
            'tableCell7
            '
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailData1"
            Me.tableCell7.Weight = 0.25153752253605771R
            '
            'tableCell8
            '
            Me.tableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData1"
            Me.tableCell8.Weight = 0.17264451246995191R
            '
            'pictureBox1
            '
            Me.pictureBox1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pictureBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333!, 0!)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(110.1356!, 25.0!)
            Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            '
            'SqlDataSource1
            '
            Me.SqlDataSource1.ConnectionName = "nwind"
            Me.SqlDataSource1.Name = "SqlDataSource1"
            ColumnExpression1.ColumnName = "CategoryID"
            Table3.Name = "Categories"
            ColumnExpression1.Table = Table3
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "CategoryName"
            ColumnExpression2.Table = Table3
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "Description"
            ColumnExpression3.Table = Table3
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Picture"
            ColumnExpression4.Table = Table3
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "Icon17"
            ColumnExpression5.Table = Table3
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "Icon25"
            ColumnExpression6.Table = Table3
            Column6.Expression = ColumnExpression6
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Name = "Categories"
            SelectQuery1.Tables.Add(Table3)
            Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
            '
            'Title
            '
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1.0!
            Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.Title.Name = "Title"
            Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            '
            'DetailCaption1
            '
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2.0!
            Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'DetailData1
            '
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2.0!
            Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25!)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'DetailData3_Odd
            '
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1.0!
            Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25!)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'PageInfo
            '
            Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.SqlDataSource1
            Me.ExportOptions.Email.RecipientAddress = "john.doe@test.com"
            Me.ExportOptions.Email.RecipientName = "John Doe"
            Me.ExportOptions.Email.Subject = "Test"
            Me.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "21.2"
            CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle

#End Region
    End Class
End Namespace
