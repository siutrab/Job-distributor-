using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Job_distributor
{
    class DatabaseConnection
    {
        private MySqlConnection ActualConnection;
        private MySqlCommand ActualCommand;
        
        /// SETTERS
        private void setDatabaseConnection(IDatabase DataBaseInterface)
        {
            string connectionString = DataBaseInterface.ConnectionString;     // Getting the connection string
            string command = @"INSERT INTO `employees`(`Name`, `Surname`) VALUES ('juzio','kaluzio');";

            this.ActualConnection = new MySqlConnection(connectionString);
            this.ActualCommand = new MySqlCommand(command, this.ActualConnection);
            try
            {
                this.ActualConnection.Open();
                // Executing query
                this.ActualCommand.ExecuteReader();
                
                Console.WriteLine("dziala");

            this.ActualConnection.Close();

            }
            catch(Exception e)
            {
                throw e;                
            }
            
        }

        public void DataBaseInsert(string command)
        {
            
            
        }


        /// PUBLIC METHODS
        public void connectDatabase(IDatabase DBInterface)
        {
                this.setDatabaseConnection(DBInterface);
        }
    }

    interface IDatabase
    {
          string ConnectionString { get; }
    }

    class TaskDistriution : IDatabase
    {
        private string connectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=taskdistribution;";
        string IDatabase.ConnectionString
            {
            get { 
                return this.connectionString;
                }              
            }        
    }

    
}



