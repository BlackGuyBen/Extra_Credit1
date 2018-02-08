using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {

            //string custID;
            string keepGoing;

            List<String> custList = new List<String>();
            List<String> custInfo = new List<String>();

            Customer newCustomer = new Customer();

            const string CompanyFile = "CustumerRecords.txt";

            FileStream outFile = new FileStream(CompanyFile,
FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter("CustomerRecords.txt");


            Console.WriteLine("Problem 4 - A from the book");
            Console.WriteLine("Do you have a customer to enter? (Y/N)");
            //customer = Convert.ToInt32(Console.ReadLine());

            keepGoing = Console.ReadLine();
            keepGoing = keepGoing.ToUpper();

            while (keepGoing == "Y")
            {
                Console.WriteLine("What is the customers name:");
                newCustomer.customer = Console.ReadLine();
                Console.WriteLine("What is their ID number?");
                newCustomer.IDnum = Console.ReadLine();
                Console.WriteLine("What is the amount owed:");
                newCustomer.balance = Console.ReadLine();
                Console.WriteLine("");

                custInfo.Add(newCustomer.customer);
                custInfo.Add(newCustomer.IDnum);
                custInfo.Add(newCustomer.balance);

                foreach (string element in custInfo)
                writer.WriteLine(custInfo);

                Console.WriteLine("Would you like to enter another customer? (Y/N)");
                keepGoing = Console.ReadLine();
                keepGoing = keepGoing.ToUpper();
                
            }

            



            writer.Close();

            /* for (int x = 0; x<cust_num;x++)
             {
                 Console.WriteLine("What is the name of customer",x);
                 customer = Console.ReadLine();
                 custList.Add(customer);



                 Console.WriteLine("Enter the customer's information seperated by a comma. (DO NOT type the balance owed with commas.)");
                 custData = Console.ReadLine();
                 custInfo.Add(custData);*/
        }
            
    }
    public class Customer
    {
        public string customer { get; set; }

        public string IDnum { get; set; }

        public string balance { get; set; }
    }
}
