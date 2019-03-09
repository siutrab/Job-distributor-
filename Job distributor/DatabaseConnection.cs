using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_distributor
{
    class DatabaseConnection
    {
        private static string ServerAdressCS = @"C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL";
        private static string JobDistributorCS = @"C:\Databases\JOB-DISTRIBUTOR.mdf";
        private string ConnectionStringJobDistributor = $"Server={ServerAdressCS};Database={JobDistributorCS};Trusted_Connection=True;";

        private void databaeConnection(string connectionString)
        {
            try
            {
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();
                System.Data.SqlClient.SqlCommand Command = new SqlCommand();

            }
            catch
            {
                throw new SystemException("no DB connection");
            }
            
        }

        public void connectDatabase()
        {
            try
            {
                this.databaeConnection(this.ConnectionStringJobDistributor);
            }
            catch(SystemException exc)
            {
                throw exc;
            }
        }

        public void disconnectDatabase()
        {

        }

        public static string ConnectionValidation(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
