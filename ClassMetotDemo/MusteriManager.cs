using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri ekleme)
        {
            Console.WriteLine(ekleme.adi +" "+ ekleme.soyadi + " Bankamıza Hoş geldiniz ");
        }
        public void Silme(Musteri silme)
        {
            Console.WriteLine(silme.adi + " Bankamızı kulandığınız için teşekür ederiz");
        }
        public void listeleme(Musteri liste)
        {
            Console.WriteLine(liste.id + ". sıralı müşterimiz");
        }

    }
}
