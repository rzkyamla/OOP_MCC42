using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    public class MCC42_OOP_BangunDatar
    {
        private int angka1;
        private int angka2;
        public int Angka1 
        {
            set 
            {
                value = angka1;
            }
            get 
            {
                return angka1;
            }
        }
        public int Angka2 
        {
            set 
            {
                value = angka2;
            }
            get 
            {
                return angka2;
            }
        }
        public virtual int Luas(int Angka1, int Angka2) 
        {
            int hasil = 0;
            hasil = Angka1 * Angka1;
            return hasil;
        }
    }


}
