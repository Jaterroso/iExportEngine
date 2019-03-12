﻿
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    /// <summary>
    /// Represents the visual setting for axes of a chart. Includes information of primary and secondary axes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Chart</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Axes&gt;
    ///   &lt;Primary/&gt;
    ///   &lt;Secondary/&gt;
    /// &lt;/Axes&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartAxesModel.Primary" /></term> 
    ///     <description>Reference to information of primary axes. Includes information for the category and value axes.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartAxesModel.Secondary" /></term> 
    ///     <description>Reference to information of secondary axes. Includes information for the category and value axes.</description>
    ///   </item>
    /// </list>
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
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class ChartAxesModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisModel _primary;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisModel _secondary;
        #endregion

        #region public properties

        #region [public] (ChartModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public ChartModel Parent => _parent;
        #endregion

        #region [public] (AxisModel) Primary: Gets or sets a reference to information of primary axes
        /// <summary>
        /// Gets or sets a reference to information of primary axes.
        /// </summary>
        /// <value>
        /// An <see cref="T:iTin.Export.Model.AxisModel" /> reference that contains information of primary axes. Includes information for the category and value axes.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Axes&gt;
        ///   &lt;Primary/&gt;
        ///   ...
        /// &lt;/Axes&gt;
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
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public AxisModel Primary
        {
            get
            {
                if (_primary == null)
                {
                    _primary = new AxisModel();
                }

                _primary.SetParent(this);

                return _primary;
            }
            set => _primary = value;
        }
        #endregion

        #region [public] (AxisModel) Secondary: Gets or sets a reference to information of secondary axes
        /// <summary>
        /// Gets or sets a reference to information of secondary axes.
        /// </summary>
        /// <value>
        /// An <see cref="T:iTin.Export.Model.AxisModel" /> reference that contains information of secondary axes. Includes information for the category and value axes.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Axes&gt;
        ///   &lt;Secondary/&gt;
        ///   ...
        /// &lt;/Axes&gt;
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
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public AxisModel Secondary
        {
            get
            {
                if (_secondary == null)
                {
                    _secondary = new AxisModel();
                }

                _secondary.SetParent(this);

                return _secondary;
            }
            set => _secondary = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        public override bool IsDefault => Primary.IsDefault && Secondary.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ChartModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(ChartModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
