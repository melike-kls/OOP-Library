using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{
    class Program
    {

       public static void Main(string[] arg )
        {

            Console.Write("HOŞGELDİNİZ..");
            string yazi = Console.ReadLine();

            Console.Write("Kaç Araba Bilgisi Gireceksiniz?");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string dosya_yolu = @"C:\Arabaa.txt";
            FileStream fs = new FileStream( dosya_yolu, FileMode.OpenOrCreate);
            File.SetAttributes(dosya_yolu, FileAttributes.Normal);
            StreamWriter sw = new StreamWriter(fs);
            

            for (int i = 0; i < sayi; i++)
            {

                string marka;
                int model;
                int motor;
                string vites;
                string renk;

                try
                {
                    Console.WriteLine($"\n{i + 1 }.Marka Giriniz: ");
                    marka = Convert.ToString(Console.ReadLine());

                    Console.WriteLine($"\n{ i + 1 }.Model Giriniz: ");
                    model = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n{ i + 1 }.Motor Gücü Giriniz: ");
                    motor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n{ i + 1 }.Vites Türünü Giriniz: ");
                    vites = Convert.ToString(Console.ReadLine());

                    Console.WriteLine($"\n{ i + 1 }.Renk Giriniz: ");
                    renk = Convert.ToString(Console.ReadLine());
       

                sw.WriteLine(" Marka: {0} \n Model: {1}  \n Motor: {2} \n Vites: {3} \n Renk: {4}", marka, model, motor, vites, renk);
                
                Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Yanlış Değer Girdiniz!!",e);

                }
            }

        }



    }
}
