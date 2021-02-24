using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Projeniz şunu yapacak.
             Bir bankada müşteri takibi yapmak istiyorsunuz.
             Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
             MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak
             Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
             */
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ayşe";
            musteri1.Soyadi = "Alp";
            musteri1.Tc =45678966444;
            musteri1.Yasi = 45;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Veli";
            musteri2.Soyadi = "Oruçoğlu";
            musteri2.Tc =45678912348;
            musteri2.Yasi = 78;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Özgür";
            musteri3.Soyadi = "Koç";
            musteri3.Tc = 78945632178;
            musteri3.Yasi =27;

            Musteri musteri4= new Musteri();
            musteri4.Adi = "Melek";
            musteri4.Soyadi = "Özkan";
            musteri4.Tc = 85236914791;
            musteri4.Yasi = 23;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("--------- MUSTERILERIN LISTESI --------------");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Musterinin Tc'si:  " + musteri.Tc);
                Console.WriteLine("Musterinin Adi: " + musteri.Adi);
                Console.WriteLine("Müsterinin Soyadi:   " + musteri.Soyadi);
                Console.WriteLine("Müsterinin Yasi:   " + musteri.Yasi);
                Console.WriteLine("-----------------------\n");

            }



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Sil(musteri3);

        }
    }
}
