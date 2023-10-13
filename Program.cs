using myminibank;

Console.WriteLine();



// Display a welcome message to the user
// Setup a loop that keeps the program running until the user decides to quit/exit the system (HINT: Use a do...while loop)
// Present a menu to allow user choose a task or exit the system 
// 1 - Create an account
// 2 - Exit
// If user chooses to create an account, then prompt for the account opening details
// Display a success message upon account creation
// Present another menu to allow user choose a task or exit the system 
// 1 - Deposit funds
// 2 - Withdraw
// 3 - View balance
// 4 - Exit
// If user picks a task other than exit, then call the necessary method to perform the chosen task
// Display the menu again after completing each task
// Whenever the user chooses Exit, display a goodbye message and quit the program.




// Instantiate the BankAccount class to open an account
var account = new BankAccount();

// Display current balance
account.DisplayBalance();

Console.WriteLine();
Console.WriteLine();

int userDecision;
do
{
    int userChoice;
    do
    {
        Console.WriteLine("Welcome! What would you like to do?\n1. Deposit Account 2. Witdraw cash");
        bool userChoiceValid = int.TryParse(Console.ReadLine(), out userChoice);
        if (!userChoiceValid)
        {
            Console.WriteLine("Invalid input! Please enter a valid number");
            Console.WriteLine();
        }
    } while (userChoice != 1 && userChoice != 2);
            if (userChoice == 1)
            {  //make deposit

                account.DepositFunds();
                Console.WriteLine();
            }
            else if (userChoice == 2)
            {
                //make a withdrawal
                account.WithdrawFunds();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Wrong Input detected. Please enter a valid input");
                Console.WriteLine();
            }

                Console.WriteLine("Would you like to perform another transaction? \nEnter 1 for \"Yes\" 2 for \"No\"");
                Console.WriteLine();
                bool userDecisionSuccess = int.TryParse(Console.ReadLine(), out userDecision);
  } while (userDecision == 1);
         
            if (userDecision == 2)
            {
            Console.WriteLine("Bye! Thanks for banking with us :)");
            Console.WriteLine();
            }






