/*
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
        string str = Console.ReadLine();
        double x = Convert.ToDouble(str);

        Console.Write("������� ���������� y: ");
        str= Console.ReadLine();
        double y = double.Parse(str);

        if ((-x + 2) >= y && (x + 2) >= y && (x - 2) <= y &&(-x - 2) <= y)
            Console.WriteLine("����� (�,�) ����������� ������.");
        else 
            Console.WriteLine("����� (�,�) �� ����������� ������.");

        Console.ReadKey(true);
    }

}
