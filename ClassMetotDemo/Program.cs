using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Çetin";
            musteri1.Yas = 25;
            musteri1.TCNo = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "Yavuz";
            musteri2.Yas = 28;
            musteri2.TCNo = "22222222222";

            MusteriManager musteriManager = new MusteriManager();
            // Eklenen Müsteri
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            Console.WriteLine("~~~ Müşteri Listesi ~~~");
            Musteri[] musteri = new Musteri[] {musteri1,musteri2};

            foreach (Musteri m in musteri)
            {
                Console.WriteLine("ID No : " + m.Id);
                Console.WriteLine("Adı : " + m.Ad);
                Console.WriteLine("Soyadı : " + m.Soyad);
                Console.WriteLine("Yaş : " + m.Yas);
                Console.WriteLine("TC No : " + m.TCNo);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            }

            // Silinen Müsteri
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.ReadKey();
        }
    }
}
