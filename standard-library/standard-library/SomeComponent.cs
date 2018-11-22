using System;
using System.Net;
using System.Threading.Tasks;
using Xrm.Tools.WebAPI;

namespace standard_library
{
    public class SomeComponent
    {
        public async Task GoDo()
        {
            var api = CreateApi(); 
            await api.Create(string.Empty, null);
        }

        protected CRMWebAPI CreateApi()
        {
            return new CRMWebAPI(string.Empty, new NetworkCredential());
        }
    }
}
