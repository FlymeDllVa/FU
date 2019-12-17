/*
  ������ ��������� ���� ����� ������� � �������� (� ���� ����������� ��������). 
  ���������� �������� ����� (������ ����� 1,2 ��� 3), ���������� ������������� �����������
  � �����, �������������� � �������� ������. ����� ����������� � ������ � ��������. 
  ��������� � ������ �� ����� ����� � ������ � ��������.
*/

using System;
class Operator
{
    public static void Main()
    {
        const int T1 = 1200,    //��������� �������  ������ (�������)
                  T2 = 2551,    //��������� �������  ������ (�������)
                  T3 = 1985;    //��������� �������� ������ (�������)
        int    itog,       //����� � ������ �� ������������� ����� (�������)
               sumr,       //�����, ��������� ����������� (�����)
               sumk,       //�����, ��������� ����������� (�������)
               ostk,       //����� (�������)
               ostr,       //����� (�����)
               tip,        //��� ���������� ������
               n;          //���������� ����������� ������
        string str;        //������ ��� ������ ������ � ������ ������

        // ���� �������� ������
        Console.Write("�������� �������:\n1.�������\n2.��������\n");
        Console.Write("3.�����\n4.������ �������� �� ����\n");
        tip = int.Parse(Console.ReadLine());

        if (tip < 1 || tip >= 4) return;

        Console.Write("������� ����: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("��������� �����==> �����:   ");
        sumr = int.Parse(Console.ReadLine());

        Console.Write("             ==> �������:   ");
        sumk = int.Parse(Console.ReadLine());



        // ���������� �����
        sumk += 100 * sumr;
        itog = 0;
        switch (tip)
        {
            case 1: itog = T1 * n; break;
            case 2: itog = T2 * n; break;
            case 3: itog = T3 * n; break;
        }

        ostk = sumk - itog;

        if (ostk < 0)
            str = "�������� �����!";
        else
        {
            ostr = ostk / 100;
            ostk = ostk % 100;
            str = string.Format("�����: {0}���. {1:d2}���.", ostr, ostk);
        }
        Console.Write(str);



        Console.WriteLine("\n��� ���������� ��������� ������� ������� ENTER");
        Console.ReadLine();
    } 
} 

