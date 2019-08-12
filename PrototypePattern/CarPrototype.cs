using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class CarPrototype
    {
        public static string Frame { get; set; }

        public string Model { get; set; }        

        public int Price { get; set; }

        public string Color { get; set; }

        public abstract CarPrototype Clone();
    }

    public class Ford : CarPrototype
    {
        public override CarPrototype Clone()
        {
            // Creates a shallow copy of the current Object
            return (Ford)this.MemberwiseClone();           
        }
    }
}
