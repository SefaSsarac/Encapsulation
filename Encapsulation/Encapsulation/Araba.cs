using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Encapsulation
{
    public class Araba   // Araba adında bir sınıf oluşturduk
    {
        // Özellikler
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int _kapiSayisi;

        // Kapı Sayısı için Kapsülleme
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Kapı Sayısı! Kapı Sayısı sadece 2 veya 4 olabilir.");
                    _kapiSayisi = -1; // Geçersiz değer için -1 ataması yapılır
                }
            }
        }

        // Constructor (Yapıcı Metot)
        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }

        public void ArabaBilgileriniGoster()
        {
            Console.WriteLine($"Araba: Marka: {Marka}, Model: {Model}, Renk: {Renk}");

            // Kapı Sayısı -1 değilse ekranda göster
            if (KapiSayisi != -1)
            {
                Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
            }
        }
    }

}
