// ��������� ������� �������������� �������� ��������� �������.
// ��� ������ ��������� �������� �� ���� �� ����� ����������.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;           // ����� �������
            int i;
            float[] a;      // ������
            float sr;       // ������� ��������������


            // ���� �������� ������
            Console.Write("������� ����� �������: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("������ ������� ���������� ��������. ��������� ����: ");
            }

            a = new float[n];


            			//�����������(a, 10, 20);
            Random rnd = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = (20 - 10) * (float)rnd.NextDouble() + 10;



            // ��������� ������� �������������� ��������
            for (i = 0, sr = 0; i < n; i++)
            {
                sr = sr + a[i];
            }
            sr = sr / n;


            // ����� ����������

            Console.WriteLine("\n  \t----�������� ������---");

            			// ������������(a, "{0,7:f2}");
            Console.WriteLine(string.Join("\t", a));  //!!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("\n\n������� �������������� �������� = " + sr);
        }







        //_______ ������ ___________________________________________________
        static void �����������(float[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("������� ������� {0}: ", i);
                if (float.TryParse(Console.ReadLine(), out m[i]) == false)
                {
                    Console.WriteLine("������ ������� ���������� ��������.");
                    i--;
                }
            }
        }

        //_______________________________________________________________________
        static void �����������(float[] m, int a, int b)
        {
            int t;
            if (a > b) { t = b; b = a; a = t; }
            Random rnd = new Random();

            for (int i = 0; i < m.Length; i++)
                m[i] = (b - a) * (float)rnd.NextDouble() + a;
        }
        //_______________________________________________________________________

        static float[] �����������(int n)
        {
            float[] m = new float[n];

            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("������� ������� {0}: ", i);
                if (float.TryParse(Console.ReadLine(), out m[i]) == false)
                {
                    Console.WriteLine("������ ������� ���������� ��������.");
                    i--;
                }
            }
            return m;
        }

        //_______________________________________________________________________
        static void ������������(float[] m)
        {
            for (int i = 0; i < m.Length; i++)
                    Console.Write(m[i] + "\t");
        }

        //_______________________________________________________________________
        static void ������������(float[] m, string format)
        {
            for (int i = 0; i < m.Length; i++)
                    Console.Write(format, m[i]);
        }


    }
}
