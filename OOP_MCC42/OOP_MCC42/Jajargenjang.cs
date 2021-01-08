using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    public class Jajargenjang : MCC42_OOP_BangunDatar
    {
        public override int Luas(int alas, int tinggi)
        {
            int hasil = 0;
            hasil = alas * tinggi;
            return hasil;
        }
    }
}
