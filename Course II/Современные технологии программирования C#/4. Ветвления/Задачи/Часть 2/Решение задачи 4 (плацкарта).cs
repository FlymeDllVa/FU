using System;

class Program
{
    static void Main(string[] args)
    {
        int kol;
        string ���������, ������������;

        Console.Write("������� ����� ������ �����: ");
        kol = Convert.ToInt32(Console.ReadLine());


        if (kol % 2 == 0)		// ������ �����
            ��������� = "������� �����";
        else
            ��������� = "������ �����";


        if (kol % 5 == 0 || kol % 6 == 0)
            ������������ = "������� �����";
        else
            ������������ = "�������� �����";

        Console.WriteLine(��������� + ", " + ������������);
        Console.ReadKey();
    }
}
