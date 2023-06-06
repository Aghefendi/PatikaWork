using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz.");
                int sayi = Convert.ToInt32(Console.Read());
                Console.WriteLine(sayi);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

            }
            finally
            {

                Console.WriteLine("işlem tamamlandı...");

            }

            try
            {

                int a = int.Parse(null);
            }


            catch (ArgumentNullException ex) //formatexception--overflowException--
            {
                Console.WriteLine("Boş deger girdiniz...");
                Console.WriteLine(ex);

            }
        }
    }
}
