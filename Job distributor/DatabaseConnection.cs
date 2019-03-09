using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_distributor
{
    class DatabaseConnection
    {
        //private static string ServerAdressCS = @"C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL";
        //private static string JobDistributorCS = @"C:\Databases\JOB-DISTRIBUTOR.mdf";
        //private string ConnectionStringJobDistributor = $"Server={ServerAdressCS};Database={JobDistributorCS};Trusted_Connection=True;";

        //private SqlConnection ActualConnection;

        
        /// SETTERS
        private void setDatabaseConnection(IDatabase DBInterface)
        {
            string connectionString = DBInterface.ConnectionString;     // Getting the connection string

            try
            {

                SqlConnection ActualConnection = new SqlConnection(connectionString);
                //this.ActualConnection.ConnectionString = connectionString;
                ActualConnection.Open();
                Console.WriteLine("dziala");
               

            }
            catch
            {
                Console.WriteLine("dupa");
                throw new SystemException("no DB connection");
                
            }
            
        }


        /// PUBLIC METHODS
        public void connectDatabase(IDatabase DBInterface)
        {
                this.setDatabaseConnection(DBInterface);
        }

        public void disconnectDatabase()
        {

        }

    }

    interface IDatabase
    {
          string ConnectionString { get; }
    }

    class JobDistriutor : IDatabase
    {
        private static string ServerAdressCS = @"C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL";
        private static string JobDistributorCS = @"C:\Databases\JOB-DISTRIBUTOR.mdf";
        //private string connectionString = $"Server={ServerAdressCS};Database={JobDistributorCS};Trusted_Connection=True;";
        private string connectionString = @"Data Source=LAPTOP-BARTEK\SQLEXPRESS01;Initial Catalog=JOB-DISTRIBUTOR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //@"Data source=SERWER\SQLEXPRESS; database=adresy; User id=sa; Password=haslo;"
        string IDatabase.ConnectionString
            {
            get { 
                return this.connectionString;
                }              
            }        
    }

}



