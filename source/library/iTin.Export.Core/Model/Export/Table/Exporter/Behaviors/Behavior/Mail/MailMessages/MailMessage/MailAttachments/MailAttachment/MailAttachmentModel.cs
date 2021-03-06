﻿
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/MailMessageAttachment/Class[@name="info"]/*'/>
    public partial class MailMessageAttachmentModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageAttachmentsModel _owner;
        #endregion

        #region public properties

        #region [public] (MailMessageAttachmentsModel) Owner: Gets the MailMessageAttachmentsModel that owns this MailMessageAttachmentModel
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/MailMessageAttachment/Public/Properties/Property[@name="Owner"]/*'/>
        [Browsable(false)]
        public MailMessageAttachmentsModel Owner => _owner;
        #endregion

        #region [public] (string) Path: Gets or sets path to filename to attach
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/MailMessageAttachment/Public/Properties/Property[@name="Path"]/*'/>
        [XmlAttribute]
        public string Path
        {
            get => _path;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));

                _path = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => string.IsNullOrEmpty(Path);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(MailMessageAttachmentsModel): Sets the element that owns this
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/MailMessageAttachment/Public/Methods/Method[@name="SetOwner"]/*'/>
        public void SetOwner(MailMessageAttachmentsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
