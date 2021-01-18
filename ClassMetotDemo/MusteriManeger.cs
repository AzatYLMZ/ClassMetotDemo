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
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Musteriler.Add(musteri);
            Console.WriteLine("Eklenen Müşteri : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("-------------------------");
            Console.ResetColor();
        }

        

        public void Listele()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("Müşteriler");
            foreach (var item in Musteriler)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Müşteri Id :" + item.Id);
                Console.WriteLine("Müşteri Adı :" + item.Ad);
                Console.WriteLine("Müşteri Soyadı :" + item.Soyad);
            }
            Console.WriteLine("-------------------------");
            Console.ResetColor();
        }
        
        public void Sil(Musteri musteri) 
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Musteriler.Remove(musteri);
            Console.WriteLine("Silinen Müşteri : " + musteri.Id+ " " + musteri.Ad+ " " + musteri.Soyad);
            Console.WriteLine("-------------------------");
            Console.ResetColor();
        }
        

    }
}
