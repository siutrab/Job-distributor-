using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace Tasks
{
    class Tasks
    {
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
