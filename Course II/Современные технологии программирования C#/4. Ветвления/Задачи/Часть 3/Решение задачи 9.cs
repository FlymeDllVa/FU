// ��������� ���������, ����������� ������, ������ �� ��������  
// ��������� A,B � ������� ��������� X,Y.

using System;
class Program
{
    static void Main(string[] args)
    {
        int t, a, b, x, y;
        Console.Write("������� ������ �������� : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("������� ������ �������� : ");
        b = int.Parse(Console.ReadLine());

        Console.Write("������� ������ �������� : ");
        x = int.Parse(Console.ReadLine());

        Console.Write("������� ������ �������� : ");
        y = int.Parse(Console.ReadLine());

        if (b > a) { t = a; a = b; b = t; }
        if (y > x) { t = x; x = y; y = t; }
        if ((x >= a) & (y >= b))
            Console.WriteLine("�������� ������ � ������� .");
        else
            Console.WriteLine("�������� �� ������ � ������� .");

    }
}

