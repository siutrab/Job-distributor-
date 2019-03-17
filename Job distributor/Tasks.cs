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
    class Task : StoredType<Task>
    {
        private int id;
        private double priority;                // Priority for creating lists
        private List<Employee> EmployeesList;   // List of employees that are working on that task
        private DateTime DeadLine;              // Data of commit of task
        private TaskType TypeOfTask;
        public int manHourPredicted;            // Setted in database, could be resetted
        private double realizationSpeedAvr;     // Calculated during realization of task
        private double realizationDegree;       // Estimated by employee at the end of the day

    /// CONSTRUCTORS AND FACTORIES
        // NOT ELEGANT, COSMETICS NEEDED
        // Needed for TaskCollection object to create a list of Task objects
        private Task(DataRow dataRow)
        {
            id = int.Parse(dataRow["id"].ToString());
            DeadLine = DateTime.Parse(dataRow["deadline"].ToString());
            manHourPredicted = int.Parse(dataRow["man_hour"].ToString());
            realizationSpeedAvr = double.Parse(dataRow["realization_speed_avr"].ToString());
            realizationDegree = double.Parse(dataRow["realization_degree"].ToString());
        }

        public Task createInstance(DataRow dataRow)
        {
            Tasks.Task task = new Tasks.Task(dataRow);
            return task;
        }

        public Task()
        {
            
        }

    /// METHODS

        // REWRITE ME!
        // Calculating the priority
        private double calculatePriority()
        {
            double a = 0;   // DELETE ME!!!
            return a;       // DELETE ME!!!
        }

        // Commiting task at the end of the day
        private void commit(int realizationDegr)
        {

        }
    }

    class TaskCollection
    {
        public List<Task> ListOfTasks = new List<Task>();

        public DataTable dataTable = new DataTable();

        DatabaseQuery databaseQuery = new DatabaseQuery();
        TaskDistriutionDatabase DataBase = new TaskDistriutionDatabase();

        public TaskCollection()
        {
            string command = "SELECT * FROM `tasks`;";
            dataTable = databaseQuery.selectQuery(DataBase, command);
            createTaskList();
        }

        public void createTaskList()
        {
            StoredType<Task> storedType = new Task();
            ListOfTasks = DataBaseCollections.toList<Task>(dataTable, storedType);
        }

    }

    class TaskType : StoredType<TaskType>
    {
        private int id;
        private double averageSpeed;
        // private double averageExperience;
        
    // CONSTRUCTORS AND FACTORIES
        public TaskType createInstance(DataRow dataRow)
        {
            TaskType taskTypeObject = new TaskType(dataRow);
            return taskTypeObject;
        }
        
        private TaskType(DataRow dataRow)
        {
            id = int.Parse(dataRow["id"].ToString());
            averageSpeed = double.Parse(dataRow["average_speed"].ToString());
        }
    }
}
