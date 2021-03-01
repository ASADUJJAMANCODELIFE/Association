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

        public int AccountNumber;
          {
           get
          }
         


         
         
     

    }

     
}

