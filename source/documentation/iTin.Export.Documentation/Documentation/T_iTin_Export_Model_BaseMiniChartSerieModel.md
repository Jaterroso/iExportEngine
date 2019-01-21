# BaseMiniChartSerieModel Class
Additional header content 

Base class for the different types of mini-chart series supported by <strong>`iTin Export Engine`</strong>.<br /> Which acts as the base class for different mini-chart serie.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseMiniChartSerieModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseMiniChartSerieModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MiniChartColumnSerieModel">iTin.Export.Model.MiniChartColumnSerieModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MiniChartLineSerieModel">iTin.Export.Model.MiniChartLineSerieModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MiniChartWinLossSerieModel">iTin.Export.Model.MiniChartWinLossSerieModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseMiniChartSerieModel : BaseModel<BaseMiniChartSerieModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseMiniChartSerieModel
	Inherits BaseModel(Of BaseMiniChartSerieModel)
```

The BaseMiniChartSerieModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseMiniChartSerieModel__ctor">BaseMiniChartSerieModel</a></td><td>
Initializes a new instance of the BaseMiniChartSerieModel class</td></tr></table>&nbsp;
<a href="#baseminichartseriemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseMiniChartSerieModel_Color">Color</a></td><td>
Gets or sets preferred serie color.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseMiniChartSerieModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#baseminichartseriemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseMiniChartSerieModel_GetColor">GetColor</a></td><td>
Gets a reference to the Color structure preferred for this mini-chart serie.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#baseminichartseriemodel-class">Back to Top</a>

## Remarks

The following table shows different data fields.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_MiniChartColumnSerieModel">MiniChartColumnSerieModel</a></td><td>Represents a serie for column mini-chart.</td></tr><tr><td><a href="T_iTin_Export_Model_MiniChartLineSerieModel">MiniChartLineSerieModel</a></td><td>Represents a serie for line mini-chart.</td></tr><tr><td><a href="T_iTin_Export_Model_MiniChartWinLossSerieModel">MiniChartWinLossSerieModel</a></td><td>Represents a serie for win-loss mini-chart.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />