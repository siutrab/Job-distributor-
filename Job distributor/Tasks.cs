using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;
using MySql.Data.MySqlClient;
using DatabaseManagment;
using TaskDistributor;

namespace Tasks
{
    class TaskToDo
    {
        private int id;
        private double priority;                // Priority for creating lists
        private List<Employee> EmployeesList;   // List of employees that are working on that task
        private DateTime DeadLine;              // Data of commit of task
        private TaskType TypeOfTask;
        public int manHourPredicted;           // Settet in database, could be resetted
        private double realizationSpeedAvr;      // Calculated during realization of task
        private double realizationDegree;          // Estimated by employee at the end of the day

        public TaskToDo(int TaskID)
        {
            id = TaskID;    
            selectfromDB(); // loading task from db
        }



        // Loading from database
        public void selectfromDB()
        {
            DatabaseQuery Query = new DatabaseQuery();
            TaskDistriutionDatabase DataBase = new TaskDistriutionDatabase();
            MySqlDataReader DataReader;
            try
            {

                 DataReader = Query.selectQuery(DataBase, $"SELECT * FROM `tasks` WHERE id={id};");
            }
            catch(Exception e)
            {
                throw e;
            }

            if(DataReader.Read())
            {
            id = DataReader.GetInt32("id");
            DeadLine = DataReader.GetDateTime("deadline");
            // Task Type!!!
            manHourPredicted = DataReader.GetInt32("man_hour");
            realizationSpeedAvr = DataReader.GetDouble("realization_speed_avr");
            realizationDegree = DataReader.GetDouble("realization_degree");
            }

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

    class TaskList
    {
        public List<TaskToDo> ListOfTasks = new List<TaskToDo>();
        int listLength;

        DatabaseQuery databaseQuery = new DatabaseQuery();
        TaskDistriutionDatabase DataBase = new TaskDistriutionDatabase();
        MySqlDataReader DataReader;
        
        public TaskList()
        {
            string command = "SELECT COUNT(`id`) FROM `tasks`;";    // Selecting the length of table

            DataReader = databaseQuery.selectQuery(DataBase, command);
            if(DataReader.Read())
            {   
                listLength = DataReader.GetInt32(0);    // result of above command is a single integral number, so GetInt at 0 position (there are no further ositions!)
            }

            for(int i=1; i<listLength; i++)
            {
                ListOfTasks.Add(new TaskToDo(i));
            }
            
            
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
