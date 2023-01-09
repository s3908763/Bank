using System;
namespace Bank;

public class Database_Transaction : IDatabase
    {
	public Database_Transaction()
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

