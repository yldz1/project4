using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_Hata_Fırlatma_Ornek
{
    class Program
    {
        //PC : 500 gr kuruyemişi kaç kişiye paylaştıracaksınız?
        //K : ....
        //PC :Kişi başı ..... gr 
        static void Main(string[] args)
        {
            Ornek3();
            Console.ReadLine();
        }

        private static void Ornek3()
        {
            try
            {
                Console.WriteLine("500 gr kuruyemişi kaç kişiye paylaştıracaksınız?");
                int kisi = Convert.ToInt32(Console.ReadLine());
                if (kisi == 0)
                    throw new DivideByZeroException();

                double gram = 500.0 / kisi;
                Console.WriteLine("Kisi basi " + gram + " kuruyemis düşer");
            }
            catch(DivideByZeroException sifirHatasi)
            {
                Console.WriteLine("Sıfıra Bölme Hatası");
            }
            catch(FormatException formatHatasi)
            {
                Console.WriteLine("Yanlızca sayi giriniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Başka bir hata");

            }
            
        }
    }
}
