/*  ����������, ����� �� ����� ��������� A(x1,y1), B(x2,y2), C(x3,y3) 
    �����������  ����� � ������ ���������.
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string n;
        double x1, y1, x2, y2, x3, y3,     // ����������
       p1, p2, p3,          // ���������� �� ������
       k;

        Console.Write("������� ���������� X ������ �����: ");
        x1 = double.Parse(Console.ReadLine());
        Console.Write("������� ���������� Y ������ �����: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("������� ���������� X ������ �����: ");
        x2 = double.Parse(Console.ReadLine());
        Console.Write("������� ���������� Y ������ �����: ");
        y2 = double.Parse(Console.ReadLine());

        Console.Write("������� ���������� X ������� �����: ");
        x3 = double.Parse(Console.ReadLine());
        Console.Write("������� ���������� Y ������� �����: ");
        y3 = double.Parse(Console.ReadLine());


        p1 = Math.Sqrt(x1 * x1 + y1 * y1);
        p2 = Math.Sqrt(x2 * x2 + y2 * y2);
        p3 = Math.Sqrt(x3 * x3 + y3 * y3);

        k = p1; n = "������";
        if (k > p2) { k = p2; n = "������"; }
        if (k > p3) { k = p3; n = "������"; }

        Console.WriteLine("{0} ����� ����� ���� � ������ ��������� \n", n);
    }
}



