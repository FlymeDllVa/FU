/*
 ��������� �������� ������� Y=F(X)
	      /  
	     |   X + 2         ���   X<=0
    Y =    <    Sqrt(4-X*X)   ��� 0<X<=2
	     |   0             ���   X>2
	      \
  ������ �������� ������� ������������ � ������������ �� �����������
  ��������
*/

using System;
namespace �������
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,       // ��������
                   y;       // �������� ������� 

            Console.Write("������� ��������: ");
            x = double.Parse(Console.ReadLine());


            if (x <= 0)
                y = x + 2;
            else
                if (x <= 2)
                    y = Math.Sqrt(4.0 - x * x);
                else
                    y = 0.0;

            Console.WriteLine("��� X = " + x + " �������� ������� = " + Math.Round(y, 2));

            Console.WriteLine("\n��� ������ ����� Enter");
            Console.ReadLine();
        }
    }
}

