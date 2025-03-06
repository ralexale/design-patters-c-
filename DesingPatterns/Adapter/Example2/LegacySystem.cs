using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter.Example2
{
    public class LegacySystem : IRepository
    {
        public void GetDatabase(string connectionString)
        {
            Console.WriteLine($"Getting database with this connectionString: {connectionString}");
        }

        public void GetTable(string tableName)
        {
            Console.WriteLine($"Getting table with this tableName: {tableName}");
        }
    }
}
