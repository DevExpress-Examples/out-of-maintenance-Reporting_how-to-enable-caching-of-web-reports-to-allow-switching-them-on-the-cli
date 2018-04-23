Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Me.IsCallback AndAlso Me.hf.Value <> String.Empty Then
			If hf.Value = "1" Then
				Dim r As New XtraReport1()
				Me.ReportViewer1.Report = r
				Me.ReportViewer1.DataBind()
				Page.Session("2") = Nothing
			ElseIf hf.Value = "2" Then
				Dim r As New XtraReport2()
				Me.ReportViewer1.Report = r
				Me.ReportViewer1.DataBind()
				Page.Session("1") = Nothing
			End If
		End If
	End Sub
	Protected Sub ReportViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.CacheReportDocumentEventArgs)
		e.Key = Me.hf.Value
		Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
	End Sub
	Protected Sub ReportViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.RestoreReportDocumentFromCacheEventArgs)
		Dim stream As Stream = TryCast(Page.Session(e.Key), Stream)
		If stream IsNot Nothing Then
			e.RestoreDocumentFromStream(stream)
		End If
	End Sub
End Class
