using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.

namespace ClassMetotDemo
{
    class MusteriManeger
    {
        List<Musteri> Musteriler = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            Musteriler.Add(musteri);
            Console.WriteLine("Eklenen Müşteri : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
        }

        

        public void Listele()
        {
            Console.WriteLine("Müşteriler");
            foreach (var item in Musteriler)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Müşteri Id :" + item.Id);
                Console.WriteLine("Müşteri Adı :" + item.Ad);
                Console.WriteLine("Müşteri Soyadı :" + item.Soyad);
            }
        }
        
        public void Sil(Musteri musteri) 
        {
            Musteriler.Remove(musteri);
            Console.WriteLine("Silinen Müşteri : " + musteri.Id+ " " + musteri.Ad+ " " + musteri.Soyad);
        }


    }
}
