// ���� ����� � � ������������ x,y.  
// ����������  �  �����  ��������� ������������ ��� ��� �����������.

using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("������� ��� ���������� �.�");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x == 0) Console.WriteLine("����� �� ��� �");
        else if (y == 0) Console.WriteLine("����� �� ��� Y");
        else if (x > 0 && y > 0) Console.WriteLine("����� � � 1-� ��������");
        else if (x < 0 && y > 0) Console.WriteLine("����� � �� 2-� ��������");
        else if (x < 0 && y < 0) Console.WriteLine("����� � � 3-� ��������");
        else Console.WriteLine("����� � � 4-� ��������");
    }
}



