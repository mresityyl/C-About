using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*
            try
            {
             Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi:" + sayi);   
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:"+ ex.Message.ToString());
            }
            finally
            {
               Console.WriteLine("İşlem tamamlandı.");
            }*/

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı.");
            }



            Console.ReadLine();

        }
    }
}
