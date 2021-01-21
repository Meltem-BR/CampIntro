using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product x)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + x.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }
    }
}
