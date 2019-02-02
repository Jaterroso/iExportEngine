# AxisDefinitionMarksModel.Minor Property 
Additional header content 

Gets or sets a value indicating the position of minor tick marks for an axis.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownTickMarkStyle Minor { get; set; }
```

**VB**<br />
``` VB
Public Property Minor As KnownTickMarkStyle
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownTickMarkStyle">KnownTickMarkStyle</a><br />Position of minor tick marks for an axis. The default is <a href="T_iTin_Export_Model_KnownTickMarkStyle">Cross</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Marks Minor="None|Cross|Inside|Outside" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_AxisDefinitionMarksModel">AxisDefinitionMarksModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />