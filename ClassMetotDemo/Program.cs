namespace ClassMetotDemo;
class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.id = 1;
        musteri1.musteriAdi = "Jack";
        musteri1.musteriSoyadi = "Elsa";
        musteri1.musteriAdresi = "3455 Saint James Drive, Windsor Mill, MD, Maryland, 78580";

        Musteri musteri2 = new Musteri();
        musteri2.id = 2;
        musteri2.musteriAdi = "Michell";
        musteri2.musteriSoyadi = "Stedmand";
        musteri2.musteriAdresi = "1742 West Street, Comstock Park, MI, Michigan, 49321";

        Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

        foreach (var musteri in musteriler)
        {
            Console.WriteLine(musteri.musteriAdi);
        }

        MusteriManager musteriManager = new MusteriManager();

        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);

        musteriManager.Cikar(musteri1);
        musteriManager.Cikar(musteri2);

        musteriManager.Listele(musteriler);
    }
}
