using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;
using MySql.Data.MySqlClient;
using DatabaseManagment;
using TaskDistributor;
using System.Data;

namespace Tasks
{
    class Taskss : StoredType
    {
        private int id;
        private double priority;                // Priority for creating lists
        private List<Employee> EmployeesList;   // List of employees that are working on that task
        private DateTime DeadLine;              // Data of commit of task
        private TaskType TypeOfTask;
        public int manHourPredicted;           // Settet in database, could be resetted
        private double realizationSpeedAvr;      // Calculated during realization of task
        private double realizationDegree;          // Estimated by employee at the end of the day

    /// CONSTRUCTORS AND FACTORIES
        // NOT ELEGANT, COSMETICS NEEDED
        // Needed for TaskCollection object to create a list of Taskss objects
        private Taskss(DataRow dataRow)
        {
            id = int.Parse(dataRow["id"].ToString());
            DeadLine = DateTime.Parse(dataRow["deadline"].ToString());
            manHourPredicted = int.Parse(dataRow["man_hour"].ToString());
            realizationSpeedAvr = double.Parse(dataRow["realization_speed_avr"].ToString());
            realizationDegree = double.Parse(dataRow["realization_degree"].ToString());
        }

        public override Taskss createFromTableRow<Taskss>(DataRow dataRow)
        {
            StoredType task = new Tasks.Taskss(dataRow);
            Taskss t = task;
            return task;
        }

        public Taskss()
        {
            
        }

    /// METHODS

        //// Loading from database
        //public void selectfromDB()
        //{
        //    DatabaseQuery Query = new DatabaseQuery();
        //    TaskDistriutionDatabase DataBase = new TaskDistriutionDatabase();
        //    MySqlDataReader DataReader;
        //    try
        //    {

        //        DataReader = Query.selectQuery(DataBase, $"SELECT * FROM `tasks` WHERE id={id};");
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;
        //    }

        //    if(DataReader.Read())
        //    {
        //    id = DataReader.GetInt32("id");
        //    DeadLine = DataReader.GetDateTime("deadline");
        //    // Task Type!!!
        //    manHourPredicted = DataReader.GetInt32("man_hour");
        //    realizationSpeedAvr = DataReader.GetDouble("realization_speed_avr");
        //    realizationDegree = DataReader.GetDouble("realization_degree");
        //    }

        //}

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

    class TaskCollection
    {
        public List<Taskss> ListOfTasks = new List<Taskss>();

        public DataTable dataTable = new DataTable();

        DatabaseQuery databaseQuery = new DatabaseQuery();
        TaskDistriutionDatabase DataBase = new TaskDistriutionDatabase();

        public TaskCollection()
        {
            string command = "SELECT * FROM `tasks`;";
            dataTable = databaseQuery.selectQuery(DataBase, command);
            ListOfTasks = createTaskList();

        }

        public List<Taskss> createTaskList()
        {
            List<Taskss> TasksList = new List<Taskss>();
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    TasksList.Add(new Taskss(row));
            //}
            DataBaseCollection.toList<Taskss>(dataTable, );
            return TasksList;
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
