# FieldAggregateModel.Text Property 
Additional header content 

Gets or sets preferred text for this aggregate.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

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
Type: String<br />Preferred text for this aggregate. If aggregate is of text type then this attribute specifies preferred text for this aggregate. The default is "`Total`".

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Aggregate Text="string" ...>
...
</Aggregate>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_FieldAggregateModel">FieldAggregateModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />