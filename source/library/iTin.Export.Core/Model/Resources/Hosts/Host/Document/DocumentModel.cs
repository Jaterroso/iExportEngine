﻿
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Includes the description of export table.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Host</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.HostModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    ///   &lt;Document ...&gt;
    ///    &lt;Header/&gt;
    ///    &lt;Footer/&gt;
    ///    &lt;Margins/&gt;
    ///  &lt;/Document&gt;
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Optional</th>
    ///       <th>Description</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DocumentModel.Size" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred size of document. The default is <see cref="F:iTin.Export.Model.KnownDocumentSize.A4" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DocumentModel.Orientation" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred orientation of document. The default is <see cref="F:iTin.Export.Model.KnownDocumentOrientation.Portrait" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DocumentModel.View" /></td>
    ///       <td align="center">Normal</td>
    ///       <td>Preferred document view. The default is <see cref="F:iTin.Export.Model.KnownDocumentView.Normal" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.DocumentModel.Metadata" /></term> 
    ///     <description>Represents metadata properties of a document. Allow define metadata information (Title, Company, Url, etc...).</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.DocumentModel.Header" /></term> 
    ///     <description>Represents header properties of a document. Allow define margin and data.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.DocumentModel.Footer" /></term> 
    ///     <description>Represents footer properties of a document. Allow define margin and data.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.DocumentModel.Margins" /></term> 
    ///     <description>Represents margins of a document. Allow define top margin, right margin, bottom margin and left margin of a document.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
    ///     </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">X</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class DocumentModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownDocumentView DefaultDocumentView = KnownDocumentView.Normal;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownDocumentSize DefaultSize = KnownDocumentSize.A4;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownDocumentOrientation DefaultOrientation = KnownDocumentOrientation.Portrait;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentMetadataModel _metadata;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentHeaderFooterModel _footer;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentHeaderFooterModel _header;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MarginsModel _margins;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownDocumentView _view;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownDocumentSize _size;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HostModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownDocumentOrientation _orientation;
        #endregion

        #region constructor/s

        #region [public] DocumentModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.DocumentModel"/> class.
        /// </summary>
        public DocumentModel()
        {
            Size = DefaultSize;
            Orientation = DefaultOrientation;
            View = DefaultDocumentView;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DocumentHeaderModel) Metadata: Gets or sets a reference to 
        public DocumentMetadataModel Metadata
        {
            get
            {
                if (_metadata == null)
                {
                    _metadata = new DocumentMetadataModel();
                }

                _metadata.SetParent(this);

                return _metadata;
            }
            set => _metadata = value;
        }
        #endregion

        #region [public] (DocumentHeaderFooterModel) Header: Gets or sets a reference to header document configuration, it allow define margin and data
        /// <summary>
        /// Gets or sets a reference to header document configuration, it allow define margin and data.
        /// </summary>
        /// <value>
        /// Reference to header document configuration, it allow define margin and data.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Document&gt;
        ///   &lt;Header .../&gt;
        ///   ...
        /// &lt;/Document&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public DocumentHeaderFooterModel Header
        {
            get
            {
                if (_header == null)
                {
                    _header = new DocumentHeaderFooterModel();
                }

                _header.SetParent(this);

                return _header;
            }
            set => _header = value;
        }
        #endregion

        #region [public] (DocumentHeaderFooterModel) Footer: Gets or sets a reference to footer document configuration, it allow define margin and data
        /// <summary>
        /// Gets or sets a reference to footer document configuration, it allow define margin and data.
        /// </summary>
        /// <value>
        /// Reference to footer document configuration, it allow define margin and data.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Document&gt;
        ///   &lt;Footer .../&gt;
        ///   ...
        /// &lt;/Document&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public DocumentHeaderFooterModel Footer
        {
            get
            {
                if (_footer == null)
                {
                    _footer = new DocumentHeaderFooterModel();
                }

                _footer.SetParent(this);

                return _footer;
            }
            set => _footer = value;
        }
        #endregion

        #region [public] (MarginsModel) Margins: Gets or sets a reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document
        /// <summary>
        /// Gets or sets a reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document.
        /// </summary>
        /// <value>
        /// Reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Document&gt;
        ///   &lt;Margins .../&gt;
        ///   ...
        /// &lt;/Document&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public MarginsModel Margins
        {
            get => _margins ?? (_margins = new MarginsModel());
            set => _margins = value;
        }
        #endregion

        #region [public] (KnownDocumentOrientation) Orientation: Gets or sets the preferred orientation of document
        /// <summary>
        /// Gets or sets the preferred orientation of document.
        /// </summary>
        /// <value>
        /// A value of the enumeration <see cref="T:iTin.Export.Model.KnownDocumentOrientation" />. The default is <see cref="iTin.Export.Model.KnownDocumentOrientation.Portrait" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Document Orientation="Portrait|Landscape" ...&gt;
        /// ...
        /// &lt;/Document&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code lang="xml">
        /// &lt;Document Orientation="Landscape"&gt;
        /// ...
        /// &lt;/Document&gt;
        /// </code>
        /// <code lang="cs">
        ///   ...
        ///   DocumentModel document = new DocumentModel 
        ///                          { 
        ///                              Orientation = KnownDocumentOrientation.Landscape
        ///                          } ;
        ///   ...
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultOrientation)]
        public KnownDocumentOrientation Orientation
        {
            get => _orientation;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _orientation = value;
            }
        }
        #endregion

        #region [public] (KnownDocumentView) View: Gets or sets the preferred document view.
        [XmlAttribute]
        [DefaultValue(DefaultDocumentView)]
        public KnownDocumentView View
        {
            get => _view;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _view = value;
            }
        }
        #endregion

        #region [public] (HostModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public HostModel Parent => _parent;
        #endregion

        #region [public] (KnownDocumentSize) Size: Gets or sets the preferred size of document
        /// <summary>
        /// Gets or sets the preferred size of document.
        /// </summary>
        /// <value>
        /// A value of the enumeration <see cref="iTin.Export.Model.KnownDocumentSize" />. The default is <see cref="iTin.Export.Model.KnownDocumentSize.A4" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Document Size="A4|Letter" ...&gt;
        /// ...
        /// &lt;/Document&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code lang="xml">
        /// &lt;Document Size="Letter" Orientation="Landscape"&gt;
        /// ...
        /// &lt;/Document&gt;
        /// </code>
        /// <code lang="cs">
        ///   ...
        ///   DocumentModel document = new DocumentModel 
        ///                          { 
        ///                              Size = KnownDocumentSize.Letter,
        ///                              Orientation = KnownDocumentOrientation.Landscape
        ///                          } ;
        ///   ...
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultSize)]
        public KnownDocumentSize Size
        {
            get => _size;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _size = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => 
            base.IsDefault &&
            Margins.IsDefault &&
            Size.Equals(DefaultSize) &&
            Orientation.Equals(DefaultOrientation) &&
            View.Equals(DefaultDocumentView);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(HostModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(HostModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
