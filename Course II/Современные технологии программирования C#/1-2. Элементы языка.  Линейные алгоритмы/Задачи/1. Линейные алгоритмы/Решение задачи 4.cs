using System;


class Program
{
    static void Main(string[] args)
    {
        double r,           //������
               s;           //�������
        string str;         //������ ����� 

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Clear();
        Console.Write("������� ������: ");
        str = Console.ReadLine();
        r = double.Parse(str);
        s = Math.PI * r * r;
        Console.WriteLine("�������=" + s);
        Console.Beep(500, 1000);
    }
}