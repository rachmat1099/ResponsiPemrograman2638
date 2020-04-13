using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2638
{
    public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }
        public void DataKaryawan()
        {
            Console.WriteLine(" {0} {1}   {2}", Nik.PadRight(11), Nama.PadRight(10), GajiBulanan);
        }
        public void NaikGaji()
        {
            Console.WriteLine(" {0} {1}   {2}", Nik.PadRight(11), Nama.PadRight(10), (GajiBulanan * 110 / 100));
        }
    }
}