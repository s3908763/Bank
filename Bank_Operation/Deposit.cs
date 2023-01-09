using System;
namespace Bank.Operation;

public class Deposit : IBase_Operation
{

    private readonly double _MIN;
    private Customer _customer;
    private List<Account> _accounts = new List<Account>();
    private int _accountNumber;
    private double _amount;

    public Deposit(Customer customer)
    {
        this._customer = customer;
    }

    public void ShowFunctionName()
    {
        Console.WriteLine("--- Deposit ---");
    }

    public void ShowAccount()
    {
        _accounts = DataSource.Account.FindByCustomerId(_customer.CustomerId);

        string msg = "";
        for (int i = 0; i < _accounts.Count; i++)
        {
            var account = _accounts[i];
            msg += $"{i + 1}, {Account.GetAccountTypeName(account.AccountType)}\t";
            msg += $"{account.AccountNumber}\t";
            msg += "$" + String.Format("{0:N2}", account.AccountBalance);
            Console.Write(msg);

        }
    }

    public void SelectAccount()
    {
        Console.Write("Select an account: ");
        //int selectedAccount;
        string? selectedAccountStr = Console.ReadLine();
        if (int.TryParse(selectedAccountStr, out int selectedAccount))
        {
            Console.WriteLine("You selected: " + selectedAccount);
        }
        else
        {
            Console.WriteLine("Cannot Convert!");
        }
    }
}

