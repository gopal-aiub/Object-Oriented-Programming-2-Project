using System;

//Base Class
class Account
{
    public string accountName;
    public int id;
    public double balance;

    //Constructor
    public Account(string accountName, int id, double balance)
    {
        this.accountName = accountName;
        this.id = id;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public void Transfer(Account otherAccount, double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            otherAccount.balance = otherAccount.balance + amount;
            Console.WriteLine("Transferred: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine("Account Name: " + accountName);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Balance: " + balance);
    }
}