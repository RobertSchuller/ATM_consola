using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstATM
{
    class Program
    {
        static void Main(string[] args)
        {
            double sold = 500;
            string PIN = "1234";
            while (true)
            {
                Menu(sold, PIN);
                Console.Clear();
            }
            Console.Read();
        }

        static void Menu(double sold, string PIN)
        {
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║               Welcome to ATM               ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║          Please select an option           ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║ 1.AUTHENTIFICATION  ║   4. CHECK BALANCE   ║");
            Console.WriteLine("╠════════════════════════════════════════════║");
            Console.WriteLine("║ 2.DEPOSIT           ║   5. CHANGE PIN      ║");
            Console.WriteLine("╠════════════════════════════════════════════║");
            Console.WriteLine("║ 3.WITHDRAW          ║   6. CREATE ACCOUNT  ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.WriteLine("Press 7 to EXIT.");
            Console.Write("Please select an action: ");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Authentification(PIN);
                    break;
                case 2:
                    Deposit(sold);
                    break;
                case 3:
                    WithDraw(sold);
                    break;
                case 4:
                    CheckBalance(sold);
                    break;
                case 5:
                    ChangePin(PIN);
                    break;
                case 6:
                    CreateAccount(PIN);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;

            }
        }
        static void CreateAccount(string PIN)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to Roman ATM            ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║               CREATE ACCOUNT               ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.Write("*** First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("*** Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("*** CNP: ");
            string cnp = Console.ReadLine();
            while (cnp.Length != 13)
            {
                Console.Write("CNP Invalid. Please type a valid CNP: ");
                cnp = Console.ReadLine();
            }
            Console.Write("*** Enter a 4 digit PIN: ");
            string pin = Console.ReadLine();
            Console.Write("*** Confirm PIN: ");
            string pincheck = Console.ReadLine();
            while (pincheck != pin)
            {
                Console.Write("     The entered PIN is not valid. Please type a valid PIN: ");
                pincheck = Console.ReadLine();
            }
            if (pin == pincheck)
                Console.WriteLine("     **** WELCOME TO ATM ****");
            PIN = pin;
            Console.ReadKey();
        }
        static void ChangePin(string PIN)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to Roman ATM            ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║                CHANGE PIN                  ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.Write("Please enter current PIN: ");
            string currentpin = Console.ReadLine();
            while (currentpin != PIN)
            {
                Console.Write("PIN incorrect. Retry: ");
                currentpin = Console.ReadLine();
            }
            Console.Write("New PIN: ");
            string newpin = Console.ReadLine();
            while (newpin.Length != 4)
            {
                Console.Write("The PIN MUST have 4 digits.");
                newpin = Console.ReadLine();
            }
            Console.Write("PIN set succesfully !");
            PIN = newpin;
            Console.ReadKey();
        }
        static void CheckBalance(double sold)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to ATM                  ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║               CHECK BALANCE                ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("           Your Balance is: {0:00.00} $", sold);
            Console.ReadKey();
        }
        static void WithDraw(double sold)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to ATM                  ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   1.  10$  ║                 ║   2.  20$   ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   3.  50$  ║                 ║   4.  100$  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   5. 200$  ║                 ║   6.  500$  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   7. 1000$ ║                 ║   8. OTHER  ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("*** How much would you like to withdraw? ***");
            char input = char.Parse(Console.ReadLine());
            switch (input)
            {
                case '1':
                    if (sold >= 10)
                        Console.WriteLine("Your new Balance is {0} $", sold - 10);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '2':
                    if (sold >= 20)
                        Console.WriteLine("Your new Balance is {0} $", sold - 20);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '3':
                    if (sold >= 50)
                        Console.WriteLine("Your new Balance is {0} $", sold - 50);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '4':
                    if (sold >= 100)
                        Console.WriteLine("Your new Balance is {0} $", sold - 100);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '5':
                    if (sold >= 200)
                        Console.WriteLine("Your new Balance is {0} $", sold - 200);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '6':
                    if (sold >= 500)
                        Console.WriteLine("Your new Balance is {0} $", sold - 500);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '7':
                    if (sold >= 1000)
                        Console.WriteLine("Your new Balance is {0} $", sold - 1000);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case '8':
                    Console.Write("Other: ");
                    string withdraw = Console.ReadLine();
                    int x = int.Parse(withdraw);
                    if (sold > x)
                        Console.WriteLine("Your new Balance is {0} $", sold - x);
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
            }
            Console.ReadKey();
        }
        static void Deposit(double sold)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to ATM                  ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   1.  10$  ║                 ║   2.  20$   ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   3.  50$  ║                 ║   4.  100$  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   5. 200$  ║                 ║   6.  500$  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║   7. 1000$ ║                 ║   8. OTHER  ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("*** How much would you like to deposit? ***");
            char input = char.Parse(Console.ReadLine());
            switch (input)
            {
                case '1':
                    Console.WriteLine("Your new Balance is {0} $", sold + 10);
                    sold += 10;
                    break;
                case '2':
                    Console.WriteLine("Your new Balance is {0} $", sold + 20);
                    sold += 20;
                    break;
                case '3':
                    Console.WriteLine("Your new Balance is {0} $", sold + 50);
                    sold += 50;
                    break;
                case '4':
                    Console.WriteLine("Your new Balance is {0} $", sold + 100);
                    sold += 100;
                    break;
                case '5':
                    Console.WriteLine("Your new Balance is {0} $", sold + 200);
                    sold += 200;
                    break;
                case '6':
                    Console.WriteLine("Your new Balance is {0} $", sold + 500);
                    sold += 500;
                    break;
                case '7':
                    Console.WriteLine("Your new Balance is {0} $", sold + 1000);
                    sold += 1000;
                    break;
                case '8':
                    Console.Write("Other: ");
                    string deposit = Console.ReadLine();
                    int x = int.Parse(deposit);
                    Console.WriteLine("Your new Balance is {0} $", sold + x);
                    sold += x;
                    break;
            }
            Console.ReadKey();
        }
        static void Authentification(string PIN)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║            Welcome to ATM                  ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║              AUTHENTIFICATION              ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.Write("*** First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("*** Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("*** PIN: ");
            string pin = Console.ReadLine();
            int cnt = 3;
            while (pin != PIN && cnt != 0)
            {
                Console.Write("PIN incorrect. {0} tries left: ", cnt);
                pin = Console.ReadLine();
                cnt--;
                if (cnt == 0)
                    Console.Write("Your card has been retained. Please alert the closest bank.");
            }
            if (cnt == 0)
                Console.Write("Your card has been retained. Please alert the closest bank.");
            else
                Console.WriteLine("Welcome {0} {1} !", firstName, lastName);
            Console.ReadKey();
        }
    }
}
