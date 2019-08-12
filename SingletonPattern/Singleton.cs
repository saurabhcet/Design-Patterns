using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private static int instanceCounter;

        private Singleton()
        {
            instanceCounter++;
            Console.WriteLine("Instances created :" + instanceCounter);
        }

        public static Singleton Instance
        {
            get 
            {
                return instance;
            }
        }

        //// you can inherit the Singleton class if it is not sealed 
        //public class SingletonNested : Singleton
        //{             
        //    public SingletonNested()
        //        : base()
        //    {
        //    }
        //} 

    }
  
}
