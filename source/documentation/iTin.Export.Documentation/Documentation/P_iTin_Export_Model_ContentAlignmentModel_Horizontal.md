# ContentAlignmentModel.Horizontal Property 
Additional header content 

Gets or sets horizontal alignment.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownHorizontalAlignment Horizontal { get; set; }
```

**VB**<br />
``` VB
Public Property Horizontal As KnownHorizontalAlignment
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownHorizontalAlignment">KnownHorizontalAlignment</a><br />One of the <a href="T_iTin_Export_Model_KnownHorizontalAlignment">KnownHorizontalAlignment</a> values. The default is <a href="T_iTin_Export_Model_KnownHorizontalAlignment">Left</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Alignment Horizontal="Left|Center|Right" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new content. 
**XML**<br />
``` XML
<Content Color="DarkBlue">
  <Alignment Horizontal="Left"/>
  <Text/>
</Content>
```

**C#**<br />
``` C#
ContentModel content = new ContentModel
                           {
                               Color = "DarkBlue",
                               DataType = new TextDataTypeModel(),
                               Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
                           };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ContentAlignmentModel">ContentAlignmentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />