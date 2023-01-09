using System;
using Microsoft.Data.SqlClient;
namespace Bank;

public class Database_Account: IDatabase
{
	public Database_Account()
	{
	}

	public int Count()
	{
		var command = "SELECT COUNT(*) AS COUNT FROM Customer";
		command
		return reader.
	}

	public void Insert()
	{

	}
}

