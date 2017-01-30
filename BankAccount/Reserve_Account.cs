using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Reserve_Account : Base_Account
    {
        //Fields
        private int resAccountNumber;
        private decimal resAccountBalance;


        //Properties    
        public int ResAccountNumber
        {
            get { return this.resAccountNumber; }
            set { this.resAccountNumber = value; }
        }

        public decimal ResAccountBalance
        {
            get { return this.resAccountBalance; }
            set { this.resAccountBalance = value; }
        }

        //Constructors      
        public Reserve_Account(string accountHolderName) : base(accountHolderName)
        {
            this.resAccountNumber = 11117384;
            this.resAccountBalance = 500.50m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Reserve_Account's OR version of Deposit()
        {
            this.resAccountBalance += dollars;
            return this.resAccountBalance;
        }

        public override decimal Withdrawal(decimal dollars)  //Reserve_Account's OR version of WithDrawal()
        {
            this.resAccountBalance -= dollars;
            return this.resAccountBalance;
        }

        public override void ViewAccountBalance()           //Reserve Account's OR version of ViewAccountBalance()
        {
            Console.WriteLine("Reserve account balance: $" + ResAccountBalance);
            Console.WriteLine("\n\n\nPress Enter to return to main menu. ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
