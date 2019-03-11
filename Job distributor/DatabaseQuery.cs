using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Tasks;

namespace DatabaseManagment
{
    interface IDatabaseQuerys
    {
        void loadFromDataBase(int id);
        void initiateClassFiles(MySqlDataReader DataReader);
    }

    class DatabaseQuery
    {
        private MySqlConnection ActualConnection;
        private MySqlCommand ActualCommand;
        private MySqlDataReader ActualDataReader;
        private delegate void loadFromDatabase(MySqlDataReader DataReader);


        public void DataBaseSelect(IDatabase DataBaseInterface, string command, IDatabaseQuerys IQuerys)
        {
            string connectionString = DataBaseInterface.ConnectionString;     // Getting the connection string
            ActualConnection = new MySqlConnection(connectionString);
            ActualCommand = new MySqlCommand(command, ActualConnection);
            ///loadFromDatabase loadDelegate = new loadFromDatabase(loading());
            try
            {
                this.ActualConnection.Open();
                // Executing query and sending the response to ActualDataReader object
                ActualDataReader = ActualCommand.ExecuteReader();

                // Reading values from database after SELECT query
                if(ActualDataReader.Read())
                {
                    IQuerys.initiateClassFiles(ActualDataReader);
                }

                ActualConnection.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DataBaseInsert(IDatabase DataBaseInterface, string command)
        {
            string connectionString = DataBaseInterface.ConnectionString;     // Getting the connection string
            // command = @"INSERT INTO `employees`(`Name`, `Surname`) VALUES ('juzio','kaluzio');";

            this.ActualConnection = new MySqlConnection(connectionString);
            this.ActualCommand = new MySqlCommand(command, this.ActualConnection);
            try
            {
                this.ActualConnection.Open();
                // Executing query
                this.ActualCommand.ExecuteReader();
                

            this.ActualConnection.Close();

            }
            catch(Exception e)
            {
                throw e;
            }           
        }
    }

    interface IDatabase
    {
          string ConnectionString { get; }
    }

    class TaskDistriution : IDatabase
    {
        private static string connectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=taskdistribution;";
        string IDatabase.ConnectionString
        {
        get { 
            return connectionString;
            }              
        }        
    }
}



