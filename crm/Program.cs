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
           
            //Create Customer class object
           Customer c1 = new Customer();

           Console.WriteLine("Please enter your First Name");
           c1.FirstName = Console.ReadLine();
           Console.WriteLine("Please enter your Last Name");
           c1.LastName = Console.ReadLine();
           //Console.WriteLine("Please enter your Address");
           //c1.Address = Console.ReadLine();
            Console.WriteLine("Please enter your Account");
            c1.AccountName = Console.ReadLine();
            Console.WriteLine("Please enter your Email");
            c1.Email = Console.ReadLine();
            Console.WriteLine("Please enter your Mobile Number");
            c1.MobileNumber = Console.ReadLine();
            Console.WriteLine("Please enter your Other Phone Number");
            c1.OtherPhoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter your Fax Number");
            c1.Fax = Console.ReadLine();
            Console.WriteLine("Please enter your Title");
            c1.Title = Console.ReadLine();
            Console.WriteLine("Please enter your Department");
            c1.Department = Console.ReadLine();
            Console.WriteLine("OptOut of Email?");
            c1.EmailOptOut = Convert.ToInt32( Console.ReadLine());
            c1.Date = DateTime.Now;



            // connect to SQL database and write values
            c1.sqlConnectWrite();

            // pause console
            Console.ReadLine();
            
        }
    }
}
