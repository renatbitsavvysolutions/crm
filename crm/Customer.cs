using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm
{
    class Customer
    {


        //instance variable declarations

    /*    private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string zipCode;
        private string city;
        private string state; */


        //accessors 
        public string FirstName {get;set;}
        public string LastName{ get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ZipCode { get; set; }
        public string City {get; set; }
        public string State { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }

        public DateTime Date { get; set; }

        public string MobileNumber { get; set; }

        public string OtherPhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public int EmailOptOut { get; set; }


        public void printClass()
        {

            Console.WriteLine("Report for the First Name is:");
            Console.WriteLine(FirstName);
            Console.WriteLine("Report for the Last Name is:");
            Console.WriteLine(LastName);
            Console.WriteLine("Report for the Adress is:");
            Console.WriteLine(Address);
            Console.WriteLine("Report for the Phone Number is:");
            Console.WriteLine(PhoneNumber);
            Console.WriteLine("Report for the Account Name is:");
            Console.WriteLine(AccountName);
            Console.WriteLine("Please enter Email:");
            Console.WriteLine(Email);




        }


    }
}
