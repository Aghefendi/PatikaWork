using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace degisken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            string degiskenveri=null;

            Console.WriteLine(degisken);

            Console.WriteLine("");
            string degisken1 = " ";

            byte b = 5; //1 byte 
            sbyte c = 5; //1byte
            short s = 5; //2byte
            ushort us = 5; //2byte
            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //8byte
            uint u = 2; //4 byte
            long l = 2; //8byte
            ulong ul = 2;   //8byte

            //Reel Numbers

            float f = 2; //4byte
            double d = 5; //8byte
            decimal de = 5;//16byte

            char ca= 'a'; //2byte
            string str = "Agah"; //
            bool b1= true;
            bool b2= false;
            
            DateTime dt1= DateTime.Now;
            object a = "";

            object o1= 'c';
            object o2 = "C";
            object o3 = 5;
            object o4 = 4.3;

            //String ifadeler

            string str1 = string.Empty;//null
            str1 = "Agah cicek";
            string ad = "Agah";
            string soyad = "Cicek";
            string tamad = ad + "" + soyad;

            //integer
            int integer1 = 5;
            int integer2 = 3;
            int interger3 = integer1 * integer2;

            //bool
            bool comp = 10 < 2;
            bool comp2 = 10>2;

            string str20 = "20";
            int int20 = 20;

            string yenideger=str20+int20.ToString();

            Console.WriteLine(yenideger);
          
            Console.WriteLine(dt1);

            int int30 = 30;
            int int21= int20 + Convert.ToInt32(str20)+int30;
            Console.WriteLine(int21);  
            int int22=int.Parse(str20);
            
            Console.WriteLine(int22);

            string dtr=DateTime.Now.ToString("dd.MM.yyyy");
            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);

           Console.WriteLine(dtr);      

            Console.ReadLine();
            
        }
    }
}
