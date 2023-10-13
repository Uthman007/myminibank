﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myminibank
{
    internal class BankAccount
    {
		// These are fields that hold pieces of data/state, and are accessible throughout the class but not outside.
		private readonly string _firstName;
		private readonly string _lastName;
		private double _balance;
        private readonly string _accountType;
		private readonly int _accountNumber;

		// These are constants. They hold pieces of data that do not change throughout the class.
		private const int _accountNumberSeed = 1000000000;
		private const string _bankName = "ALAO BANK";

		// These are properties that make pieces of data/state available to external classes.
		//public string AccountName => $"{_firstName} {_lastName}".ToUpper();
		public int AccountNumber => _accountNumber;
		public string AccountType => _accountType.ToUpper();
		public string Bank => _bankName;

		// Define a method for opening account. We can use the constructor for this purpose
		public BankAccount()
		{
			string firstName;
			string LastName;
			double initialBalance;
			string accountType;

			Console.WriteLine("----------YOU ARE WELCOME TO ALAO BANK-----------");
			Console.WriteLine("Please create an account for yourself......!");
			Console.Write("Input your first name: ");
			firstName = Console.ReadLine();
			Console.Write("Input your last name: ");
			LastName = Console.ReadLine();
			Console.Write("Kindly type in the account type you would like to have either Current or Savings: ");
			accountType = Console.ReadLine().ToUpper();
			Console.Write("Kindly type in the amount you would like to start with: ");
			var balanceString = Console.ReadLine();
			double.TryParse(balanceString, out double doubleBalance);
			initialBalance = doubleBalance;
			_balance = initialBalance;
			_accountNumber = _accountNumberSeed + 1;
			Console.WriteLine("Congratulations your account has been created...!");
		}

		// Define a method for depositing funds
		public void DepositFunds()
		{
			Console.WriteLine("Enter an amount to deposit:");
			bool amountSuccess = double.TryParse(Console.ReadLine(), out double amount);
			// Validate the amount
			if (amountSuccess)
			{
				do
				{

					if (amount <= 0)
					{
						Console.WriteLine("Invalid amount! Kinldy ensure that 'Amount' is greater than zero.");
						return;
					}
				} while (amount <= 0);

				// Add the deposited amount to the balance
				_balance += amount;

				// Display the new balance
				DisplayBalance();
			}
            else
            {
				Console.WriteLine("Wrong Input detected. Please enter a valid input");
				Console.WriteLine();
			}
		}

		// Define a method for withdrawing funds
		public void WithdrawFunds()
		{
			Console.WriteLine("Kindly enter an amount to withdraw:");
			bool amountSuccess = double.TryParse(Console.ReadLine(), out double amount);
            if (amountSuccess)
            {
                do
                {
					// Validate the amount
					if (amount > _balance)
					{
						Console.WriteLine("Insufficient funds! Kindly enter an amount not greater than your current balance.");
						return;
					}

				} while (amount > _balance);
				
				// Deduct the withdrawn amount from the balance
				_balance -= amount;

				// Display the new balance
				DisplayBalance();

			}
			
		}

		// Define a method for displaying balance
		public void DisplayBalance()
		{
			Console.WriteLine($"Your current balance is =N={_balance}");
		}

	}
}



/*

PSEUDOCODE / ALGORITHM

1 Initialize/Open a bank account 
	- Accept customer first name and last name
	- Accept initial/opening balance
	- Accept customer's desired account type 
	- Generate an account number for the customer
	
2 Maintain a running account balance
	- Store the opening balance in a variable/field
	- Whenever funds are taken out or paid in, ensure this balance is updated
	- Never allow this balance go below zero.

3 Allow customer deposit funds into the account
	- Define a method for depositing funds

4 Allow customer withdraw funds
	- Define a method for withdrawing funds

5 Allow customer check their account balance
	- Define a method for displaying the balance

*/

