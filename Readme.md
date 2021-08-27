<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600663/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2079)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [XtraReport2.cs](./CS/WebSite/App_Code/XtraReport2.cs) (VB: [XtraReport2.vb](./VB/WebSite/App_Code/XtraReport2.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to enable caching of web reports to allow switching them on the client


<p>The code in this example implements the native caching of web reports displayed by the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> control which allows instantly switching the documents that are cached on the client.</p><p>During the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsScriptsASPxClientComboBox_SelectedIndexChangedtopic"><u>ASPxClientComboBox.SelectedIndexChanged</u></a> event, the <strong>HiddenField</strong> value is used to identify a report before its initialization that is performed within the <strong>Page_Load</strong> event handler.</p>

<br/>


