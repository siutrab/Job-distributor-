using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_distributor
{
    class SqlQueries
    {
    }
    interface IQuery
    {
        // Create SQL query string
        string composeQuery();
    }

    class SelectQuery : IQuery
    {
        private string query;


        // SELECT * FROM
        public SelectQuery(string from)
        {
            query = $"SELECT * FROM {from};";
        }

        // SELECT * FROM ... WHERE...
        public SelectQuery(string from, string where)
        {
            query = $"SELECT * FROM {from} WHERE {where};";
        }

        //public SelectQuery(string what, string from)
        //{
        //    query
        //    }

        public SelectQuery(string what, string from, string where)
        {

        }

        public string composeQuery()
        {
            return query;
        }
    }

}
