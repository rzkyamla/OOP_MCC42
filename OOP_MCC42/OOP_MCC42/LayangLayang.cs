using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    public class LayangLayang : MCC42_OOP_BangunDatar
    {
        public override int Luas(int diagonal1, int diagonal2)
        {
          int hasil = 0 ;
           hasil = ((diagonal1 * diagonal2) / 2);
            return hasil;
        }
    }
}
