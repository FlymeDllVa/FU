/*
���������� � ������ ��������������� ���������� �� 0 �� 5 � ����� 1. 
��������� ���������, ������� ������������� ��������� ���������� 
�������� �� 5 � 0. 
*/

using System;

class �������
{
    static void Main(string[] args)
    {
        int A;

        A = 0;              // A=0
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=1
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=2
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=3
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=4
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=5
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=0
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=1
        Console.WriteLine("����� = " + A);

        A = ++A % 6;        				// A=2
        Console.WriteLine("����� = " + A);
        // ...  � �.�. ...

        Console.ReadLine();
    }
}
