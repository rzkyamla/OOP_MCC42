using System;

namespace OOP_MCC42
{
   public class Program
    {
        static void Main(string[] args)
        {
            int angka1;
            int angka2;

            MCC42_OOP_BangunDatar persegi = new MCC42_OOP_BangunDatar();
            PersegiPanjang persegipanjang = new PersegiPanjang();
            Jajargenjang jajargenjang = new Jajargenjang();
            Segitiga segitiga = new Segitiga();
            LayangLayang layanglayang = new LayangLayang();

            Console.WriteLine("===========OPERASI BANGUN DATAR==========");
            Console.Write("Masukkan angka ke-1 : ");
            angka1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan angka ke-2 : ");
            angka2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n1. Persegi: " + persegi.Luas(angka1, angka2));
            Console.WriteLine("2. Persegi Panjang: " + persegipanjang.Luas(angka1, angka2));
             Console.WriteLine("3. Jajargenjang: " + jajargenjang.Luas(angka1, angka2));
            Console.WriteLine("4. Segitiga: " + segitiga.Luas(angka1, angka2));
            Console.WriteLine("5. Layang-Layang: " + layanglayang.Luas(angka1, angka2));
        }
    }
}
