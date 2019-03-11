using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;
using MySql.Data.MySqlClient;
using DatabaseManagment;

namespace Tasks
{
    class Task : IDatabaseQuerys
    {
        private int id;
        private double priority;                // Priority for creating lists
        private List<Employee> EmployeesList;   // List of employees that are working on that task
        private DateTime DeadLine;              // Data of commit of task
        private TaskType TypeOfTask;
        private int manHourPredicted;           // Settet in database, could be resetted
        private double realizationSpeedAvr;      // Calculated during realization of task
        private double realizationDegree;          // Estimated by employee at the end of the day


        // Loading from database
        public void loadFromDataBase(int id)
        {
            DatabaseQuery Query = new DatabaseQuery();
            TaskDistriution DataBase = new TaskDistriution();
            try
            {
            /// change me-> "afa"
                Query.DataBaseSelect(DataBase, $"SELECT * FROM `tasks` WHERE id={id};", this);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Initiating the values of class files
        public void initiateClassFiles(MySqlDataReader DataReader)
        {
            id = DataReader.GetInt32("id");
        }

        // Calculating the priority
        public double calculatePriority()
        {
            double a = 0;   // DELETE ME!!!
            return a;       // DELETE ME!!!
        }

        // Commiting task at the end of the day
        public void commit(int realizationDegr)
        {

        }
    }

    class TaskType
    {
        private float averageSpeed { get; set; }
        private float averageExperience;

        public float AverageExperience
        {
            get
            {
                return averageExperience;
            }
            set
            {

            }
        }
    }
}
