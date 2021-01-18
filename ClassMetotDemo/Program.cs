using System;

//Ödev3
//Şimdi Github hesabınıza biraz hit alalım :)

//ClassMetotDemo isimli bir proje oluşturunuz.
//Bunu Github'a aktarınız.
//Projeniz şunu yapacak.

//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Azat";
            musteri1.Soyad = "Yılmaz";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Walter";
            musteri2.Soyad = "White";
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Jessy";
            musteri3.Soyad = "Pinkman";
            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Saul";
            musteri4.Soyad = "Goodman";

            MusteriManeger musteriManeger = new MusteriManeger();

            

            //Müşteri Ekleme Metodu

            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);
            musteriManeger.Ekle(musteri3);
            //musteriManeger.Ekle(musteri4);

            //Müşteri silme Metodu

            musteriManeger.Sil(musteri4);

            //Müşteri Listeleme Metodu

            musteriManeger.Listele();

        }
        
    }
}
