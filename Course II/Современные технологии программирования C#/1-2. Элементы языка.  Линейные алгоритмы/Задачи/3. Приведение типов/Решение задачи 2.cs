/*������. ������ �������� ������������� ����� � ������� �������� 
         ���������� � ���� �� ���������� �������� ������ �����. 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double x,             // �������� ����� 
                   d;            // �������� 
        int res;          // ��������� �����
        string line;          // ������ ��� ������ ������

        Console.Write("������� ������������ �����:  ");
        line = Console.ReadLine();
        x = double.Parse(line);

        d = x > 0 ? 0.5 : -0.5; // ��������
        res = (int)(x + d);     // ���������� �����
        Console.WriteLine("��������� �����: " + res);
    }
}
