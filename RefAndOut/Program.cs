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

            double numeric;
            Console.WriteLine("Çarpma İşlemi Sonucu: "+Multiplication(1,2.5));
            Console.WriteLine("Değişim ile Çarpma İşlemi Sonucu: "+Multiplication2(out numeric,number2));

            Console.ReadLine();


        }
    }
}
