using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(RandomizerService.Controller))) {
                host.Open();
                Console.WriteLine(8080);
                Console.Read();
            } ;
        }
    }
}
