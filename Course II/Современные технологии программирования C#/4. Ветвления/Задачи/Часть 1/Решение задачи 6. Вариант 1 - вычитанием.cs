/* ������� 1: ��� ������ �������� �������� ���������� ���������.
 ����������� ���������� ����������, � �������:
 � ���������� �1,�2,�3 ������ ��� ������ �����. 
 ���������� ���������� A, B, C. ���������� � ��������� ����������� �� ���� �����, 
 ���������� � � �������, ���������� � � ������������ (A <= B <= C). 
 ������� ���������� A, B, C �� �����. ����� Math �� ������������.
 �������1: ������������ if.
 */ 
using System;
class MyExample
{
    public static void Main()
    {

        double x1, x2, x3,
              a, b, c;


        Console.Write("������ x1:");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("������ x2:");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("������ x3:");
        x3 = double.Parse(Console.ReadLine());


        //  ���� ����������� ��������
        if (x1 < x2 && x1 < x3)
            a = x1;
        else if (x2 < x3)
            a = x2;
        else
            a = x3;

        //  ���� ������������ ��������
        if (x1 > x2 && x1 > x3)
            c = x1;
        else if (x2 > x3)
            c = x2;
        else
            c = x3;

        //  ���� ������� ��������

        b = x1 + x2 + x3 - a - c;

        Console.WriteLine("\na={0}  b={1}  c={2}", a, b, c);

        Console.ReadLine();
    }
}
