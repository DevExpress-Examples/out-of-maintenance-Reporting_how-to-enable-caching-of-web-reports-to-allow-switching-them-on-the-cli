Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrLabel1 As XRLabel
	Private xrLabel2 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrLabel4 As XRLabel
	Private dataSet11 As DataSet1
	Private ordersTableAdapter1 As DataSet1TableAdapters.OrdersTableAdapter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.dataSet11 = New DataSet1()
		Me.ordersTableAdapter1 = New DataSet1TableAdapters.OrdersTableAdapter()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4})
		Me.Detail.Height = 25
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' PageHeader
		' 
		Me.PageHeader.Height = 30
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' PageFooter
		' 
		Me.PageFooter.Height = 30
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' ordersTableAdapter1
		' 
		Me.ordersTableAdapter1.ClearBeforeFill = True
		' 
		' xrLabel1
		' 
		Me.xrLabel1.BackColor = System.Drawing.Color.LightBlue
		Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
		Me.xrLabel1.Location = New System.Drawing.Point(33, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
		Me.xrLabel1.StylePriority.UseBackColor = False
		Me.xrLabel1.Text = "xrLabel1"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.BackColor = System.Drawing.Color.LightBlue
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate")})
		Me.xrLabel2.Location = New System.Drawing.Point(150, 0)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.Size = New System.Drawing.Size(242, 25)
		Me.xrLabel2.StylePriority.UseBackColor = False
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' xrLabel3
		' 
		Me.xrLabel3.BackColor = System.Drawing.Color.LightBlue
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.CustomerID")})
		Me.xrLabel3.Location = New System.Drawing.Point(417, 0)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.Size = New System.Drawing.Size(100, 25)
		Me.xrLabel3.StylePriority.UseBackColor = False
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrLabel4
		' 
		Me.xrLabel4.BackColor = System.Drawing.Color.LightBlue
		Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Freight")})
		Me.xrLabel4.Location = New System.Drawing.Point(542, 0)
		Me.xrLabel4.Name = "xrLabel4"
		Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel4.Size = New System.Drawing.Size(100, 25)
		Me.xrLabel4.StylePriority.UseBackColor = False
		Me.xrLabel4.Text = "xrLabel4"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.DataAdapter = Me.ordersTableAdapter1
		Me.DataMember = "Orders"
		Me.DataSource = Me.dataSet11
		Me.Version = "9.2"
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
