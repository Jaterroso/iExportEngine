# ChartLegendModel.Location Property 
Additional header content 

Gets or sets preferred location for chart legend.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownLegendLocation Location { get; set; }
```

**VB**<br />
``` VB
Public Property Location As KnownLegendLocation
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownLegendLocation">KnownLegendLocation</a><br />Preferred location for chart legend. The default is <a href="T_iTin_Export_Model_KnownLegendLocation">Right</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Legend Location="Top|Right|Bottom|Left" ...>
  ...
</Legend>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartLegendModel">ChartLegendModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />