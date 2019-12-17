/*
 * ����� ����������� ����������� ����� ������������ 500, 100 � 10 ������, 
 * � ����� �������� 2 ���. ����� ��������� ����� R ������ 
 * � �������� �� ����� ������? 
 * ������� ���������� ����� ������� ����������� � ���������� ����� �� 2 ���.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int rub, tys, sto, desyat, dva, n;

        Console.WriteLine();
        rub = Convert.ToInt32(Console.ReadLine());

        if (rub % 2 == 1)
        {
            Console.WriteLine("��������� ������ ����� ����������!");
            return;
        }

        tys = rub / 1000; 			    // ���-�� �� 1000
        rub = rub - tys * 1000; 		// �������
        sto = rub / 100; 				// ���-�� �� 100
        rub = rub - sto * 100; 			// �������
        desyat = rub / 10; 			    //���-�� �� 10
        dva = rub % 10 / 2;

        n = tys + sto + desyat + dva;

        Console.WriteLine("����������� ���������� ����� = " + n);
        Console.WriteLine(tys + " ����� " + sto + " ����� "
            + desyat + " ������� " + dva + " ����� �� 2 ���");

        Console.ReadKey();
    }
}
