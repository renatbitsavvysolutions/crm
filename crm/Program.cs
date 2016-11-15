using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crm
{
    class Program
    {
        static void Main(string[] args)
        {

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
            //c1.printClass();









            // String str = @"server=localhost;database=sugar_daddy_crm;userid=root;password=Pdee!871;";
            String str = @"server=bitsavvy-crm-dev.crvxjxsnep6q.us-west-2.rds.amazonaws.com;database=sugar_daddy_crm;userid=administrator;password=Pdee!871;";
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
               // cmd.Parameters.AddWithValue("@Id", 3);
                cmd.Parameters.AddWithValue("@FirstName", c1.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c1.LastName);
                cmd.Parameters.AddWithValue("@AccountName", c1.AccountName);
                cmd.Parameters.AddWithValue("@Email", c1.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", c1.PhoneNumber);
                cmd.Parameters.AddWithValue("@DateCreated", c1.Date);
                cmd.Parameters.AddWithValue("@MobileNumber", c1.MobileNumber);

                cmd.Parameters.AddWithValue("@OtherPhoneNumber", c1.OtherPhoneNumber);

                cmd.Parameters.AddWithValue("@Fax", c1.Fax);

                cmd.Parameters.AddWithValue("@Title", c1.Title);

                cmd.Parameters.AddWithValue("@Department", c1.Department);
                cmd.Parameters.AddWithValue("@EmailOptOut", c1.EmailOptOut);




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



        

            Console.ReadLine();
            
        }
    }
}
