using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnectionWorker.sqlConnectWrite();
            Leads lead1 = new Leads();

            lead1.activities = "Good";

            // pause console
            Console.ReadLine();
            
        }
    }
}
