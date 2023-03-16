using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " " + "müşteriler listesine eklendi");
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " " + "müşteriler listesinden çıkartıldı");
        }
        public void Listele(Musteri[] musteriler)
        {

            Console.WriteLine("Müşteriler listelendi: " + " " + musteriler.Length + " " + "müşteri mevcut");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriAdi);
            }

        }
    }
}


