using System;
using System.Collections;  //!!!!!!!!

namespace �����������������
{
    /// <summary>
    /// ������� � ������ ������ � ����������� ����������:
    /// - ������� (������)
    /// - �������   (�����)
    /// - �����     (������������)
    /// ������� ��������� ������ - �����������
    /// ������1:  ������   35    25.8
    ///           ������    40    28.3
    /// ������2:  ������   ������
    ///           35          40
    ///           25.8       28.3
    /// �� ������, ���������� � �������:
    /// 1. ������ ��� �������
    /// 2. ��������� ����������� �������
    /// 3. ��������� ������� �����
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo rep;
            ArrayList a;
            int �������; 
            int ���������������; 
            double ������������;

            do
            {
                a = new ArrayList();
                
                ���������(a);
                
                ��������������(a);

                ������� = �����������������(a);
                if (������� == int.MaxValue)
                      Console.WriteLine("������ � �������� ���");
                else
                      Console.WriteLine("����������� �������={0}", �������);

                ��������������� = ���������������(a, out ������������);
                if (��������������� == 0)
                    Console.WriteLine("������ �� ������ ���");
                else
                    Console.WriteLine("������� �����={0:f2}", ������������);

                Console.WriteLine("\n��� ������ ������� ESC ");
                rep = Console.ReadKey(true);
            } while (rep.Key != ConsoleKey.Escape);

        }

        /// <summary>
        /// ���������� ������� ������� � �����������
        /// </summary>
        /// <param name="a">�������� ������</param>
        static void ���������(ArrayList a)
        {
            char     var;   //��� ������
            string   �������;
            int       �������;
            double �����;


            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("�������� ��� ������");
                    Console.WriteLine("1. �������");
                    Console.WriteLine("2. �������");
                    Console.WriteLine("3. �����");
                    Console.WriteLine("4. ���������� ����� ������");
                    var = Console.ReadKey(true).KeyChar;
                } while (var < '1' || var > '4');

                switch (var)
                {
                    case '1':
                        Console.Write("�������: ");
                        ������� = Console.ReadLine();
                        a.Add(�������);
                        break;
                    case '2':
                        Console.Write("�������: ");
                        ������� = int.Parse(Console.ReadLine());
                        a.Add(�������);
                        break;
                    case '3':
                        Console.Write("�����: ");
                        ����� = double.Parse(Console.ReadLine());
                        a.Add(�����);
                        break;
                    case '4': return;
                }
            }
        }

        /// <summary>
        /// ����� ���� �������
        /// </summary>
        /// <param name="a">�������� ������</param>
        static void ��������������(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
                if (a[i].GetType().Name == "String")
                    Console.WriteLine(a[i]);
        }

        /// <summary>
        /// ���������� ������������ ��������
        /// </summary>
        /// <param name="a">�������� ������</param>
        /// <returns>����������� �������</returns>
        static int �����������������(ArrayList a)
        {
            int min = int.MaxValue;
            int �������=0;
            for (int i = 0; i < a.Count; i++)
                if (a[i].GetType().Name == "Int32")
                {
                    ������� = (int)a[i];
                    if (������� < min) min = �������;
                }
            return min;
        }

        
        /// <summary>
        /// ���������� �������� ������
        /// </summary>
        /// <param name="a">�������� ������</param>
        /// <param name="������������">������� �����</param>
        /// <returns>���������� ������ �� ������</returns>
        static int ���������������(ArrayList a, out double ������������)
        {
            int k = 0; //���������� ������ �� ������
            double ����� = 0;
            ������������ = 0;
            for (int i = 0; i < a.Count; i++)
                if (a[i].GetType().Name == "Double")
                {
                    ����� = (double)a[i];
                    ������������ += �����;
                    k++;
                }
            if(k>0) ������������ /= k;
            return k;
        }
    }
}
