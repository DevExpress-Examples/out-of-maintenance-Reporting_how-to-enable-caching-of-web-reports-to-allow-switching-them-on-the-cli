<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span style="font-size: 10pt; font-family: Tahoma">Select a report to display:<br />
            </span></strong>
            <br />
            <dxe:ASPxComboBox id="ASPxComboBox1" runat="server">
<ClientSideEvents SelectedIndexChanged="function(s, e) {
                document.getElementById(&quot;hf&quot;).value = s.GetSelectedItem().value;
                DocumentViewer1.GetViewer().Refresh();
            }"></ClientSideEvents>
            <Items>
                <dxe:ListEditItem Text="First report" Value="1" />
                <dxe:ListEditItem Text="Second report" Value="2" />
            </Items>
            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                document.getElementById(&quot;hf&quot;).value = s.GetSelectedItem().value;
                DocumentViewer1.Refresh();
            }" />
        </dxe:ASPxComboBox>
            <br />
        </div>
        <dxxr:ASPxDocumentViewer Id="DocumentViewer1" runat="server" ClientInstanceName="DocumentViewer1" oncachereportdocument="DocumentViewer1_CacheReportDocument" OnRestoreReportDocumentFromCache="DocumentViewer1_RestoreReportDocumentFromCache">
            <ClientSideEvents PageLoad="function(s, e) { 
                        document.getElementById(&quot;hf&quot;).value = '';
                }" />
        </dxxr:ASPxDocumentViewer>
        <br />
        <asp:HiddenField ID="hf" runat="server" />
    </form>
</body>
</html>