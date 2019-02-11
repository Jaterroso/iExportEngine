﻿
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Helpers;

    /// <summary>
    /// Represents a user-defined mini-chart.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Charts</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// <![CDATA[
    /// <MiniChart...>
    ///   <Location/>
    ///   <Axes/>
    ///   <Type/>
    ///   <Properties/>
    /// </Font>
    /// ]]>
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Attribute</term>
    ///     <term>Optional</term>
    ///     <term>Description</term>
    ///     <term>Default</term>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.Field"/></term>
    ///     <term>No</term>
    ///     <term>Name of field that contains data.</term>
    ///     <term></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.EmptyValuesAs"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred action when the field does not contain information.</term>
    ///     <term>The default is <c>Gap</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.Show"/></term>
    ///     <term>Yes</term>
    ///     <term>Determines whether displays the mini-chart.</term>
    ///     <term>The default is <c>Yes</c></term>
    ///   </item>
    /// </list>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartLocationModel"/></term>
    ///     <description>Defines the mini-chart location on the host, this can be by coordinates or by column or by row. You can only choose one of them. If this tag does not define the defaults is by column</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartAxesModel"/></term>
    ///     <description>Defines the mini-chart axes configuration.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartTypeModel"/></term>
    ///     <description>Defines the mini-chart type configuration.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Properties"/></term>
    ///     <description>Reference to custom properties dictionary</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
    ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
    ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
    ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
    ///   </listheader>
    ///   <item>
    ///     <term></term>
    ///     <term></term>
    ///     <term></term>
    ///     <term></term>
    ///   </item>
    /// </list>
    /// A <c><b>X</b></c> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class MiniChartModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const MiniChartEmptyValuesAs DefaultEmptyValueAs = MiniChartEmptyValuesAs.Zero;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultDisplayHidden = YesNo.No;
        #endregion

        #region private static readonly
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly int[] DefaultCellSize = { -1, -1 };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartAxesModel _axes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] _cellSize;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _displayHidden;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartEmptyValuesAs _emptyValuesAs;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartLocationModel _location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartTypeModel _type;
        #endregion

        #region constructor/s

        #region [public] MiniChartModel(): Initializes a new instance of this class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MiniChartModel" /> class.
        /// </summary>
        public MiniChartModel()
        {
            DisplayHidden = DefaultDisplayHidden;
            EmptyValueAs = DefaultEmptyValueAs;
            Size = DefaultCellSize;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (KnownChartTypes) ChartType: Gets a value indicating chart type
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating chart type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownChartTypes" /> values.
        /// </value>
        public override KnownChartTypes ChartType => KnownChartTypes.MiniChartType;
        #endregion

        #endregion

        #region public properties

        #region [public] (MiniChartAxesModel) Axes: Gets or sets a reference that contains the visual setting of the chart axes
        public MiniChartAxesModel Axes
        {
            get
            {
                if (_axes == null)
                {
                    _axes = new MiniChartAxesModel();
                }

                _axes.SetParent(this);

                return _axes;
            }
            set => _axes = value;
        }
        #endregion

        #region [public] (YesNo) DisplayHidden: Gets or sets a value that determines preferred action for hidden values
        [XmlAttribute]
        [DefaultValue(DefaultDisplayHidden)]
        public YesNo DisplayHidden
        {
            get => _displayHidden.ToString().ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _displayHidden = value;
            }
        }
        #endregion

        #region [public] (MiniChartEmptyValuesAs) EmptyValueAs: Gets or sets a value that determines preferred action when the field does not contain information
        [XmlAttribute]
        [DefaultValue(DefaultEmptyValueAs)]
        public MiniChartEmptyValuesAs EmptyValueAs
        {
            get => _emptyValuesAs; //.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _emptyValuesAs = value;
            }
        }
        #endregion

        #region [public] (string) Field: Gets or sets name of field that contains data
        [XmlAttribute]
        public string Field
        {
            get => GetStaticBindingValue(_field);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _field = value;
            }
        }
        #endregion

        #region [public] (MiniChartLocationModel) Location: Gets or sets a reference which contains the mini chart location on the host
        public MiniChartLocationModel Location
        {
            get => _location ?? (_location = new MiniChartLocationModel());
            set => _location = value;
        }
        #endregion

        #region [public] (MiniChartTypeModel) Type: Gets or sets a reference that contains the visual setting of chart types
        public MiniChartTypeModel Type
        {
            get
            {
                if (_type == null)
                {
                    _type = new MiniChartTypeModel();
                }

                _type.SetParent(this);

                return _type;
            }
            set => _type = value;
        }
        #endregion

        #region [public] (int[]) Size: Gets or sets an array of integers that represent the table location
        [XmlAttribute]
        [CLSCompliant(false)]
        [DefaultValue(new[] { -1, -1 })]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int[] Size
        {
            get => _cellSize ?? (_cellSize = DefaultCellSize);
            set
            {
                if (value != null)
                {
                    SentinelHelper.IsTrue(value.Length > 2, "Máximo 2 valores");

                    _cellSize = value;
                }
            }
        }
        #endregion

        #region [public] (Size) CellSize: Gets cell size
        public Size CellSize => new Size(Size[0], Size[1]);
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault &&
                                          Axes.IsDefault &&
                                          DisplayHidden.Equals(DefaultDisplayHidden) &&
                                          EmptyValueAs.Equals(DefaultEmptyValueAs);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.DataFieldModel.ToString" /> returns a string that includes field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"ChartType={ChartType}, {base.ToString()}";
        }
        #endregion

        #endregion
    }
}
