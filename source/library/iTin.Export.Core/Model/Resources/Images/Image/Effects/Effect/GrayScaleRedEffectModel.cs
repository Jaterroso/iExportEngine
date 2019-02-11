
namespace iTin.Export.Model
{
    using System.Drawing.Imaging;

    using Drawing.Helper;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseEffectModel"/> class.<br/>
    /// Which represents gray-scale red effect.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Effects</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ImageEffectsModel" />.<br/>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;GrayScaleRed/&gt;
    /// </code>
    /// </para>
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
    /// <example>
    /// <code lang="xml">
    /// &lt;Effects&gt;
    ///   &lt;GrayScaleRed/&gt;
    /// &lt;/Effects&gt;
    /// </code>
    /// </example>
    public partial class GrayScaleRedEffectModel
    {
        public override ImageAttributes Apply()
        {
            return ImageHelper.GetImageAttributesFromEffect(KnownEffectType.GrayScaleRed);
        }
    }
}
