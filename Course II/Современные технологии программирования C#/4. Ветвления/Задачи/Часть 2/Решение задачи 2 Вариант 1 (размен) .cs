using System;
class Program
{
    static void Main(string[] args)
    {
        int rub, tis, sot, des, dva;

        Console.Write("���������� ������: ");
        rub = Convert.ToInt32(Console.ReadLine());

        tis = rub / 1000;
        sot = rub % 1000 / 100;
        des = rub % 100 / 10;
        dva = rub % 10 / 2;

        Console.WriteLine(tis + " �����, " + sot + " �����, " 
            + des + " �������, " + dva + " ������ �� 2 ���");
        Console.ReadKey();

    }
}
