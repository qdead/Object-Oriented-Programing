using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Programing_1
{
    class InkomstInfo
    {
        public string Namn { get; set; }
        public int Timmar { get; set; }
        public int Inkomst { get; set; }

        public int Timmlön { get { return Inkomst / Timmar;  } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InkomstInfo inkomstInfo = new InkomstInfo();
            Console.Write("Vad är ditt namn: ");
            inkomstInfo.Namn = Console.ReadLine();
            Console.Write("Skriv din Inkomst: ");
            inkomstInfo.Inkomst = int.Parse(Console.ReadLine());
            Console.Write("Skriv dina timmar jobbade: ");
            inkomstInfo.Timmar = int.Parse(Console.ReadLine());
            Console.WriteLine("Din timmlön är " + inkomstInfo.Timmlön + " kr/h");
            Console.ReadKey();
        }
    }
}
