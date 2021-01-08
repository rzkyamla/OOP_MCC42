using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    public class PersegiPanjang : MCC42_OOP_BangunDatar
    {
        public override int Luas(int Angka1, int Angka2)
        {
            int hasil;
            hasil = Angka1 * Angka2;
            return hasil;
        }
    }
}
