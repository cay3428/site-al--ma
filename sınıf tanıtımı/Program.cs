using System;

namespace sınıf_tanıtımı
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "kişiliksiz insan";
            int başkalaşım = 46;

            seçim seçim1 = new seçim();
            seçim1.Eğitmen = "Cellat";
            seçim1.Yargı = "infaz";
            seçim1.Seçimoranı = 54;


            seçim seçim2 = new seçim();
            seçim2.Eğitmen = "ÇarpanCin";
            seçim2.Yargı = "son";
            seçim2.Seçimoranı = 23;



            seçim seçim3 = new seçim();
            seçim3.Eğitmen = "Ağlayan Çimento";
            seçim3.Yargı = "kahkaha";
            seçim3.Seçimoranı = 94;



            seçim seçim7 = new seçim();
            seçim7.Eğitmen = "boş timsah";
            seçim7.Yargı = "çığılık";
            seçim7.Seçimoranı = 43;



            seçim seçim4 = new seçim();
            seçim4.Eğitmen = "yumuşak kirpi";
            seçim4.Yargı = "ağlama";
            seçim4.Seçimoranı = 79;



            seçim seçim5 = new seçim();
            seçim5.Eğitmen = "havlayan köpek";
            seçim5.Yargı = "ısırma";
            seçim5.Seçimoranı = 13;



            seçim seçim6 = new seçim();
            seçim6.Eğitmen = "öküz";
            seçim6.Yargı = "bakakalma";
            seçim6.Seçimoranı = 50;

            //Console.WriteLine(seçim1.Yargı + "  : " + seçim1.Eğitmen);





        }


    }
    class seçim
    {
        public string Yargı { get; set; }

        public string Eğitmen { get; set; }

        public int Seçimoranı { get; set; }





    }
}

