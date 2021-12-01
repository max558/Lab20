using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    /*
     * В приложении объявить тип делегата, который ссылается на метод. 
     * Требования к сигнатуре метода следующие: 
     * -       метод получает входным параметром переменную типа double;
     * -       метод возвращает значение типа double, которое является результатом вычисления. 
     * 
     * Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют: 
     * -       длину окружности по формуле D = 2 * π* R;
     * -       площадь круга по формуле S = π* R²;
     * -       объем шара. Формула V = 4/3 * π * R³. 
     * 
     * Методы должны быть объявлены как статические.
     */
    class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            
            MyDelegate myDelegate = LengthCircle;
            Result(myDelegate);
            myDelegate = ScuareCircle;
            Result(myDelegate);
            myDelegate = VolCircle;
            Result(myDelegate);


            Console.ReadKey();
        }
        static void Result(MyDelegate deleg)
        {
            double res = 0;
            if (deleg != null)
            {
                res = deleg(5.5);
                Console.WriteLine(res);
            }
        }

        static double LengthCircle(double r)
        {
            double res = 0;
            res = 2 * r * Math.PI;
            return res;
        }
        static double ScuareCircle(double r)
        {
            double res = 0;
            res = Math.PI * Math.Pow(r, 2);
            return res;
        }
        static double VolCircle(double r)
        {
            double res = 0;
            res = Math.PI * Math.Pow(r, 3) * 4 / 3;
            return res;
        }
    }
}
