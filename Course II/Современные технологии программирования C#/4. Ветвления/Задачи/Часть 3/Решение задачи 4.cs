
// ������ �� ���������� ��� ������ ��� �����
// ��� ��������� � ��������� ���.

using System;

class Program
{
    static void Main(string[] args)
    {
        string ����,
               ���������;

        Console.Title = "���� ������";
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write("\n������� ����� ��� �������� ���: ");
        ���� = Console.ReadLine();

        ���� = ����.ToUpper();

        switch (����)
        {
            case "1":
            case "�����������":
            case "2":
            case "�������":
            case "3":
            case "�����":
            case "4":
            case "�������":
            case "5":
            case "�������":
                ��������� = "������� ����";
                break;
            case "6":
            case "�������":
                ��������� = "��� ����-�� ��������, � ��� ����-�� ���";
                break;
            case "7":
            case "�����������":
                ��������� = "��������";
                break;
            default: ��������� = "�� ���� ������ ���";
                break;
        }

        Console.WriteLine(���������);

        Console.WriteLine("\n��� ������ ������� Enter");
        Console.ReadLine();
    }
}


