using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Elif";
            musteri1.MusteriSoyadi = "Özdemir";
            musteri1.MusteriNo =202101001;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Naciye";
            musteri2.MusteriSoyadi = "Ünver";
            musteri2.MusteriNo =202101002;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Ajdar";
            musteri3.MusteriSoyadi = "Olgun";
            musteri3.MusteriNo =202101003;

            Musteri[] musteriler = new Musteri[]{musteri1, musteri2, musteri3};

            foreach (var must in musteriler)
            {
                Console.WriteLine("Müşteri Adı-Soyadı: "+must.MusteriAdi+" "+must.MusteriSoyadi+" / Müşteri No: "+must.MusteriNo);
            }
            Console.WriteLine("----------Listeleme Tamamlandı.-----------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("----------Ekleme Tamamlandı.-----------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("----------Silme Tamamlandı.-----------");
        }
    }
}
