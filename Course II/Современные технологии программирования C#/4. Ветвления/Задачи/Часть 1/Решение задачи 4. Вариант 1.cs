/*
����������� ���������� ���������� ��� ������ ������ �� ���������:

�	����� � ������������ (X,Y) �������� � ������
�	����� � ������������ (X,Y) �� �������� � ������

������ - ������ ����� �������� R=2 � ��������� ����� 180<= fi <=45
��������� � ����:    x*x + y*y <= R*R  
��������� � � Y ������ � ����������.
 */

using System;

class Operator
{
    public static void Main()
    {
        Console.WriteLine("������� ���������� � ");
        string dub = Console.ReadLine();
        double x = Convert.ToDouble(dub);

        Console.WriteLine("������� ���������� y ");
        dub = Console.ReadLine();
        double y = double.Parse(dub);

        if ((x * x + y * y <= 4 && y <= 0) || (x * x + y * y <= 4 && x >= y))
            Console.WriteLine("����� (�,�) ����������� ������.");
        else 
            Console.WriteLine("����� (�,�) �� ����������� ������.");

        Console.ReadKey(true);
    }

}
