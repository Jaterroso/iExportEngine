# DataSetInput Class
Additional header content 

Class than allows you to export an object of type DataSet.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Input_BaseInput">iTin.Export.ComponentModel.Input.BaseInput</a><br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Inputs.DataSetInput<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Inputs_DataRowInput">iTin.Export.Inputs.DataRowInput</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Inputs">iTin.Export.Inputs</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public class DataSetInput : BaseInput
```

**VB**<br />
``` VB
Public Class DataSetInput
	Inherits BaseInput
```

The DataSetInput type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Inputs_DataSetInput__ctor">DataSetInput</a></td><td>
Initializes a new instance of the DataSetInput class.</td></tr></table>&nbsp;
<a href="#datasetinput-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Input_BaseInput_Data">Data</a></td><td>
Gets a reference that contains the input data to export.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Input_BaseInput">BaseInput</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Input_BaseInput_InputMetadata">InputMetadata</a></td><td>
Gets a reference that contains the metadata information about this input.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Input_BaseInput">BaseInput</a>.)</td></tr></table>&nbsp;
<a href="#datasetinput-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Input_BaseInput_Export">Export</a></td><td>
Exports the input data using the specified configuration in xml configuration file.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Input_BaseInput">BaseInput</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td> (Inherited from Object.)</td></tr></table>&nbsp;
<a href="#datasetinput-class">Back to Top</a>

## Remarks

The following table shows the different input types.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td>ArraListInput</td><td>Represents an input for array of ArrayList types. For more information please see ArraListInput</td></tr><tr><td><a href="T_iTin_Export_Inputs_DataRowInput">DataRowInput</a></td><td>Represents an input for array of DataRow types. For more information please see <a href="T_iTin_Export_Inputs_DataRowInput">DataRowInput</a></td></tr><tr><td>DataSetInput</td><td>Represents an input for DataSet types. For more information please see DataSetInput</td></tr><tr><td><a href="T_iTin_Export_Inputs_DataTableInput">DataTableInput</a></td><td>Represents an input for DataTable types. For more information please see <a href="T_iTin_Export_Inputs_DataTableInput">DataTableInput</a></td></tr><tr><td>EnumerableInput</td><td>Represents an input for IEnumerable(DataRow) types. For more information please see EnumerableInput</td></tr><tr><td><a href="T_iTin_Export_Inputs_XmlInput">XmlInput</a></td><td>Represents an input for `Xml` type. For more information please see <a href="T_iTin_Export_Inputs_XmlInput">XmlInput</a></td></tr><tr><td><a href="T_iTin_Export_Inputs_JsonInput">JsonInput</a></td><td>Represents an input for `Json` type. For more information please see <a href="T_iTin_Export_Inputs_JsonInput">JsonInput</a></td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Inputs">iTin.Export.Inputs Namespace</a><br />