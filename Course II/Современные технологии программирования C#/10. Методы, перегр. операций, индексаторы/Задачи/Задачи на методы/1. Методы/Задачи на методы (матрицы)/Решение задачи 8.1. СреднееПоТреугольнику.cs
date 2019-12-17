/*  ������� ������: ���������(a);
 ����  ������������  �������  �������� NxN ���������. ������ �������
 �������� � ����������. ��������� �������� �������� ���������,
 ������������� � ������������, ������������ ����� � ������
 �������� � ������� ���������� �������
*/

using System;


class Program
{
    static void ���������(int[,] a)
    {
        uint i, j;
        uint n = (uint)a.GetLength(0);

        for (i = 0; i < n; i++)
            for (j = 0; j < n; j++)
            {
                Console.Write("�������[{0},{1}]: ", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
            Console.Beep();
    }


    //-----------------------------------------------
    static void �������(int[,] a, string ������)
    {
        int i, j;
        uint n = (uint)a.GetLength(0);

        for (i = 0; i < n; i++, Console.WriteLine())
            for (j = 0; j < n; j++)
                Console.Write(������, a[i, j]);
    }


    //-----------------------------------------------
    static double ���������(int[,] a)
    {
        uint i, j, k;
        int s;
        uint n = (uint)a.GetLength(0);

        for (i = 0, k = 0, s = 0; i < n; i++)
            for (j = 0; j <= i; j++)
            {
                k++;
                s = s + a[i, j];
            }
        return (double)s / (double)k;
    }



    //-----------------------------------------------
    static void Main(string[] args)
    {
        int n;        //������ �������
        int[,] a;     //�������� �������
        double sr;        //�������   

        do
        {
            Console.Write("������: ");
            n = int.Parse(Console.ReadLine());

            a = new int[n, n];
            ���������(a);

            Console.WriteLine("\n�������� �������");
            �������(a, "{0,8}");

            sr = ���������(a);

            Console.WriteLine("\n�������={0:f5}", sr);


            Console.WriteLine("\n��� ������ ������� ������� ESC");

        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }

}

