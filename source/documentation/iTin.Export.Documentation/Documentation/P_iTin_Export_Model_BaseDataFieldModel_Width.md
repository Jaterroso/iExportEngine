# BaseDataFieldModel.Width Property 
Additional header content 

Gets or sets the preferred width of field, indicate a size as multiply of 100 (ex. 9.3 => 930). The default is 'Default'.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Width { get; set; }
```

**VB**<br />
``` VB
Public Property Width As String
	Get
	Set
```


#### Property Value
Type: String<br />A String that represents a size as multiply of 100 (ex. 9.3 => 930).

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Field|Fixed|Gap|Group Width="Default|BestFit|A number as multiply of 100" ...>
  ...
</Field|Fixed|Gap|Group>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**ITEE Object Element Usage**<br />
``` XML
<Field Name="##LINE" Alias="Line" Width="BestFit">
...
</Field>
```

**C#**<br />
``` C#
DataFieldModel lineField = new DataFieldModel
                           {
                               Name = "##LINE",
                               Alias = "Line",
                               Width = "BestFit",
                               Value = new FieldValueModel { Style = "LineValue" },
                               Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
                               Aggregate = new FieldAggregateModel
                               {
                                   Show = YesNo.Yes,
                                   Style = "TopAggregate", 
                                   Location = KnownAggregateLocation.Top,
                                   AggregateType = KnownAggregateType.Count,
                               }
                           };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />