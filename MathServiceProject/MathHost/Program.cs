using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MathService;
namespace MathHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MathService.MathService))) {
                host.Open();
                Console.WriteLine("Service Started {0}",DateTime.Today.ToString());
                Console.ReadLine();
            }

        }
    }
}
