using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoCityCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvReader reader = new CsvReader();
            reader.StartReading();

            //HttpHelper helper = new HttpHelper();
            //helper.PostSensorData();



            Console.ReadLine();
        }
    }
}
