using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Sabri";
            musteri1.soyadi = "uzunay";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.adi = "Tunahan";
            musteri2.soyadi = "Bayrakçeken";

            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri1);
            musteriManager.listeleme(musteri2);
        }
    }
}
