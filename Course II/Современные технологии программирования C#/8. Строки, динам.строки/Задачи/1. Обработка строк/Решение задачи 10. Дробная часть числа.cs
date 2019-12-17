// ������ �������� ������������� �����. 
// �������� �� ����� ������� ����� � 
// ��������� �� ����� ����������. ������� ����� ����������. 

using System;
class Program
{
    static void Main(string[] args)
    {
        float f;
        string[] w;
        string str;
        int x;

        // ���� ��������� �����
        while (true)
        {
            Console.Write("������� ������������ �����: ");
            str = Console.ReadLine();
            if (float.TryParse(str, out f)) break;
            Console.WriteLine("�� �������� ��� �����. ���������!");
        }

        w = str.Split(',');     // �������� ����� �����

        if (w.Length > 1)       // ���� ���� ������� �����
            x = int.Parse(w[1].TrimEnd('0'));   // ������� ���� � ����� � �������������
        else
            x = 0;

        Console.WriteLine("������� ����� ����� {0} = {1}", str, x);

        Console.ReadKey();
    }
}
