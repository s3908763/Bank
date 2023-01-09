using System;
namespace Bank;

public class Database_Login : IDatabase
{
	public Database_Login()
	{
	}

    int IDatabase.Count()
    {
        throw new NotImplementedException();
    }

    void IDatabase.Insert()
    {
        throw new NotImplementedException();
    }
}

