# GlobalResourcesModel.Conditions Property 
Additional header content 

Gets or sets the collection of user-defined conditions.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public ConditionsModel Conditions { get; set; }
```

**VB**<br />
``` VB
Public Property Conditions As ConditionsModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ConditionsModel">ConditionsModel</a><br />Collection of user-defined conditions.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Global.Resources>
  <Conditions .../>
  ...
</Global.Resources>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />