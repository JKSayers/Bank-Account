using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking_Account : Base_Account
    {
        //Fields
        private int chkAccountNum;
        private decimal chkAccountBalance;


        //Properties    
        public int ChkAccountNumber
        {
            get { return this.chkAccountNum; }
            set { this.chkAccountNum = value; }
        }

        public decimal ChkAccountBalance
        {
            get { return this.chkAccountBalance; }
            set { this.chkAccountBalance = value; }
        }

        //Constructors      
        public Checking_Account(string accountHolderName) : base(accountHolderName)
        {
            this.chkAccountNum = 11119384;
            this.chkAccountBalance = 4477.80m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Checking_Account's OR version of Deposit()
        {
            this.chkAccountBalance += dollars;
            return this.chkAccountBalance;
        }

        public override decimal Withdrawal(decimal dollars)  //Checking_Account's OR version of Withdrawal()
        {
            this.chkAccountBalance -= dollars;
            return this.chkAccountBalance;
        }

        public override void ViewAccountBalance()           //Checking_Account's OR version of ViewAccountBalance()
        {
            Console.WriteLine("Checking account balance: $" + ChkAccountBalance);
            Console.WriteLine("\n\n\nPress Enter to return to main menu. ");
            Console.ReadLine();
            Console.Clear();

        }



    }
}

