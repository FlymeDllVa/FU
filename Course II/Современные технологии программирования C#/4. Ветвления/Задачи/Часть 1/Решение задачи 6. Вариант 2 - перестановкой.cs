/*   ������� 2: ���������� ����� ���������� ���������� (�������).
 * ����������� ���������� ����������, � �������:
 * � ���������� �1,�2,�3 ������ ��� ������ �����. ���������� ���������� A, B, C. 
 * ���������� � ��������� ����������� �� ���� �����, 
 * ���������� � � �������, ���������� � � ������������ (A <= B <= C). 
 * ������� ���������� A, B, C �� �����.
 * ����� Math �� ������������.
 * 
 */ 
using System;
class MyExample
{
    public static void Main()
    {

        double x1, x2, x3,
              a, b, c,
            t;


        Console.Write("������ x1:");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("������ x2:");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("������ x3:");
        x3 = double.Parse(Console.ReadLine());

        a = x1; b = x2; c = x3;

        //  �������� ������� �������� ������
        if (a > b)
        {
            t = a; a = b; b = t;
        }

        if (a > c)
        {
            t = a; a = c; c = t;
        }

        if (b > c)
        {
            t = b; b = c; c = t;
        }

        Console.WriteLine("\na={0}  b={1}  c={2}", a, b, c);

        Console.ReadLine();
    }
}
