using System;

class Program
{
    static void Main(string[] args)
    {
        double h, w, a, b, c;

        Console.WriteLine("������� ������ �����");
        h = Double.Parse(Console.ReadLine());

        Console.WriteLine("������� ������ �����");
        w = Double.Parse(Console.ReadLine());

        Console.WriteLine("������� ������ �������");
        a = Double.Parse(Console.ReadLine());

        Console.WriteLine("������� ������ �������");
        b = Double.Parse(Console.ReadLine());

        Console.WriteLine("������� ����� �������");
        c = Double.Parse(Console.ReadLine());


        if (h >= a && w >= b || h >= b && w >= a      // �������� ����� �������
            || h >= a && w >= c || h >= c && w >= a   // �������� ������ �������
            || h >= b && w >= c || h >= c && w >= b)  // �������� ������� �������
            Console.WriteLine("������� ������� � �����");
        else
            Console.WriteLine("������� �� ������� � �����");

        Console.ReadKey();
    }
}
