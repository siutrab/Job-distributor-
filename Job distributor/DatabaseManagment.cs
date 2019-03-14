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
            ConnectionDB = new MySqlConnection(DataBase.ConnectionString);
            CommandDB = new MySqlCommand(command, ConnectionDB);
        }


        public DataTable selectQuery(IDatabase DataBase, string command)
        {
            

            try
            {
                MySqlConnection connection = new MySqlConnection(DataBase.ConnectionString);    
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        

        public void DataBaseQuery(IDatabase DataBase, string command)
        {
            ConnectionDB = new MySqlConnection(DataBase.ConnectionString);
            CommandDB = new MySqlCommand(command, ConnectionDB);

            setDatabaseConnection(DataBase, command);
            try
            {
                ConnectionDB.Open();
                CommandDB.ExecuteReader();  // Executing command
                ConnectionDB.Close();       
            }
            catch(Exception e)
            {
                throw e;
            }           
        }
    }
    abstract class StoredType
    {
        abstract public T createFromTableRow<T>(DataRow dataRow);
    }

    class DataBaseCollection
    {
        public static List<StoredType> toList(DataTable dataTable)
        {
            List<T> TasksList = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            
                TasksList.Add(storedType.createFromTableRow(row));
            }
            return TasksList;
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



