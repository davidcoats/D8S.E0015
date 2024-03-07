using System;
using System.Threading.Tasks;

using R5T.T0141;


namespace D8S.E0015
{
    [ExplorationsMarker]
    public partial interface IExplorations : IExplorationsMarker
    {
        /// <summary>
        /// To generate static HTML from Razor components, you first need a Razor page that uses the &lt;component&gt; tag helper.
        /// Try generating this Razor page markup using <see cref="System.Xml.Linq.XElement"/>s.
        /// </summary>
        public async Task Try_Generator_Host_cshtml()
        {
            var outputCshtmlFilePath = @"C:\Temp\Output.cshtml";



            Instances.NotepadPlusPlusOperator.Open(outputCshtmlFilePath);
        }
    }
}
