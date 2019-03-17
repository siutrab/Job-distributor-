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
       // private static MySqlDataReader DataReaderDB;

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

    interface StoredType<T>
    {
        T createInstance(DataRow dataRow);
    }

    class DataBaseCollections
    {
        // Creating list of objects. 
        // There is requirement for createInstance() method inherited from StoredType<T> interface.
        // That method should be a factory, that creates an object from a table row.
        public static List<T> toList<T>(DataTable dataTable, StoredType<T> storedType)
        {
            List<T> itemList = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                itemList.Add(storedType.createInstance(row));
            }
            return itemList;
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



