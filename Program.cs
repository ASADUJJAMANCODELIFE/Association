using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {

        static void Main(string[] args)
        {
            Bank bank = new Bank("____Developer's Bank______", 5);// create bank object and define bank name , number of bank account
            Address address = new Address("10", "1230/A", " Dhaka ", " Bangladesh");//assign address value
            Account account = new Account("prince", 5000, address); // create list account object

            bank.AddAccount(account); // add 1st created account
            bank.PrintAccountDetails(1); //print 1 st account
        }
    }
}
