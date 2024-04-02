using System;
using System.Threading.Tasks;


namespace D8S.E0015
{
    class Program
    {
        static async Task Main()
        {
            await Explorations.Instance.Try_Generator_Host_cshtml();
        }
    }
}