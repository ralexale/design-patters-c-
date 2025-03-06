using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter.Example2
{
    public class Connection
    {

        public void Start(IRepository repository, string connectionString, string tableName)
        {
            repository.GetDatabase(connectionString);
            repository.GetTable(tableName);
        }
    }
}
