using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Bank
    {
        private string bankName;
        Account [] myBank;

        public Bank( string bankName , int size )
        {
            this.bankName = bankName;
            this.myBank = new Account[size];

        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {

                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }

        public void DeleteAccount(int accountNo)
        {
            int count = 0;
            for (int i = 0; i < myBank.Length; i++)
            {

                if (myBank[i].AccountNumber == accountNo)
                {
                    for (int j = 0; j < (myBank.Length - 1);j++)
                    {
                        myBank[i] = myBank[j = 1];
                        break;
                    }
                    count++;
                    break;
                }

            }
        }
            public void Transaction()
        {

        }

        public void PrintAccountDetails(int accountNo)
        {
            for (int i = 0; i < myBank.Length; i++)
            {

                if(myBank[i].AccountNumber == accountNo)
                {
                    myBank[i].ShowAccountInformation();
                    break;
                }
            }
        }

        public void PrintAllAccount()
        {
            for (int i = 0; i < myBank.Length; i++)
            {

                if (myBank[i] == null)
                {
                    myBank[i].ShowAccountInformation();
                    
                }
            }
        }

    }
}
