using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        private static int count = 1; 

        public Account()
        {
            this.accountNumber = count;
            count++;
        }

        public Account(string accountName, double balance, Address address) : this()
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public Account(string accountName, double balance, Address address) : this(accountName, address, balance)
        {


        }

        public int AccountNumber
          {
           get { return this.accountNumber; }
        }



        public string AccountName
          {
            set { this.accountName = value; }
           get { return this.accountName}
          }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance}
        }
       public void Withdraw (double amount) 
        {
        
        
        }
        public void Deposite(double amount)

        {

        }
            public void Transfer(double amount)
        {

        }
           public void showAccountAllInformation ()

        {
            Console.WriteLine("Account Number: \nAccount Name: \nBalance:", this.accountNumber, this.accountName, this.balance);
            Console.WriteLine("Address:" + address.GetAddress() +"\n");
        }

    }

     
}

