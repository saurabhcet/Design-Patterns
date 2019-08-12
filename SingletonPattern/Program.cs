using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can not create an object because of private constructor 
            // Singleton obj = new Singleton();


            ////  Get an instance of the Singleton class 
            Singleton obj = Singleton.Instance;

            //// Instance is already available, return the already created instance 
            Singleton obj2 = Singleton.Instance;

            //Is it going to work on multithreaded enviornment 
            Parallel.For(0, 5, i =>
            {
                ProcessData(i);
            });


            //// without using a sealed class 
            //Singleton.SingletonNested nestedObj1 = new Singleton.SingletonNested();
            //Singleton.SingletonNested nestedObj2 = new Singleton.SingletonNested();


            ////Get SQL instance
            IDBInstance obj3 = SQLInstance.Instance;

            //// Get Flat file instance
            IDBInstance obj4 = new FlatFileInstance();

            ////Get SQL instance
            IDBInstance obj5 = SQLInstance.Instance;

            //// Get Flat file instance
            IDBInstance obj6 = new FlatFileInstance();

            ////Calling client method
            ProcessData(obj3);
            ProcessData(obj4);
            ProcessData(obj5);
            ProcessData(obj6);  
        }
        
        private static void ProcessData(IDBInstance dbInstance)
        {
            Console.Write(dbInstance.ToString() + " started processing: ");
            dbInstance.Process();            
        }

        private static void ProcessData(int i)
        {
            Singleton obj = Singleton.Instance;
            // Write code block to process data;
            Console.WriteLine("Caller: " + i.ToString() + ", Calling ProcessData()");
        }
    }
}
