/*  �������3: ��������� ��� ��������� ���������.
 ����������� ���������� ����������, � �������:
 � ���������� �1,�2,�3 ������ ��� ������ �����. 
 ���������� ���������� A, B, C. ���������� � ��������� ����������� �� ���� �����, 
 ���������� � � �������, ���������� � � ������������ (A <= B <= C). 
 ������� ���������� A, B, C �� �����. ����� Math �� ������������.
 
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


        // ��� ��������� ��������� (6):
        //     x1<x2<x3
        //     x1<x3<x2

        //     x2<x1<x3
        //     x2<x3<x1

        //     x3<x1<x2
        //     x3<x2<x1

        if (x1 < x2 && x2 < x3)
        {  a = x1; b = x2; c = x3;}

        else if (x1 < x2 && x3 < x2)
        {  a = x1; b = x3; c = x2;}

        else if (x2 < x1 && x1 < x3)
        {   a = x2; b = x1; c = x3;}

        else if (x2 < x3 && x3 < x1)
        {   a = x2; b = x3; c = x1;}

        else if (x3 < x1 && x1 < x2)
        {   a = x3; b = x1; c = x2; }

        else
        {   a = x3; b = x2; c = x1; }


        Console.WriteLine("\na={0}  b={1}  c={2}", a, b, c);

        Console.ReadLine();
    }
}
