// ����� ����� ����������� ���������

using System;
class Program
{
    static void Main(string[] args)
    {
        double d, a, b, c;
        double x1, x2;

        Console.WriteLine("\n ������� ����������� ��������� ");
        Console.WriteLine("������ ������������ ��������� a,b,c");

        Console.Write("a=");
        a = double.Parse(Console.ReadLine());

        Console.Write("b=");
        b = double.Parse(Console.ReadLine());

        Console.Write("c=");
        c = double.Parse(Console.ReadLine());

        d = b * b - 4 * a * c;      // ������������

        Console.Write("������������ = " + d);

        if (d < 0)
            Console.Write("������ ���");
        else
        {
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("����� ��������� x1={0}  x2={1}", x1, x2);
            }
            else
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("������ ��������� x1=" + x1);
            }
        }
    }
}

