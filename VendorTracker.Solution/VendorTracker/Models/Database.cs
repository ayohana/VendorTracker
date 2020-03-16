using System;
using MySql.Data.MySqlClient;
using VendorTracker;

namespace VendorTracker.Models;
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}

// With this, we can now call DB.Connection() from anywhere in our application to communicate with our database.