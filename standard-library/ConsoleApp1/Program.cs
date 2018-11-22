using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using standard_library;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ExtendedComponent();
            var task = s.GoDo();
            task.Wait();
        }
    }

    public class ExtendedComponent : SomeComponent
    {
        public async Task GoDoSpecific()
        {
            var api = CreateApi();
            await api.Delete(string.Empty, Guid.Empty);
        }
    }
}
