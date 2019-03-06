# MaximumCondition Class
Additional header content 

Represents a field condition. Defines the style that will be applied to the field when its value is the maximum.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseConditionModel">iTin.Export.Model.BaseConditionModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.MaximumCondition<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class MaximumCondition : BaseConditionModel, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class MaximumCondition
	Inherits BaseConditionModel
	Implements ICloneable
```

The MaximumCondition type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_MaximumCondition__ctor">MaximumCondition</a></td><td>
Initializes a new instance of the MaximumCondition class.</td></tr></table>&nbsp;
<a href="#maximumcondition-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Active">Active</a></td><td>
Gets or sets a value that indicates if this condition is active. The default is Yes.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_MaximumCondition_Empty">Empty</a></td><td>
Gets an empty condition.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_EntireRow">EntireRow</a></td><td>
Gets or sets a value that indicates if condition style applies over the row. The default is No.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Field">Field</a></td><td>
Gets or sets a value that represents the field on which the condition will be evaluated
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MaximumCondition_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides <a href="P_iTin_Export_Model_BaseConditionModel_IsDefault">BaseConditionModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MaximumCondition_IsEmpty">IsEmpty</a></td><td>
Gets a value indicating whether this condition is an empty condition.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Key">Key</a></td><td>
Gets or sets a value that contains an identifier for this condition
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Locale">Locale</a></td><td>
Gets or sets the data field culture. The default is <a href="T_iTin_Export_Model_KnownCulture">Current</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Service">Service</a></td><td>
Gets a reference to an object that contains information about the context.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_MaximumCondition_Style">Style</a></td><td>
Gets or sets a value that represents the style that is applied when the condition is met.</td></tr></table>&nbsp;
<a href="#maximumcondition-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_MaximumCondition_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_Evaluate">Evaluate()</a></td><td>
Returns result of evaluates condition.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_Evaluate_1">Evaluate(Int32, Int32)</a></td><td>
Returns result of evaluates condition.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_MaximumCondition_Evaluate">Evaluate(Int32, Int32, FieldValueInformation)</a></td><td>
Returns result of evaluates condition.
 (Overrides <a href="M_iTin_Export_Model_BaseConditionModel_Evaluate_2">BaseConditionModel.Evaluate(Int32, Int32, FieldValueInformation)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_GetFieldAttributeEnumerable">GetFieldAttributeEnumerable</a></td><td>
Returns a list of field condition with raw content.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_SetOwner">SetOwner</a></td><td>
Sets a reference to the owner object that contains this instance.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel</a>.)</td></tr></table>&nbsp;
<a href="#maximumcondition-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Model.MaximumCondition"\]

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />