
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [XmlInclude(typeof(MaximumCondition))]
    [XmlInclude(typeof(MinimumCondition))]
    [XmlInclude(typeof(RemarksCondition))]
    [XmlInclude(typeof(WhenChangeConditionModel))]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("System.Xml", "4.0.30319.18033")]
    [XmlType(Namespace = "http://schemas.itin.com/export/engine/2014/configuration/v1.0")]

    public abstract partial class BaseConditionModel : BaseModel<BaseConditionModel>
    {
    }
}
