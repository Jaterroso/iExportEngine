# AxisDefinitionLabelsModel Class
Additional header content 

Represents the visual setting the labels of a axis.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(AxisDefinitionLabelsModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.AxisDefinitionLabelsModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class AxisDefinitionLabelsModel : BaseModel<AxisDefinitionLabelsModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class AxisDefinitionLabelsModel
	Inherits BaseModel(Of AxisDefinitionLabelsModel)
```

The AxisDefinitionLabelsModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_AxisDefinitionLabelsModel__ctor">AxisDefinitionLabelsModel</a></td><td>
Initializes a new instance of the AxisDefinitionLabelsModel class.</td></tr></table>&nbsp;
<a href="#axisdefinitionlabelsmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Alignment">Alignment</a></td><td>
Gets or sets preferred alignment for axis labels.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Font">Font</a></td><td>
Gets or sets a reference to the font model defined for this title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_IsDefault">IsDefault</a></td><td> (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Orientation">Orientation</a></td><td>
Gets or sets preferred orientation for axis labels.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Position">Position</a></td><td>
Gets or sets preferred position for axis labels.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#axisdefinitionlabelsmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#axisdefinitionlabelsmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Category`</strong>, or <strong>`Values`</strong>. For more information, please see <a href="T_iTin_Export_Model_AxisDefinitionModel">AxisDefinitionModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Labels>
  <Font/>
<Labels>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Orientation">Orientation</a></td><td align="center">Yes</td><td>Preferred orientation for axis labels. The default is <a href="T_iTin_Export_Model_KnownLabelOrientation">Automatic</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Position">Position</a></td><td align="center">Yes</td><td>Preferred position for axis labels. The default is <a href="T_iTin_Export_Model_KnownLabelPosition">Low</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Alignment">Alignment</a></td><td align="center">Yes</td><td>Preferred alignment for axis label. The default is <a href="T_iTin_Export_Model_KnownHorizontalAlignment">Center</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionLabelsModel_Font">Font</a></td><td>Reference to font model defined for axis labels.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />