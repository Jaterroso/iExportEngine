# PieceModel.TrimMode Property 
Additional header content 

Gets or sets a value that determines trim mode for strings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownTrimMode TrimMode { get; set; }
```

**VB**<br />
``` VB
Public Property TrimMode As KnownTrimMode
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownTrimMode">KnownTrimMode</a><br />One of the <a href="T_iTin_Export_Model_KnownTrimMode">KnownTrimMode</a> values. The default is <a href="T_iTin_Export_Model_KnownTrimMode">All</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Piece TrimMode="All|Start|End" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
Suppose we have the following input data: 
**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>
<ARD740>
  <R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... />
  <R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... />
  ...
  ...
</ARD740>
```

Now we create the collection of pieces:

**XML**<br />
``` XML
<Pieces Name="SFLDTA_Pieces" Reference="SFLDTA">
  <Piece Name="DCALL" From="0" Lenght="2"/>
  <Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/>
  <Piece Name="SHOP" From="18" Lenght="10"/>
  <Piece Name="SIT" From="28" Lenght="10"/>
  <Piece Name="PIK" From="38" Lenght="5"/>
  <Piece Name="PKG" From="48" Lenght="5"/>
  <Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/>
</Pieces>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_PieceModel">PieceModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />