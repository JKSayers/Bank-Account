using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings_Account : Base_Account
    {
        //Fields
        private int savAccountNum;
        private decimal savAccountBalance;


        //Properties    
        public int SavAccountNum
        {
            get { return this.savAccountNum; }
            set { this.savAccountNum = value; }
        }

        public decimal SavAccountBalance
        {
            get { return this.savAccountBalance; }
            set { this.savAccountBalance = value; }
        }

        //Constructors      
        public Savings_Account(string accountHolderName) : base(accountHolderName)
        {
            this.savAccountNum = 11116349;
            this.savAccountBalance = 1143.75m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Saving_Account's OR version of Deposit()
        {
            this.savAccountBalance += dollars;
            return this.savAccountBalance;
        }

        public override decimal Withdrawal(decimal dollars)  //Savings_Account's OR version of Deposit()
        {
            this.savAccountBalance -= dollars;
            return this.savAccountBalance;
        }

        public override void ViewAccountBalance()           //Savings_Account's OR version of ViewAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + SavAccountBalance);
            Console.WriteLine("\n\n\nPress Enter to return to main menu. ");
            Console.ReadLine();
            Console.Clear();

        }


    }
}
