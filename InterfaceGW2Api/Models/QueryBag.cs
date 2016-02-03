using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterfaceGW2Api.Models
{
    public class QueryBag
    {
        private List<QueryResult> queryResults = new List<QueryResult>();

        public int[] Arrray = new int[] {1,4,5,2,4};

        public int[] Arrray1
        {
            get
            {
                Array.Sort<int>(Arrray);
                return Arrray;
            }
            set { Arrray = value; }
        }
        public void AddQueryResult(QueryResult result)
        {
            //Check if there is a Query with that Id in the list and replace it
            int index = queryResults.FindIndex(q => q.QueryId == result.QueryId);
            if (index >= 0)
            {
                queryResults.RemoveAt(index);
                queryResults.Insert(index, result);
            }
            else
            {
                queryResults.Add(result);
            }
        }

        public void RemoveQueryResult(int queryId)
        {
            queryResults.RemoveAll(i => i.QueryId == queryId);
        }

        public void Clear()
        {
            queryResults.Clear();
        }

        public IEnumerable<QueryResult> QueryResults
        {
            get { return queryResults; }
        } 
    }
}