/*  ������� ������: double[,] a = ���������(n, n);     
 ����  ������������  �������  �������� NxN ���������. ������ �������
 �������� � ����������. ��������� �������� �������� ���������,
 ������������� � ������������, ������������ ����� � ������
 �������� � ������� ���������� �������
 
*/

using System;

class Program
{
    static double[,] ���������(int m, int n)
    {
        int i, j;
        double[,] a = new double[m, n];       
        for (i = 0; i < m; i++)
            for (j = 0; j < n; j++)
            {
                Console.Write("�������[{0},{1}]: ", i, j);
                a[i, j] = double.Parse(Console.ReadLine());
            }
        Console.Beep();

        return a;
    }

    //--------------------------------------------------
    static void �������(double[,] a, string ������)
    {
        int i, j;
        int n = a.GetLength(0);
        for (i = 0; i < n; i++, Console.WriteLine())
            for (j = 0; j < n; j++)
                Console.Write(������, a[i, j]);
    }


    //--------------------------------------------------
    static double ���������(double[,] a)
    {
        int i, j, k, jmax;
        int n = a.GetLength(0);
        double s;

        for (i = 0, k = 0, s = 0, jmax = 0; i < n; i++, jmax++)
            for (j = 0; j <= jmax; j++)
            {
                k++;
                s = s + a[i, j];
            }
        return s / k;
    }

    //--------------------------------------------------
    static void Main(string[] args)
    {
        int n;        //������ �������
        double sr;        //�������   

        do
        {
            Console.Write("������: ");
            n = int.Parse(Console.ReadLine());

            double[,] a = ���������(n, n);     //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("\n�������� �������");
            �������(a, "{0,8:f2}");

            sr = ���������(a);

            Console.WriteLine("\n�������={0:f2}", sr);


            Console.WriteLine("\n��� ������ ������� ������� ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }

}

