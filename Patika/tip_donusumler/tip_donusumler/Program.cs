using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Implicit Conversion
            byte a= 1;  
            sbyte b= 2; 
            short  s= 3;
            int i = a + b + s;
            Console.WriteLine("i:"+i);
            long l = i;
            Console.WriteLine("l:" + l);
            float f = l;
            Console.WriteLine("f:" + f);


            string ad = "agah";
            char ch= 'A';
            object g = ad + ch + f;
            Console.WriteLine(g);


            //Explicit Conversion Convert==parse(only string)==ToString

            int sayi = 55;
            byte sayi1 = (byte)sayi;
            Console.WriteLine(sayi1);

            int xx = 6;
            string yy=xx.ToString();

            string zz=5.6f.ToString();  
            Console.WriteLine(zz);

            string s1 = "10", s2 = "60";
            int sayi2,sayi3;

            sayi2 = Convert.ToInt32(s1);
            sayi3 = Convert.ToInt32(s2);   
            
            int sonuc=sayi2+sayi3;  
            Console.WriteLine(sonuc);


            ParseMethod(); //only string metod...


            Console.ReadLine();
            

        }

        private static void ParseMethod()
        {
            string s1 = "10";
            string s2 = "10.25";
            int rakam1;
            double reel1;

            rakam1=Int32.Parse(s1);
            reel1 = Double.Parse(s2);   
            Console.WriteLine(rakam1);  
            Console.WriteLine(reel1);   


        }
    }
}
