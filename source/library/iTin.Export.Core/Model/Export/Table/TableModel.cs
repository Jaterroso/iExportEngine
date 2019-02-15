﻿
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using ComponentModel.Provider;
    using Helpers;

    public partial class TableModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAlias = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultHost = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultAutoFilter = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShowGridLines = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultAutoFitColumns = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShowColumnHeaders = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShowDataValues = YesNo.Yes;
        #endregion

        #region private static readonly
        private static readonly int[] DefaultFreezePanes = { 1, 1 };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] _freezePanes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _autoFilter;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel _location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeadersModel _headers;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _showGridLines;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _showColumnHeaders;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _filter;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LogoModel _logo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _autoFitColumns;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartsModel _charts;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldsModel _fields;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OutputModel _output;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExporterModel _exporter;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConditionsItemModel _conditions;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _showDataValues;

        #endregion

        #region constructor/s

        #region [public] TableModel(): Initializes a new instance of this class
        public TableModel()
        {
            Host = DefaultHost;
            Alias = DefaultAlias;
            AutoFilter = DefaultAutoFilter;
            FreezePanes = DefaultFreezePanes;
            ShowGridLines = DefaultShowGridLines;
            AutoFitColumns = DefaultAutoFitColumns;
            ShowColumnHeaders = DefaultShowColumnHeaders;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Alias: Gets or sets the alias of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Alias"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAlias)]
        public string Alias { get; set; }
        #endregion

        #region [public] (YesNo) AutoFilter: Gets or sets a value indicating whether displays the autofilter
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="AutoFilter"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAutoFilter)]
        public YesNo AutoFilter
        {
            get => GetStaticBindingValue(_autoFilter.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _autoFilter = value;
            }
        }
        #endregion

        #region [public] (YesNo) AutoFitColumns: Gets or sets a value indicating whether adjusts column width automatically
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="AutoFitColumns"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAutoFitColumns)]
        public YesNo AutoFitColumns
        {
            get => GetStaticBindingValue(_autoFitColumns.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _autoFitColumns = value;
            }
        }
        #endregion

        #region [public] (string) Host: Gets or sets the host of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Alias"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultHost)]
        public string Host { get; set; }
        #endregion

        #region [public] (string) Name: Gets or sets name of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Name"]/*'/>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Table", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (string) Filter: Gets or sets the data filter to apply.
        [XmlAttribute]
        public string Filter { get; set; }
        #endregion

        #region [public] (int[]) FreezePanes: Gets or sets an array of integers that represent the freeze panes coordenates
        [XmlAttribute]
        [CLSCompliant(false)]
        [DefaultValue(new[] { 1, 1 })]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int[] FreezePanes
        {
            get => _freezePanes ?? (_freezePanes = DefaultFreezePanes);
            set
            {
                if (value == null)
                {
                    return;
                }

                SentinelHelper.IsTrue(value.Length > 2, "Máximo 2 valores");
                SentinelHelper.IsTrue(value[0] < 0, "La coordenada horizontal no puede ser menor que cero");
                SentinelHelper.IsTrue(value[1] < 0, "La coordenada vertical no puede ser menor que cero");

                _freezePanes = value;
            }
        }
        #endregion

        #region [public] (Point) FreezePanesPoint: Gets freeze panes as point
        public Point FreezePanesPoint => new Point(FreezePanes[0], FreezePanes[1]);
        #endregion

        #region [public] (YesNo) ShowGridLines: Gets or sets a value indicating whether show grid lines
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="ShowGridLines"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultShowGridLines)]
        public YesNo ShowGridLines
        {
            get => GetStaticBindingValue(_showGridLines.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _showGridLines = value;
            }
        }
        #endregion

        #region [public] (YesNo) ShowColumnHeaders: Gets or sets a value indicating whether show column headers
        /// <summary>
        /// Gets or sets the show column headers.
        /// </summary>
        /// <value>
        /// The show column headers.
        /// </value>
        [XmlAttribute]
        [DefaultValue(DefaultShowColumnHeaders)]
        public YesNo ShowColumnHeaders
        {
            get => GetStaticBindingValue(_showColumnHeaders.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _showColumnHeaders = value;
            }
        }
        #endregion

        #region [public] (YesNo) ShowDataValues: Gets or sets a value that indicates whether the data is displayed
        /// <summary>
        /// Gets or sets a value that indicates whether the data is displayed.
        /// </summary>
        /// <value>
        /// <see cref="YesNo.Yes"/> if the data is displayed; otherwise, <see cref="YesNo.No"/>.
        /// </value>
        [XmlAttribute]
        [DefaultValue(DefaultShowDataValues)]
        public YesNo ShowDataValues
        {
            get => GetStaticBindingValue(_showDataValues.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _showDataValues = value;
            }
        }
        #endregion

        #region [public] (bool) HasFields: Gets a value indicating whether there are fields defined
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="HasFields"]/*'/>
        public bool HasFields => Fields.Any();
        #endregion

        #region [public] (bool) HasConditions: Gets a value indicating whether there are conditions defined
        public bool HasConditions => Conditions.Keys.Any();
        #endregion

        #region [public] (OutputModel) Output: Gets or sets a reference to output configuration model, it includes path and file name
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Output"]/*'/>
        public OutputModel Output
        {
            get
            {
                if (_output == null)
                {
                    _output = new OutputModel();
                }

                _output.SetParent(this);

                return _output;
            }
            set => _output = value;
        }
        #endregion

        #region [public] (LocationModel) Location: Gets or sets a reference which contains the location of the table in the host
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Location"]/*'/>
        public LocationModel Location
        {
            get => _location ?? (_location = new LocationModel());
            set => _location = value;
        }
        #endregion

        #region [public] (LogoModel) Logo: Gets or sets a reference to the logo model defined for this table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Logo"]/*'/>
        public LogoModel Logo
        {
            get
            {
                if (_logo == null)
                {
                    _logo = new LogoModel();
                }

                _logo.SetParent(this);

                return _logo;
            }
            set => _logo = value;
        }
        #endregion

        #region [public] (ConditionsItemModel) Conditions: Gets or sets 
        public ConditionsItemModel Conditions
        {
            get
            {
                if (_conditions == null)
                {
                    _conditions = new ConditionsItemModel();
                }

                _conditions.SetParent(this);

                return _conditions;
            }
            set => _conditions = value;
        }
        #endregion

        #region [public] (ExporterModel) Exporter: Gets or sets a reference to the exporter model defined for this table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Exporter"]/*'/>
        public ExporterModel Exporter
        {
            get
            {
                if (_exporter == null)
                {
                    _exporter = new ExporterModel();
                }

                _exporter.SetParent(this);

                return _exporter;
            }
            set => _exporter = value;
        }
        #endregion

        #region [public] (ColumnHeadersModel) Headers: Gets or sets collection of column headers
        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>
        /// The headers.
        /// </value>
        [XmlArrayItem("Header", typeof(ColumnHeaderModel))]
        public ColumnHeadersModel Headers
        {
            get => _headers ?? (_headers = new ColumnHeadersModel(this));
            set => _headers = value;
        }
        #endregion

        #region [public] (FieldsModel) Fields: Gets or sets collection of data fields
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Fields"]/*'/>
        [XmlArrayItem("Field", typeof(DataFieldModel))]
        [XmlArrayItem("Fixed", typeof(FixedFieldModel))]
        [XmlArrayItem("Gap", typeof(GapFieldModel))]
        [XmlArrayItem("Group", typeof(GroupFieldModel))]
        [XmlArrayItem("Packet", typeof(PacketFieldModel))]
        public FieldsModel Fields
        {
            get => _fields ?? (_fields = new FieldsModel(this));
            set => _fields = value;
        }
        #endregion

        #region [public] (ChartsModel) Charts: Gets or sets collection of user-defined charts
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Charts"]/*'/>
        [XmlArrayItem("Chart", typeof(ChartModel))]
        [XmlArrayItem("MiniChart", typeof(MiniChartModel))]
        public ChartsModel Charts
        {
            get => _charts ?? (_charts = new ChartsModel(this));
            set => _charts = value;
        }
        #endregion

        #region [public] (ExportModel) Parent: Gets the parent container of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Parent"]/*'/>
        [Browsable(false)]
        public ExportModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        [Browsable(false)]
        public override bool IsDefault => Fields.IsDefault &&
                                          Output.IsDefault &&
                                          Headers.IsDefault &&
                                          Exporter.IsDefault &&
                                          Location.IsDefault &&
                                          Host.Equals(DefaultHost) &&
                                          Alias.Equals(DefaultAlias) &&
                                          AutoFilter.Equals(DefaultAutoFilter) &&
                                          ShowGridLines.Equals(DefaultShowGridLines) &&
                                          AutoFitColumns.Equals(DefaultAutoFitColumns) &&
                                          ShowDataValues.Equals(DefaultShowDataValues) &&
                                          ShowColumnHeaders.Equals(DefaultShowColumnHeaders);
        //Logo.IsDefault &&
        //Charts.IsDefault &&
        #endregion

        #endregion

        #region public methods

        #region [public] (IEnumerable<KeyValuePair<BaseDataFieldModel, Size>>) GetHeaderColumnsSize(IAdapter): Gets a dictionary containing the pair of header column number / size in pixels of the same
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Methods/Method[@name="GetHeaderColumnsSize"]/*'/>
        public IEnumerable<KeyValuePair<BaseDataFieldModel, Size>> GetHeaderColumnsSize(IProvider adapter)
        {
            SentinelHelper.ArgumentNull(adapter);

            ////var data = target.ToXml().ToList();
            var columns = new Dictionary<BaseDataFieldModel, Size>();
            var flds = Fields.GetRange(KnownFieldType.Field);
            foreach (var baseDataFieldModel in flds)
            {
                var fld = (DataFieldModel) baseDataFieldModel;
                var header = fld.Header;
                var headerText = fld.Alias;

                ////var style = this.Styles[header.Style];
                var style = Parent.Owner.Resources.Styles[header.Style];
                using (var font = style.Font.ToFont())
                {
                    //var longestValue = data.Select(d => d.Attributes(target.Parse(fld.Name)).First().Value).OrderByDescending(item => item.Trim().Length).FirstOrDefault().Trim();
                    //if (longestValue.Length > headerText.Length)
                    //{
                    //    headerText = longestValue;
                    //}

                    if (AutoFilter == YesNo.Yes)
                    {
                        if (headerText.Equals(fld.Alias))
                        {
                            headerText = string.Concat(headerText, "    ");
                        }
                    }

                    var textSize = TextRenderer.MeasureText(headerText, font);
                    columns.Add(fld, textSize);
                }
            }

            return columns;
        }
        #endregion
        
        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Table/Public/Overrides/Methods/Method[@name='ToString']/*" />
        public override string ToString()
        {
            return $"Name=\"{Name}\", Type={Exporter.ExporterType}";
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ExportModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(ExportModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
