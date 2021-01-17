using System;

namespace RefAndOut
{
    class Program
    {
        static double Division(double number1,double number2)
        {
            double result =Math.Abs(number1 / number2);
            return result;
        }
        //Parametreli normal bir bölme methodu tanımladım ve bana verilen iki değeri girerek basitçe böldüm.
        //Varsayalım ki ben bu iki sayıyı yine aynı girdim ama DivisionTwo methodunu sadece 2 ye bölmek için kullanabiliyorum.
        //O zaman ref anahtar sözcüğünü kullanarak, sonucumu etkileyebilirim.
        //Girdiğim değer kaç olursa olsun, ben sadece bu değerin referansını alayım adresinin altında da değer tipini
        //değiştirebileyim ve işlemlerimi bu şekilde yürütebileyim.
        static double DivisionTwo(double number1,ref double number2)
        {
            number2 = 2;
            double result = Math.Abs(number1 / number2);
            return result;
        }
        static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        static double Multiplication2(out double num1, double num2)
        {
            num1 = 2;
            double result = num1 * num2;
            return result;
        }


        static void Main(string[] args)
        {
            double number1 = 40;
            double number2 = 4;

            Console.WriteLine("Bölme İşlemi Sonucu: "+Division(number1, number2));
            //Console.WriteLine("Ref Kullanmadan Şartlı İşlem Sonucu: "+DivisionTwo(12.50, 2.50)); 
            Console.WriteLine("Değişim ile Bölme İşlemi sonucu: "+DivisionTwo(number1,ref number2));


            //Satır 31 de "Argument 2 must be passed with the 'ref' keyword"hatası aldık
            /*---------------NEDEN?----------------
             Hatamız bize,"Bir bağımsız değişken için ref anahtar sözcüğü kullanmam gerektiğini" belirtiyor, Peki bu ne demek?
             Ref-Out anahtar sözcükleri metodlarımız içerisinde bağımsız değişkenleri iletmek için kullanılır.İkisinin amacı aynıdır,farkı ise değişken tanımlama zorunluluğudur.
             Bunu örneğimizde görüyoruz; "ref" anahtar sözcüğü ile tanımladığım metodumun(Division2 method) ilk parametresi için main içerisinde ne kadar tipine uygun bir 
             değişken göndersem de "Sen artık referansını aldım diye, tanımladığın bu değişken için gönderdiğin değer de referans tipli olmalı" diye bana kızıcaktır.
             Peki normal bir bölme işlemi yaparken neden bunu kullanmayı tercih ettik?
             Olası bir şart durumunda(sadece 2 ye bölünebilir şartı) farklı bir işlem diyip tekrar yeni bir değişken tanımlamak yerine referansını alarak bellekte zaten var olan verimi
             kullanabilmek için.
             Out anahtar sözcüğü de bir bakıma bu sorunumuzun çözümü niteliğinde.Out anahtar sözcüğünün farkı ise;
             ben değişkenime bir değer atamasam da(number2 ye verdiğimiz 4 değeri gibi), "ref" in bana verdiği bu zorunluluğu
             ortada kaldırarak ilgili methodu çağırmam da bir sorun yaratmayacağını söyler.Out bizim içimize bir su serpti öyle değil mi?
             Amaa tabi Out un da bize sorun yaratacağı kısmı var; biz bölme methodlarında 2 ye böl şartı gelmediği sürece normal bölme yapabiliyorduk.Ya bize bir şart vermeden
             sadece methodumuzu çağırmamız istenirse?
             Bu sefer sadece methodumuzun içinde ki değişkenlerimiz ile işlem yapabiliceğiz.(Çarpma örneğinde olduğu gibi)
             */
            double numeric;
            Console.WriteLine("Çarpma İşlemi Sonucu: "+Multiplication(1,2.5));
            Console.WriteLine("Değişim ile Çarpma İşlemi Sonucu: "+Multiplication2(out numeric,number2));
            /*1 ve 2,5 değeri gönderdim ve çarpma methodu çalıştı
             * null bir numeric değerini out anahtar sözcüğüyle ve zaten tanımlı olan number2=4 ü parametre gönderdim;
             * out numeric parametresi metodumun içinde tanımlı olan num değerimi aldı ve işleme soktu, değişen tek şey referansımın numeric olmasıydı.
             */

            Console.ReadLine();


        }
    }
}
