// ������ �� ���������� ��� ������ ��� �����
// ��� ��������� � ��������� ���

using System;

class Program
{
    static void Main(string[] args)
    {
        string day, msg = "";
        day = Console.ReadLine();
        switch (day)
        {
            case "6":
            case "�������": msg = "��������"; break;
            case "7":
            case "�����������": msg = "��������"; break;
            default: msg = "�������"; break;
        }
        Console.WriteLine(msg);
    }
}


