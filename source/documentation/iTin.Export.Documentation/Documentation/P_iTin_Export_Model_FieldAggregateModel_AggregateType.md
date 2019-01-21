# FieldAggregateModel.AggregateType Property 
Additional header content 

Gets or sets preferred location in which to add the aggregate.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownAggregateType AggregateType { get; set; }
```

**VB**<br />
``` VB
Public Property AggregateType As KnownAggregateType
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownAggregateType">KnownAggregateType</a><br />One <a href="T_iTin_Export_Model_KnownAggregateType">KnownAggregateType</a> value. Preferred type of aggregate that will generate. The default is <a href="T_iTin_Export_Model_KnownAggregateType">None</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Aggregate Type="None|Average|Count|Max|Min|Sum|Text" ...>
...
</Aggregate>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_FieldAggregateModel">FieldAggregateModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />