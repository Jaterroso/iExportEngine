# BaseModel(*T*).LoadFromFile Method (String, *T*, Exception)
Additional header content 

Deserializes xml markup from file into an BaseModel object

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public static bool LoadFromFile(
	string fileName,
	out T obj,
	out Exception exception
)
```

**VB**<br />
``` VB
Public Shared Function LoadFromFile ( 
	fileName As String,
	<OutAttribute> ByRef obj As T,
	<OutAttribute> ByRef exception As Exception
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>fileName</dt><dd>Type: System.String<br />string xml file to load and deserialize</dd><dt>obj</dt><dd>Type: <a href="T_iTin_Export_Model_BaseModel_1">*T*</a><br />Output BaseModel object</dd><dt>exception</dt><dd>Type: System.Exception<br />output Exception value if deserialize failed</dd></dl>

#### Return Value
Type: Boolean<br /><strong>true</strong> if this XmlSerializer can deserialize the object; otherwise, <strong>false</strong>.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseModel`1.LoadFromFile(System.String,`0@,System.Exception@)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T) Class</a><br /><a href="Overload_iTin_Export_Model_BaseModel_1_LoadFromFile">LoadFromFile Overload</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />