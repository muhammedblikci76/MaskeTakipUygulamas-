using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();
            Vatantas vatantas1 = new Vatantas();
            


            Console.ReadLine();
        }

        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 10000;
            int sayı = 100;
            bool GrisYapmısMı = false;


            string ad = "Muhammed";
            string SoyAd = "Balıkçı";
            int dogumYılı = 1998;
            long tc = 12345678910;
        }
    }


    public class Vatantas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYılı { get; set; }
        public long TcNo { get; set; }


       


    }

}
