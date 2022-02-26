using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirtici geri_dnüştipi metot_adi(parametreListesi/arguman)
            //{
                /// komutları;
                // geri dönemk için de return; kulalnıyoruz
            //}

            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);
            
            metotlar ornek = new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            
            int sonuc2= ornek.ArttırVeTopla(ref a,ref b);
            // referenas vermek ne demek ave b nin degerlerini degilde bellekteki karsılıklarını veriyorum yani işaret ediyorum,Benim verdigim parametre su adreste diye test ediyorum ve değişikligi referanslar üzerinde yapıyor ve orjınal değişkenler(adresler üzerinde )değişikl yapıyor
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

            
        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);
        }
    }
    class metotlar{
       public void EkranaYazdir(string veri){
           Console.WriteLine(veri);

        }
        public int ArttırVeTopla(ref int deger1,ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
