using System;
using System.Collections.Generic;
using System.Collections;

namespace genel_methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            listem<string> isimler = new listem<string>();
            isimler.Ekle("zazğa");
            Console.WriteLine(isimler.Length);
            isimler.Ekle("kerem");

            Console.WriteLine(isimler.Length);

            foreach( var isim in isimler.Items)
            {

                Console.WriteLine(isim);


            }





            //List<string> tatata = new List<string>();
            //Console.WriteLine(tatata.Count);


        }
    }
}