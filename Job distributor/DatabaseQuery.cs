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
    class DatabaseQuery
    {
        private static MySqlConnection ConnectionDB;
        private static MySqlCommand CommandDB;
        private static MySqlDataReader DataReaderDB;

        private void setDatabaseConnection(IDatabase DataBase, string command)
        {
            string connectionString = DataBase.ConnectionString;     // Getting the connection string
            ConnectionDB = new MySqlConnection(connectionString);
            CommandDB = new MySqlCommand(command, ConnectionDB);
        }

        public MySqlDataReader selectQuery(IDatabase DataBase, string command)
        {
            setDatabaseConnection(DataBase, command);

            try
            {
                ConnectionDB.Open();
                DataReaderDB = CommandDB.ExecuteReader();   // Executing query and sending the response to ActualDataReader object
                return DataReaderDB;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DataBaseQuery(IDatabase DataBase, string command)
        {
            setDatabaseConnection(DataBase, command);
            try
            {
                ConnectionDB.Open();        // Opening db connection
                CommandDB.ExecuteReader();  // Executing command
                ConnectionDB.Close();       // Closing db connection
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

    class TaskDistriutionDatabase : IDatabase
    {
        private static string connectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=taskdistribution;";
        public string ConnectionString
        {
            get
            { 
                return connectionString;
            }              
        }        
    }
}



