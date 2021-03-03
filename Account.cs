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
        public Account( double balance, string accountName, Address address):this (accountName,balance,address)
        {


        }

        public int AccountNumber
        {
           get { return this.accountNumber; }
        }



        public string AccountName
          {
            set { this.accountName = value; }
           get { return this.accountName; }
          }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
       public void Withdraw (double amount) 
        {
          if (amount>0 && amount<=balance)
            {
                this.balance -= amount;

            }
        
        }
        public void Deposite(double amount)

        {
            if (amount > 0 )
            {
                this.balance += amount;

            }

        }
        public void Transfer(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                this.balance = this.balance+amount;

            }
            else
            {
                Console.WriteLine("Monry can not transfer");
            }

        }
        public void ShowAccountInformation ()

        {
            Console.WriteLine("Account Number: \nAccount Name: \nBalance:", this.accountNumber, this.accountName, this.balance);
            Console.WriteLine("Address:" + address.GetAddress() +"\n");
        }
        ~Account()
        {
            this.Balance = 0;
        }
    }

     
}

