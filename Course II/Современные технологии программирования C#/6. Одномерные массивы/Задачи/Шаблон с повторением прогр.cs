using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        do
        {
            // �������� ����������.
              ______ x;
            int[] m = { 1, 3, 9, 7, 2, 0, 4, 4 };
            List<int> lst = new List<int>();


            Console.Write("������� ... : ");
            while (!____.TryParse(Console.ReadLine(), out x))			
                   Console.WriteLine("�� �������� ��� �����. ���������!");


	    // ���� ���������
            //. . . . . . . . . . . . . . .


            // ����� ������ �� �����
            foreach (var v in m)
                Console.Write(v + "  ");

            	Console.WriteLine("\n\n��� ������ ������� ESC ");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
    }
}

