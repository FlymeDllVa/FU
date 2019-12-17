using System;

class Program
{
    static void Main(string[] args)
    {
        double h, w, a, b, c, min1, min2;

        Console.Write("������� ������ �����: ");
        h = Double.Parse(Console.ReadLine());

        Console.Write("������� ������ �����: ");
        w = Double.Parse(Console.ReadLine());

        Console.Write("\n������� ����� ������ ������� �������:  ");
        a = Double.Parse(Console.ReadLine());

        Console.Write("������� ����� ������ ������� �������:  ");
        b = Double.Parse(Console.ReadLine());

        Console.Write("������� ����� ������� ������� �������: ");
        c = Double.Parse(Console.ReadLine());

        // ����������� ����� ��������� �������.
        min1 = Math.Min(a, b);
        min2 = Math.Min(a + b - min1, c);

        // �������� ����� ��������� �������.
        if (h >= min1 && w >= min2 || h >= min2 && w >= min1)      
            Console.WriteLine("\n������� ������� � �����! �������: " 
                + min1 + ", " + min2);
        else
            Console.WriteLine("������� �� ������� � �����");

        Console.ReadKey();
    }
}
