﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2638
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1.", "190302123", "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("2.", "190302124", "Jono", 2000000);
            Console.WriteLine("NIK/Nama                   Gaji Bulanan");
            Console.WriteLine("---------------------------------------");
            karyawan1.DataKaryawan();
            karyawan2.DataKaryawan();
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10 %");
            Console.WriteLine();
            karyawan1.NaikGaji();
            karyawan2.NaikGaji();

            Console.ReadKey();
        }
    }
}