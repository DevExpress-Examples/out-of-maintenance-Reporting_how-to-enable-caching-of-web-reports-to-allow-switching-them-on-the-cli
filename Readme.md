# How to enable caching of web reports to allow switching them on the client


<p>The code in this example implements the native caching of web reports displayed by the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> control which allows instantly switching the documents that are cached on the client.</p><p>During the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsScriptsASPxClientComboBox_SelectedIndexChangedtopic"><u>ASPxClientComboBox.SelectedIndexChanged</u></a> event, the <strong>HiddenField</strong> value is used to identify a report before its initialization that is performed within the <strong>Page_Load</strong> event handler.</p>

<br/>


