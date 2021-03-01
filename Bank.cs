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


    }
}
