using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Pisi.MasterData.Services;

namespace ExposeToRelayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(PayrollServices));
            sh.Open();
            //ServiceHost sh2 = new ServiceHost(typeof(Payslip));
            //sh2.Open();
            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();

            sh.Close();
            //sh2.Close();
        }
    }
}
