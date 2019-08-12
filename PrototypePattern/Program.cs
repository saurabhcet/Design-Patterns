using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPrototype carBase = new Ford {
                                         Model ="Ford",
                                         Color = "White",
                                         Price = 500000 };
       
         
            Ford fordXSeries = (Ford)carBase.Clone();
            fordXSeries.Model += "X Series";            
            fordXSeries.Price += 50000;
            fordXSeries.Color = "Metallic Blue";

            Ford fordZSeries = (Ford)carBase.Clone();
            fordZSeries.Model += "Z Series";            
            fordZSeries.Price += 75000;
            fordZSeries.Color = "Metallic Red";

            Console.WriteLine("Quotation: {0} is available in {1}, Price:{2}", fordXSeries.Model, fordXSeries.Color, fordXSeries.Price, Ford.Frame);
            Console.WriteLine("Quotation: {0} is available in {1}, Price:{2}", fordZSeries.Model, fordZSeries.Color, fordZSeries.Price, Ford.Frame);

            carBase.Price += 5000;
            carBase.Color = "White Chromium";
            CarPrototype.Frame = "Oval";
        }
    }
}


