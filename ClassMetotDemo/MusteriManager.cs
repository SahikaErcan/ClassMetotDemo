using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("~~~ Eklenen Müşteri ~~~~");
            Console.WriteLine(musteri.Id + "\n" + musteri.Ad + " " + musteri.Soyad);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("~~~ Silinen Müşteri ~~~~");
            Console.WriteLine(musteri.Id + "\n" + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
