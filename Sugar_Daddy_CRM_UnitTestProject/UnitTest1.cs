using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using crm;
 


namespace Sugar_Daddy_CRM_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        public string FirstName;
        public string LastName;
        public string Address;
        public string PhoneNumber;
    
        public string AccountName;
        public string Email;

        public DateTime Date;

        public string MobileNumber;

        public string OtherPhoneNumber;
        public string Fax;
        public string Title;
        public string Department;
        public int EmailOptOut;




        Customer C2 = new Customer();

        [TestMethod]
        public void TestMethod1()
        {
            C2.FirstName = "Trap";
            
        }
    }
}
