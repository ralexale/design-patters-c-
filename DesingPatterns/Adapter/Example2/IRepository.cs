using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter.Example2
{
    public interface IRepository
    {
        void GetDatabase(string connectionString);
        void GetTable(string tableName);

    }
}
