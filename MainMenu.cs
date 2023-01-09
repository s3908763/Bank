using System;
namespace Bank;

public class MainMenu
{
    public MainMenu()
    {
    }

    public void showMainMenu()
    {
        string mainMenu = """
            [1] Deposit
            [2] Withdraw
            [3] Transer
            [4] My Statement
            [5] Logout
            [6] Exit

            """;
        Console.WriteLine(mainMenu);
    }
}

