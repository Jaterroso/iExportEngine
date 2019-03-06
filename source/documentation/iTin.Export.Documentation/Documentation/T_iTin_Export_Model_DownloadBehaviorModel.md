# DownloadBehaviorModel Class
Additional header content 

A Specialization of <a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a> class.<br /> Which represents download behavior. Applies only in web mode.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseBehaviorModel">iTin.Export.Model.BaseBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.DownloadBehaviorModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class DownloadBehaviorModel : BaseBehaviorModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class DownloadBehaviorModel
	Inherits BaseBehaviorModel
```

The DownloadBehaviorModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DownloadBehaviorModel__ctor">DownloadBehaviorModel</a></td><td>
Initializes a new instance of the DownloadBehaviorModel class.</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseBehaviorModel_CanExecute">CanExecute</a></td><td>
Gets or sets a value indicating whether executes behavior.
 (Inherited from <a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_DownloadBehaviorModel_Default">Default</a></td><td>
Gets a reference to default behavior.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DownloadBehaviorModel_IsDefault">IsDefault</a></td><td>
When overridden in a derived class, gets a value indicating whether this instance contains the default.
 (Overrides <a href="P_iTin_Export_Model_BaseBehaviorModel_IsDefault">BaseBehaviorModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_DownloadBehaviorModel_LocalCopy">LocalCopy</a></td><td>
Gets or sets a value indicating whether saves local copy of this export.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_Execute">Execute(IWriter)</a></td><td>
Execute behavior.
 (Inherited from <a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_Execute_1">Execute(IWriter, ExportSettings)</a></td><td>
Execute behavior.
 (Inherited from <a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_DownloadBehaviorModel_ExecuteBehavior">ExecuteBehavior</a></td><td>
Code for execute download behavior.
 (Overrides <a href="M_iTin_Export_Model_BaseBehaviorModel_ExecuteBehavior">BaseBehaviorModel.ExecuteBehavior(IWriter, ExportSettings)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_SetOwner">SetOwner</a></td><td>
Sets a reference to the owner object that contains this instance.
 (Inherited from <a href="T_iTin_Export_Model_BaseBehaviorModel">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Behaviors`</strong>. For more information, please see <a href="T_iTin_Export_Model_BehaviorsModel">BehaviorsModel</a>.<br />
**ITEE Object Element Usage**<br />
``` XML
<Download .../>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_BaseBehaviorModel_CanExecute">CanExecute</a></td><td align="center">Yes</td><td>Determines whether executes behavior. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_DownloadBehaviorModel_LocalCopy">LocalCopy</a></td><td align="center">Yes</td><td>Determines whether saves local copy. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Behaviors>
  <Downdload LocalCopy="Yes"/>
  <TransformFile Save="No"/>
</Behaviors>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />