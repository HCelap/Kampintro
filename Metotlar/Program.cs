using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Karpuz";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Diyarbakır karpuzu";

            Urun urun2 = new Urun();
            urun2.Adi = "Elma";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Amasya Elması";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("--------------Metotlar--------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle("Armut","Yeşil armut",12, 10);
            sepetManager.Ekle("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle("Karpuz", "Diyarbakır karpuzu", 12, 7);

        }
    }
}


// Metotlar , tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
//Do not repeat yourself - DRY - Clean Code - Best Practice 