/*  ������� 2 (��������)
����������� ����������, �������������� ���� ��������� ����� (X,Y) 
� �������� ��������� ����� � ��������� ������. 
������ ���������� �������, ������������ ���������� �����������:    
          Y = -X + 2;   Y = X + 2;   Y = X � 2;   Y = -X - 2
 */

using System;

class Operator
{
    public static void Main()
    {
        Console.Write("������� ���������� �: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("������� ���������� y: ");
        double y = double.Parse(Console.ReadLine());



        if (Math.Abs(x) + Math.Abs(y) <= 2)
            Console.WriteLine("����� (�,�) ����������� ������.");
        else
            Console.WriteLine("����� (�,�) �� ����������� ������.");

        Console.ReadKey(true);
    }

}
