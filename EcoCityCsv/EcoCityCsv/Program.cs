using System;

namespace EcoCityCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvReader reader = new CsvReader();
            reader.StartReading();

            Console.ReadLine();
        }
    }
}
