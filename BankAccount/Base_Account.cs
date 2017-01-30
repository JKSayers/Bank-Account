using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Base_Account
    {
        //Fields
        private string bankMemberName;
        private decimal balance;
        private string address = "22990 Schlami Ave Kromulon, Nebraska 32012";
        private string email = "Squanchtastic223@Meemail.com";
        private string phone = "(555) 555-4488";
        private int accountNumber;

        //Properties
        public string BankMemberName
        {
            get { return this.bankMemberName; }
            set { this.bankMemberName = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public Base_Account(string bankMemberName)
        {
            this.BankMemberName = bankMemberName;
        }
        //Methods

        public virtual decimal Deposit(decimal dollars)  //Virtual for the derived classes to override(OR)
        {
            this.balance += dollars;
            return balance;
        }

        public virtual decimal Withdrawal(decimal dollars)  //Virtual for the derived classes to override(OR)
        {
            this.balance -= dollars;
            return balance;
        }

        public virtual void ViewAccountBalance()            //Virtual fot the derived classes to override(OR)
        {
            Console.WriteLine("Balance: " + balance);

        }

        public void MemberInfo()
        {
            Console.WriteLine("Name: " + bankMemberName);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Member since: 05/22/2004");

            Console.WriteLine("\n\n\nPress Enter to return to main menu. ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

