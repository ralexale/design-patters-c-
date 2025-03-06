using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter.Example2
{
    public class Orm : IRepository
    {
        public readonly NewSystem newSystem;

        public Orm(NewSystem newSystem)
        {
            this.newSystem = newSystem;
        }
        public void GetDatabase(string connectionString)
        {
            newSystem.GetDatabaseWithApiKey(connectionString);
        }

        public void GetTable(string tableName)
        {
            newSystem.GetTable(tableName);
        }
    }
}
