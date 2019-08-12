using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public interface IDBInstance
    {
       void Process();
    }

    public class SQLInstance : IDBInstance
    {
        private static readonly IDBInstance instance = new SQLInstance();
        private static int instanceCounter;

        private SQLInstance()
        {
            instanceCounter++;
            Console.WriteLine("SQL Instance created :" + instanceCounter);
        }

        public static IDBInstance Instance
        {
            get
            {
                return instance;
            }
        }

        public void Process()
        {
            Console.WriteLine("Processing SQL data");
        }
    }

    public class FlatFileInstance : IDBInstance
    {
        private static int instanceCounter;
        public FlatFileInstance()
        {
            instanceCounter++;
            Console.WriteLine("Flat File Instance created :" + instanceCounter);
        }

        public void Process()
        {
            Console.WriteLine("Processing Flat File data");
        }
    }
}
