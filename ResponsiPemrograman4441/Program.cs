using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4441
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan karywn1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan karywn2 = new Karyawan("190302124", "Jono", 2000000);
            Console.WriteLine("No   Nik/Nama           Gaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1.   {0} {1}         {2}", karywn1.NIK, karywn1.Nama, karywn1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}          {2}", karywn2.NIK, karywn2.Nama, karywn2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Kenaikkan Gaji Sebesar 10%");
            Console.WriteLine();

            karywn1.NaikGaji(10);
            karywn2.NaikGaji(10);

            Console.WriteLine("No   Nik/Nama           Gaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1.   {0} {1}         {2}", karywn1.NIK, karywn1.Nama, karywn1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}          {2}", karywn2.NIK, karywn2.Nama, karywn2.GajiBulanan);

            Console.ReadKey();
        }
    }
}
