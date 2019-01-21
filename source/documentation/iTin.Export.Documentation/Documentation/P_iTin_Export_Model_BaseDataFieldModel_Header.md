# BaseDataFieldModel.Header Property 
Additional header content 

Gets or sets a reference that contains the visual setting of header the data field.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public FieldHeaderModel Header { get; set; }
```

**VB**<br />
``` VB
Public Property Header As FieldHeaderModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_FieldHeaderModel">FieldHeaderModel</a><br />Visual setting of header the data field.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Field|Fixed|Gap|Group ...>
   <Header .../>
  ...
</Field|Fixed|Gap|Group>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a data field. 
**XML**<br />
``` XML
<Field Name="##LINE" Alias="Line">
  <Header Style="CommonHeader" Show="Yes"/>
  <Value Style="LineValue"/>
  <Aggregate Style="TopAggregate" Type="Count" Location="Top" Show="Yes"/>
</Field>
```

**C#**<br />
``` C#
DataFieldModel lineField = new DataFieldModel
                               {
                                   Name = "##LINE",
                                   Alias = "Line",
                                   Value = new FieldValueModel { Style = "LineValue" },
                                   Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
                                   Aggregate = new FieldAggregateModel
                                                   {
                                                       Show = YesNo.Yes,
                                                       Style = "TopAggregate", 
                                                       Location = KnownAggregateLocation.Top,
                                                       AggregateType = KnownAggregateType.Count,
                                                   },
                               };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />