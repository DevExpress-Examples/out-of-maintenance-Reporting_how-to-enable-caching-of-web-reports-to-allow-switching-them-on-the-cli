using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport2
/// </summary>
public class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
	private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private DataSet1 dataSet11;
    private DataSet1TableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport2()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "XtraReport2.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.dataSet11 = new DataSet1();
        this.order_DetailsTableAdapter1 = new DataSet1TableAdapters.Order_DetailsTableAdapter();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4});
        this.Detail.Height = 25;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // PageHeader
        // 
        this.PageHeader.Height = 30;
        this.PageHeader.Name = "PageHeader";
        this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // PageFooter
        // 
        this.PageFooter.Height = 30;
        this.PageFooter.Name = "PageFooter";
        this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // dataSet11
        // 
        this.dataSet11.DataSetName = "DataSet1";
        this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // order_DetailsTableAdapter1
        // 
        this.order_DetailsTableAdapter1.ClearBeforeFill = true;
        // 
        // xrLabel1
        // 
        this.xrLabel1.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.OrderID")});
        this.xrLabel1.Location = new System.Drawing.Point(92, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel1.Size = new System.Drawing.Size(100, 25);
        this.xrLabel1.StylePriority.UseBackColor = false;
        this.xrLabel1.Text = "xrLabel1";
        // 
        // xrLabel2
        // 
        this.xrLabel2.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.ProductID")});
        this.xrLabel2.Location = new System.Drawing.Point(225, 0);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel2.Size = new System.Drawing.Size(100, 25);
        this.xrLabel2.StylePriority.UseBackColor = false;
        this.xrLabel2.Text = "xrLabel2";
        // 
        // xrLabel3
        // 
        this.xrLabel3.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.Quantity")});
        this.xrLabel3.Location = new System.Drawing.Point(350, 0);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel3.Size = new System.Drawing.Size(100, 25);
        this.xrLabel3.StylePriority.UseBackColor = false;
        this.xrLabel3.Text = "xrLabel3";
        // 
        // xrLabel4
        // 
        this.xrLabel4.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.UnitPrice")});
        this.xrLabel4.Location = new System.Drawing.Point(467, 0);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel4.Size = new System.Drawing.Size(100, 25);
        this.xrLabel4.StylePriority.UseBackColor = false;
        this.xrLabel4.Text = "xrLabel4";
        // 
        // XtraReport2
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
        this.DataAdapter = this.order_DetailsTableAdapter1;
        this.DataMember = "Order Details";
        this.DataSource = this.dataSet11;
        this.Version = "9.2";
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
