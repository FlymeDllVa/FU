using System;
    class Program
    {
        static void Main(string[] args)
        {
            double D, W;

            Console.Write("������� ������� ������: ");
            D = Double.Parse(Console.ReadLine());
            Console.Write("������� ������ �����: ");
            W = Double.Parse(Console.ReadLine());

            if (W * Math.Sqrt(2) < D)
                Console.WriteLine("����� �������� ����");
            else Console.WriteLine("������ �������� ����");

            Console.ReadKey();

        }
    }
