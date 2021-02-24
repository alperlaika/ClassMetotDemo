using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Eklendi:" + musteriler.Adi+ " " + musteriler.Soyadi);
        }
        public void Sil(Musteri musteriler)
        {
            Console.WriteLine("Silindi:" + musteriler.Adi + " " + musteriler.Soyadi);
        }
      
    }
}
