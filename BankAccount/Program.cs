using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create text file for each account
            StreamWriter swReserve = new StreamWriter("Reserve.txt");
            StreamWriter swSavings = new StreamWriter("Savings.txt");
            StreamWriter swChecking = new StreamWriter("Checking.txt");


            //Prompt user for name
            Console.WriteLine("Welcome to Schwifty Savings and Loan Online Banking");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Please enter your name to login \n\n");
            Console.Write("Customer name: "); string customerName = Console.ReadLine();
            Console.Clear();


            //Instantiates each account
            Reserve_Account Res = new Reserve_Account(customerName);
            Savings_Account Sav = new Savings_Account(customerName);
            Checking_Account Chk = new Checking_Account(customerName);


            //txt file for each account
            swReserve.WriteLine("Customer: " + customerName);
            swReserve.WriteLine("Account Type: Reserve");
            swReserve.WriteLine("Account #: " + Res.ResAccountNumber);
            swReserve.WriteLine("Balance: $" + Res.ResAccountBalance);
            swReserve.WriteLine(" ");

            swChecking.WriteLine("Customer: " + customerName);
            swChecking.WriteLine("Account Type: Checking");
            swChecking.WriteLine("Account #: " + Chk.ChkAccountNumber);
            swChecking.WriteLine("Balance: $" + Chk.ChkAccountBalance);
            swChecking.WriteLine(" ");

            swSavings.WriteLine("Customer: " + customerName);
            swSavings.WriteLine("Account Type: Savings");
            swSavings.WriteLine("Account #: " + Sav.SavAccountNum);
            swSavings.WriteLine("Balance: $" + Sav.SavAccountBalance);
            swSavings.WriteLine(" ");

            //menu loop
            while (true)
            {
                //menu
                Menu();

                //switch case for action selector 
                string selector = Console.ReadLine();
                Console.Clear();


                switch (selector)
                {
                    case "1":
                        Header();
                        Sav.MemberInfo();
                        continue;


                    case "2":
                        Header();
                        Chk.ViewAccountBalance();
                        continue;


                    case "3":
                        Header();
                        Sav.ViewAccountBalance();
                        continue;


                    case "4":
                        Header();
                        Res.ViewAccountBalance();
                        continue;

                    case "5":
                        //deposit to:
                        Header();
                        Console.WriteLine("Where would you like to make a deposit?\n\n\n");
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine("\t1: Checking Account");
                        Console.WriteLine("\t2: Savings Account");
                        Console.WriteLine("\t3: Reserve Account");

                        //amount to deposit block
                        string depChoice = Console.ReadLine();
                        Console.Clear();
                        Header();
                        Console.WriteLine("How much would you like to deposit?");

                        decimal deposit = decimal.Parse(Console.ReadLine());


                        switch (depChoice)
                        {
                            case "1":
                                Chk.Deposit(deposit);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Checking Account balance is $" + Chk.ChkAccountBalance);
                                Console.WriteLine("Checking Account #:" + Chk.ChkAccountNumber);
                                swChecking.WriteLine("+ $" + deposit + " " + DateTime.Now);
                                swChecking.WriteLine("Account Balance: $" + Chk.ChkAccountBalance);
                                swChecking.WriteLine(" ");
                                break;


                            case "2":
                                Sav.Deposit(deposit);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Savings Account balance is $" + Sav.SavAccountBalance);
                                Console.WriteLine("Savings Account #:" + Sav.SavAccountNum);
                                swSavings.WriteLine("+ $" + deposit + " " + DateTime.Now);
                                swSavings.WriteLine("Account Balance: $" + Sav.SavAccountBalance);
                                swSavings.WriteLine(" ");
                                break;


                            case "3":
                                Res.Deposit(deposit);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Reserve Account balance is $" + Res.ResAccountBalance);
                                Console.WriteLine("Reserve Account #:" + Res.ResAccountNumber);
                                swReserve.WriteLine("+ $" + deposit + " " + DateTime.Now);
                                swReserve.WriteLine("Account Balance: $" + Res.ResAccountBalance);
                                swReserve.WriteLine(" ");
                                break;


                            default:
                                Console.Clear();
                                Header();
                                Console.WriteLine("Invalid selection. Press Enter to return to main menu. ");
                                Console.ReadLine();
                                Console.Clear();
                                continue;



                        }
                        break;


                    case "6":
                        //withdrawal from:
                        Header();
                        Console.WriteLine("Withdraw from: ");
                        Console.WriteLine("\t1: Checking Account");
                        Console.WriteLine("\t2: Savings Account");
                        Console.WriteLine("\t3: Reserve Account");

                        //amount to withdrawal block
                        string withdrawalChoice = Console.ReadLine();
                        Console.Clear();
                        Header();
                        Console.WriteLine("How much would you like to withdrawal?");


                        decimal withdrawal = decimal.Parse(Console.ReadLine());


                        switch (withdrawalChoice)
                        {
                            case "1":
                                Chk.Withdrawal(withdrawal);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Checking Account balance is $" + Chk.ChkAccountBalance);
                                Console.WriteLine("Checking Account #:" + Chk.ChkAccountNumber);
                                swChecking.WriteLine("- $" + withdrawal + " " + DateTime.Now);
                                swChecking.WriteLine("Account Balance: $" + Chk.ChkAccountBalance);
                                swChecking.WriteLine(" ");

                                break;


                            case "2":
                                Sav.Withdrawal(withdrawal);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Savings Account balance is $" + Sav.SavAccountBalance);
                                Console.WriteLine("Savings Account #:" + Sav.SavAccountNum);
                                swSavings.WriteLine("- $" + withdrawal + " " + DateTime.Now);
                                swSavings.WriteLine("Account Balance: $" + Sav.SavAccountBalance);
                                swSavings.WriteLine(" ");
                                break;


                            case "3":
                                Res.Withdrawal(withdrawal);
                                Console.Clear();
                                Header();
                                Console.WriteLine("Your new Reserve Account balance is $" + Res.ResAccountBalance);
                                Console.WriteLine("Reserve Account #:" + Res.ResAccountNumber);
                                swReserve.WriteLine("- $" + withdrawal + " " + DateTime.Now);
                                swReserve.WriteLine("Account Balance: $" + Res.ResAccountBalance);
                                swReserve.WriteLine(" ");
                                break;

                            default:
                                Console.Clear();
                                Header();
                                Console.WriteLine("Invalid selection. Press Enter to return to main menu. ");
                                Console.ReadLine();
                                Console.Clear();
                                continue;


                        }
                        break;

                    case "9":
                        //quits to ask if they want to do anything else
                        break;


                    default:
                        Console.Clear();
                        Header();
                        Console.WriteLine("Invalid selection. Press Enter to return to main menu. ");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                }


                Console.WriteLine("\n\n\nWould you like to continue? Y or N?");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() == "y")
                {
                    //return to menu
                    Console.Clear();
                }
                else if (yesOrNo.ToLower() == "n")
                {
                    //quits the program
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Press Enter to return to main menu. ");
                    Console.ReadLine();
                    Console.Clear();

                }

            }


            //closes the streamwriters
            swReserve.Close();
            swSavings.Close();
            swChecking.Close();


            Quit();

            Console.ReadKey();
        }
        //Main ends here/////////////

        //METHODS
        //quit method
        static void Quit()
        {
            Console.WriteLine("Thanks for using Schwifty Savings and Loan Online Banking, have a squanchy day.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        //menu method
        static void Menu()
        {
            Console.WriteLine("\n\nSchwifty Savings and Loan Online Banking\n\n");
            Console.WriteLine("___________________________________");
            Console.WriteLine("To View Account info: Enter 1\n");
            Console.WriteLine("View Account Balance: ");
            Console.WriteLine("\tFor Checking: Enter 2 ");
            Console.WriteLine("\tFor Savings : Enter 3 ");
            Console.WriteLine("\tFor Reserve : Enter 4 \n");
            Console.WriteLine("To make a deposit   : Enter 5 ");
            Console.WriteLine("To make a withdrawal: Enter 6 \n");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter 9 to EXIT");
            Console.WriteLine("___________________________________");
        }
        //page header method
        static void Header()
        {
            Console.WriteLine("\n\nSchwifty Savings and Loan Online Banking\n\n");
            Console.WriteLine("___________________________________");

        }



    }
}
