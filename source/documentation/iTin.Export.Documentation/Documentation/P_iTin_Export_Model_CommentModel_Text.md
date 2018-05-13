# CommentModel.Text Property 
Additional header content 

Gets or sets the comment text.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Text { get; set; }
```

**VB**<br />
``` VB
Public Property Text As String
	Get
	Set
```


#### Property Value
Type: String<br />The comment text.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Comment .../>
  <Text>string</Text>
  ...
</Comment>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_CommentModel">CommentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />