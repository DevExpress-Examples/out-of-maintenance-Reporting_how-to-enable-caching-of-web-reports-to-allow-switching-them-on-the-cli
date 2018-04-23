<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v10.2.Web, Version=10.2.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.2, Version=10.2.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 10pt; font-family: Tahoma">Select a report to display:<br />
        </span></strong>
        <br />
        <dxe:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String">
            <Items>
                <dxe:ListEditItem Text="First report" Value="1" />
                <dxe:ListEditItem Text="Second report" Value="2" />
            </Items>
            <ClientSideEvents SelectedIndexChanged="function(s, e) {
            	document.getElementById(&quot;hf&quot;).value = s.GetSelectedItem().value;
                viewer.Refresh();
            }" />
        </dxe:ASPxComboBox>
        <br />
        <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer1 %>"
            ShowDefaultButtons="False">
            <Items>
                <dxxr:ReportToolbarButton ItemKind="Search" />
                <dxxr:ReportToolbarSeparator />
                <dxxr:ReportToolbarButton ItemKind="PrintReport" />
                <dxxr:ReportToolbarButton ItemKind="PrintPage" />
                <dxxr:ReportToolbarSeparator />
                <dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dxxr:ReportToolbarLabel ItemKind="PageLabel" />
                <dxxr:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dxxr:ReportToolbarComboBox>
                <dxxr:ReportToolbarLabel ItemKind="OfLabel" />
                <dxxr:ReportToolbarTextBox ItemKind="PageCount" />
                <dxxr:ReportToolbarButton ItemKind="NextPage" />
                <dxxr:ReportToolbarButton ItemKind="LastPage" />
                <dxxr:ReportToolbarSeparator />
                <dxxr:ReportToolbarButton ItemKind="SaveToDisk" />
                <dxxr:ReportToolbarButton ItemKind="SaveToWindow" />
                <dxxr:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dxxr:ListElement Value="pdf" />
                        <dxxr:ListElement Value="xls" />
                        <dxxr:ListElement Value="xlsx" />
                        <dxxr:ListElement Value="rtf" />
                        <dxxr:ListElement Value="mht" />
                        <dxxr:ListElement Value="txt" />
                        <dxxr:ListElement Value="csv" />
                        <dxxr:ListElement Value="png" />
                    </Elements>
                </dxxr:ReportToolbarComboBox>
            </Items>
            <Styles>
                <LabelStyle>
                    <Margins MarginLeft="3px" MarginRight="3px" />
                </LabelStyle>
            </Styles>
        </dxxr:ReportToolbar>
    </div>
        <dxxr:ReportViewer ID="ReportViewer1" runat="server" ClientInstanceName="viewer" OnCacheReportDocument="ReportViewer1_CacheReportDocument" OnRestoreReportDocumentFromCache="ReportViewer1_RestoreReportDocumentFromCache">
            <ClientSideEvents PageLoad="function(s, e) { 
						document.getElementById(&quot;hf&quot;).value = '';
            	}" />
        </dxxr:ReportViewer>
        <br />
        <asp:HiddenField ID="hf" runat="server" />
    </form>
</body>
</html>
