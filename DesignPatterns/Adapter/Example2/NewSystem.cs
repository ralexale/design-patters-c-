using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter.Example2
{
    public class NewSystem
    {

        public void GetDatabaseWithApiKey(string apiKey)
        {
            Console.WriteLine($"Getting database with this apiKey: {apiKey}");
        }

        public void GetTable(string tableName)
        {
            Console.WriteLine($"Getting table with this apiKey: {tableName}");
        }
    }
}
