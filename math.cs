using System;

namespace twit
{
    public class math
    {
        static public void summ(double x, double y)
        {
            double summ = x + y;
            Console.WriteLine("Сумма = " + summ);
            Console.ReadLine();
        }
        static public void min(double x, double y)
        {
            double min = x - y;
            Console.WriteLine("Разность = " + min);
            Console.ReadLine();
        }
        static public void mult(double x, double y)
        {
            double mult = x * y;
            Console.WriteLine("Произведение = " + mult);
            Console.ReadLine();
        }
        static public void div(double x, double y)
        {
            double div = x / y;
            Console.WriteLine("Частное = " + div);
            Console.ReadLine();
        }
        static public void sbox(double x)
        {
            double sbox = Math.Pow(x, 2);           
            Console.WriteLine("S квадрата по стороне = " + sbox);
            Console.ReadLine();
        }
        static public void sboxdiag(double x)
        {
            double sboxdiag = Math.Pow((x/2), 2);
            Console.WriteLine("S квадрата по его диагонали = " + sboxdiag);
            Console.ReadLine();
        }

        static public void scircleR(double r)
        {
            double scircle = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("S круга через радиус = " + scircle);
            Console.ReadLine();
        }
        static public void scircleD(double d)
        {
            double scircle = Math.PI * (Math.Pow(d, 2) / 4 );
            Console.WriteLine("S круга через диаметр = " + scircle);
            Console.ReadLine();
        }
        static public void sparall(double a, double h)
        {
            double sparall = a * h;
            Console.WriteLine("Длина = " + a);
            Console.WriteLine("Высота = " + h);
            //Площадь параллелограмма равна произведению длины его стороны и длины опущенной на эту сторону высоты.
            Console.WriteLine("S параллелограмма по длине стороны и высоте = " + sparall);
            Console.ReadLine();
        }

        static public void sparallsin(double a, double b, double sin)
        {
            double sinus = Math.PI * sin / 180; // перевод радиан в градусы.
            double sparallsin = a * b * Math.Sin(sinus);  // Нахождение площади.
            Console.WriteLine("Сторона 1 = " + a);
            Console.WriteLine("Сторона 2 = " + b);
            Console.WriteLine("Sin = " + Math.Sin(sinus));
            //Площадь параллелограмма равна произведению длин его сторон умноженному на синус угла между ними.
            Console.WriteLine("S параллелограмма по двум сторонам и углу между ними = " + sparallsin);
            Console.ReadLine();
        }
        static public void sparalldiag(double a, double b, double sin)
        {
            
            double sinus = Math.PI * sin / 180;
            double sparalldiag = 1/2 * (a * b * Math.Sin(sinus));
            Console.WriteLine("Диагональ 1 = " + a);
            Console.WriteLine("Диагональ 2 = " + b);
            Console.WriteLine("Sin(a) = " + Math.Sin(sinus));
            //Площадь параллелограмма равна половине произведения длин его диагоналей умноженному на синус угла между ними.
            Console.WriteLine("S параллелограмма по двум диагоналям и углу между ними = " + sparalldiag);
            Console.ReadLine();
        }

    }
}
