using CheckoutDealDAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAL.Models
{
    public class DAOUser
    {        
        public static User Get(int UserId)
        {
            using (MySqlConnection SqlConnection = new MySqlConnection(GlobalSettings.ConnectionString))
            {
                SqlConnection.Open();
                using (DealContext context = new DealContext(SqlConnection, false))
                {
                    return context.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                }
            }
        }
        public static List<User> Get()
        {
            using (MySqlConnection SqlConnection = new MySqlConnection(GlobalSettings.ConnectionString))
            {
                try
                {
                    using (DealContext context = new DealContext(SqlConnection, false))
                    {
                        SqlConnection.Open();
                        return context.Users.ToList();
                    }
                }
                finally {
                    SqlConnection.Close();
                }
            }
        }

        public static void AddUpdate(User user)
        {
            using (MySqlConnection SqlConnection = new MySqlConnection(GlobalSettings.ConnectionString))
            {
                using (DealContext context = new DealContext(SqlConnection, false))
                {
                    SqlConnection.Open();
                    MySqlTransaction transaction = SqlConnection.BeginTransaction();
                    // Interception/SQL logging
                    context.Database.Log = (string message) => { Console.WriteLine(message); };

                    // Passing an existing transaction to the context
                    context.Database.UseTransaction(transaction);
                    try
                    {
                        if (user.UserId <= 0)
                            context.Users.Add(user);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        SqlConnection.Close();
                    }
                }
            }
        }

        public static void Delete(int UserId)
        {
            using (MySqlConnection SqlConnection = new MySqlConnection(GlobalSettings.ConnectionString))
            {
                using (DealContext context = new DealContext(SqlConnection, false))
                {
                    SqlConnection.Open();
                    MySqlTransaction transaction = SqlConnection.BeginTransaction();
                    // Interception/SQL logging
                    context.Database.Log = (string message) => { Console.WriteLine(message); };

                    // Passing an existing transaction to the context
                    context.Database.UseTransaction(transaction);
                    try
                    {
                        context.Users.Remove(Get(UserId));
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        SqlConnection.Close();
                    }
                }
            }
        }
    }
}
