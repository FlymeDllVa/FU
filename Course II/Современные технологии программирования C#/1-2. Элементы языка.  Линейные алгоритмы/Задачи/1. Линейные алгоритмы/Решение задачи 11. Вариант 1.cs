using System;

class Program
{
    static void Main(string[] args)
    {
        int sec;            // ����� � �������� (�������� �����).
        int seconds,
            minutes,
            hours;

        Console.Write("������� ����� � ��������: ");
        sec = int.Parse(Console.ReadLine());

        hours = sec / 3600;                 // ������� �������������
        minutes = (sec - hours * 3600) / 60;          // ������� / 60
        seconds = (sec - hours * 3600) - minutes * 60;          // �������

        Console.WriteLine("������� �����: {0} ���. {1} ���. {2} ���.",
                                           hours, minutes, seconds);
        Console.ReadKey();

    }
}
