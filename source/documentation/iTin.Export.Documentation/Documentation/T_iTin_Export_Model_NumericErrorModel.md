# NumericErrorModel Class
Additional header content 

A Specialization of <a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a> class. Which acts as the base class of error structures for numerical data.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseErrorModel">iTin.Export.Model.BaseErrorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.NumericErrorModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_PercentageErrorModel">iTin.Export.Model.PercentageErrorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_ScientificErrorModel">iTin.Export.Model.ScientificErrorModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class NumericErrorModel : BaseErrorModel, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class NumericErrorModel
	Inherits BaseErrorModel
	Implements ICloneable
```

The NumericErrorModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NumericErrorModel__ctor">NumericErrorModel</a></td><td>
Initializes a new instance of the NumericErrorModel class.</td></tr></table>&nbsp;
<a href="#numericerrormodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseErrorModel_Comment">Comment</a></td><td>
Gets or sets a reference that contains the error comment.
 (Inherited from <a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_NumericErrorModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides <a href="P_iTin_Export_Model_BaseErrorModel_IsDefault">BaseErrorModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NumericErrorModel_Value">Value</a></td><td>
Gets or sets preferred default value when occurs an error.</td></tr></table>&nbsp;
<a href="#numericerrormodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NumericErrorModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseErrorModel_Combine">Combine(BaseErrorModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NumericErrorModel_Combine">Combine(NumericErrorModel)</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#numericerrormodel-class">Back to Top</a>

## Remarks

The following table shows the different data types error structures.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_PercentageErrorModel">PercentageErrorModel</a></td><td>Represents the error structure for percentage data type.</td></tr><tr><td><a href="T_iTin_Export_Model_ScientificErrorModel">ScientificErrorModel</a></td><td>Represents the error structure for scientific data type.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />