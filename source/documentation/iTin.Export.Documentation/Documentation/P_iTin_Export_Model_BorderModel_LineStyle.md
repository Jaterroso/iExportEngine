# BorderModel.LineStyle Property 
Additional header content 

Gets or sets preferred border line style.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownBorderLineStyle LineStyle { get; set; }
```

**VB**<br />
``` VB
Public Property LineStyle As KnownBorderLineStyle
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownBorderLineStyle">KnownBorderLineStyle</a><br />Preferred border line style. The default is None.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Border LineStyle="None|Continuous|Dash|Dot|DashDot|DashDotDot|SlantDashDot|Double" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new border. 
**XML**<br />
``` XML
<Border Position="Bottom" Color="Navy" LineStyle="Dash"/>
```

**C#**<br />
``` C#
BorderModel border = new BorderModel
                         {
                             Position = KnownBorderPosition.Bottom,
                             Color = "Navy",
                             LineStyle = KnownBorderLineStyle.Dash
                         };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BorderModel">BorderModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />