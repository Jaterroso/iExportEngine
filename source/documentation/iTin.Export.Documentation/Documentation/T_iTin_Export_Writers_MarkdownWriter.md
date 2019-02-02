# MarkdownWriter Class
Additional header content 

Represents custom writer for tab delimited text (txt format).


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">iTin.Export.ComponentModel.Writer.BaseWriter</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Writer_BaseWriterDirect">iTin.Export.ComponentModel.Writer.BaseWriterDirect</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Writers.MarkdownWriter<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Writers">iTin.Export.Writers</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public class MarkdownWriter : BaseWriterDirect
```

**VB**<br />
``` VB
Public Class MarkdownWriter
	Inherits BaseWriterDirect
```

The MarkdownWriter type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Writers_MarkdownWriter__ctor">MarkdownWriter</a></td><td>
Initializes a new instance of the MarkdownWriter class</td></tr></table>&nbsp;
<a href="#markdownwriter-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_IsTransformationFile">IsTransformationFile</a></td><td>
Gets a value indicating whether this writer generates a transformation file to be processed later.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Provider">Provider</a></td><td>
Gets or sets a reference to provider for export.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_ResponseEx">ResponseEx</a></td><td>
Gets a reference to an object HttpResponseEx than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Result">Result</a></td><td>
Gets enumerable of byte array containing data info.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriterDirect_Service">Service</a></td><td>
Gets a reference to service render.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterDirect">BaseWriterDirect</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Stream">Stream</a></td><td>
Gets a reference to writer's stream.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_TransformFileExtension">TransformFileExtension</a></td><td>
Gets the transform file extension.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriterDirect_WriterIdentifier">WriterIdentifier</a></td><td>
Gets a value than identifies the type of writer.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterDirect">BaseWriterDirect</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_WriterMetadata">WriterMetadata</a></td><td>
Gets a reference that contains the extended information about this writer.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr></table>&nbsp;
<a href="#markdownwriter-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Dispose">Dispose</a></td><td>
Implement IDisposable. Clean managed and unmanaged resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Writers_MarkdownWriter_Execute">Execute</a></td><td>
Generates the output in tab-separated values ​​format.
 (Overrides <a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Execute">BaseWriter.Execute()</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Generate">Generate</a></td><td>
Generates writer output.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_GetAsByteArrayEnumerable">GetAsByteArrayEnumerable</a></td><td>
Returns the writer result file as a enumeration of byte array
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_ReleaseManagedResources">ReleaseManagedResources</a></td><td>
Releasing managed resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_ReleaseUnmanagedResources">ReleaseUnmanagedResources</a></td><td>
Releasing unmanaged resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td> (Inherited from Object.)</td></tr></table>&nbsp;
<a href="#markdownwriter-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Writers.MarkdownWriter"\]

## See Also


#### Reference
<a href="N_iTin_Export_Writers">iTin.Export.Writers Namespace</a><br />