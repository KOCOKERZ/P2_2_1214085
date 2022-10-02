using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Sebuah perusahaan mempunyai sistem penggajian sebagai berikut: 

            Karyawan mendapatkan gaji pokok.
            Disamping gaji pokok, karyawan juga mendapatkan bonus dan tunjangan. 
            Potongan yang dikenakan pada karyawan adalah potongan PPH.
            Perhitungan gaji yang harus dilakukan adalah sebagai berikut :
            Gaji Pokok kalian tentukan sendiri dan menggunakan sintaks input
            Tunjangan = 20 % dari gaji pokok
            Bonus = 15 % dari gaji pokok
            PPH = 3,5 % dari gaji pokok
            Total Gaji = Gaji Pokok + Tunjangan + Bonus
            Gaji Bersih = Total Gaji – PPH 
            */

            int gajipokok = int.Parse(Console.ReadLine());
            int a = (gajipokok * 20) / 100;
            int b = (gajipokok * 15) / 100;
            double c = (gajipokok * 3.5) / 100;
            double d = (gajipokok + a + b);
            double e = (gajipokok + a + b) - c;

            Console.WriteLine("Gaji Pokok  = " + gajipokok);
            Console.WriteLine("Tunjangan   = " + a);
            Console.WriteLine("Bonus       = " + b);
            Console.WriteLine("PPH         = " + c);
            Console.WriteLine("Total Gaji  = " + d);
            Console.WriteLine("Gaji Bersih = " + e);
        }
    }
}
