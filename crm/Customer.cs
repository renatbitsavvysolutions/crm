using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace crm
{
     public class Customer
    {


        //instance variable declarations

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

        public void sqlConnectWrite()
        {
            String str =
                "server=bitsavvy-crm-dev.crvxjxsnep6q.us-west-2.rds.amazonaws.com;" +
                "database=sugar_daddy_crm;" +
                "userid=administrator;" +
                "password =Pdee!871;";

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open(); //open the connection
                Console.WriteLine("Connection Open");
                // String cmdText = "INSERT INTO accounts (FirstName, LastName, AccountName, Email, PhoneNumber,) VALUES(@FirstName, @LastName, @AccountName, @Email, @PhoneNumber)";
                String cmdText = "INSERT INTO accounts (FirstName, LastName, AccountName, Email, PhoneNumber, DateCreated, MobileNumber, OtherPhoneNumber, Fax, Title, Department, EmailOptOut) VALUES(@FirstName, @LastName, @AccountName, @Email, @PhoneNumber, @DateCreated, @MobileNumber, @OtherPhoneNumber, @Fax, @Title, @Department, @EmailOptOut)";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@AccountName", AccountName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@DateCreated", Date);
                cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                cmd.Parameters.AddWithValue("@OtherPhoneNumber", OtherPhoneNumber);
                cmd.Parameters.AddWithValue("@Fax", Fax);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.Parameters.AddWithValue("@EmailOptOut", EmailOptOut);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Accounts table has been updated with latest entries");
            }
            catch (MySqlException err) //We will capture and display any MySql errors that will occur
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close(); //safely close the connection
                }
            } //remember to safely close the connection after accessing the database




        }


    }
}
