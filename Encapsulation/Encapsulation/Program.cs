using Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        // Geçerli Kapı Sayısı ile Araba Nesnesi Oluşturma
        Araba araba1 = new Araba("BMW", "3 Serisi", "Siyah", 4);
        araba1.ArabaBilgileriniGoster();

        // Geçersiz Kapı Sayısı ile Araba Nesnesi Oluşturma
        Araba araba2 = new Araba("Audi", "A3", "Beyaz", 3);
        araba2.ArabaBilgileriniGoster();
    }
}