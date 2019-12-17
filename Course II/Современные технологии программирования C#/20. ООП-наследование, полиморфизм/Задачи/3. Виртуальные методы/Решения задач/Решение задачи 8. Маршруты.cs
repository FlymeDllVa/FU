/* ����������� ���������� ���������� ��� ����� ��������� ������� 
 * �� ������ ������ ������ � ������. �������� ����� ���� ������ 
 * ���� �����: �� ����� � �� ��������� ������������ ���������� 
 * � N �����������.  ������� � ����� ��������������� ��� ���������, 
 * ������ � �������� ������� �� 100 ��. ��������� ������ ����� 
 * ������� ����� 20 ���. ���������� ������� ��������������� 
 * ��������� � ����������� ���������. ��������� ������ ����� 25 ���.
 * ������� ������ ��������� (�� ����� 5-�). �������� ������ ����� 
 * ������ � ��������� � ���� ��������. 
 * ������� ���������� ��� ���� ���������, ������� ���� �������. 
 * ���������� �������, ��������� ������� �� �������� �������� ����� ������.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class ������
    {
        public static double ������������;
        public static double �����������;
        private string ��������;

        public ������(string ����)
        { �������� = ����; }

        public string ��������
        { get { return ��������; } }


        public virtual double ����()
        {
            Console.Write("��������� ������� �� �������� ");
            return 0;
        }

        public virtual void �����()
        {
            Console.Write("�������� ��������: " + ��������);
        }
    }

    //--------------------------------------------------------------------
    class ����� : ������
    {
        private double �����;
        private double ������;

        public �����(string ����, double ��, double ����) : base(����)
        {
            ����� = ��;
            ������ = ����;
        }

        public double �����
        { get { return �����; } }

        public double ������
        { get  { return ������; } }


        public override double ����()
        {
            //Console.WriteLine("���� ����� = " + ����� * ������ * ������������);
            return ����� * ������ / 100 * ������������;
        }

        public override void �����()
        {
            Console.WriteLine("������� " + �������� + ", ����� �������� " + �����
                + " ��, ������ ������� " + ������ + " � �� 100 ��, ��������� " + ����() + " ���.");
        }
    }

    //--------------------------------------------------------------------
    class ����������� : ������
    {
        private double ��������������;

        public �����������(string ����, double ���������) : base(����)
        {  �������������� = ���������;  }

        public double K�������������
        {  get  { return ��������������;  }  }       
        
        public override void �����()
        {
            Console.WriteLine("������� " + �������� + ", ���������� ��������� " 
                + �������������� + ", ��������� " + ����() + " ���.");
        }

        public override double ����()
        {
            // Console.WriteLine("���� ������� = " + �������������� * �����������);
            return (��������������+1) * �����������;
        }
    }

    //--------------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            ������.������������ = 20;
            ������.����������� = 25;
            double min=0;             // ������� �� ����
            int i, n=0;

            List<������> t�������� = new List<������>();

            t��������.Add(new �����("���", 50.0, 20.0));
            t��������.Add(new �����������("�������-470", 3));
            t��������.Add(new �����("�����", 100.0, 30.0));
            t��������.Add(new �����("��������", 100.0, 15.0));
            t��������.Add(new �����������("�������-595", 4));
            t��������.Add(new �����("���������", 200.0, 5.0));


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t����� ���������:");
            Console.WriteLine("\t_______________\n");


            // ����� ���� ����������
            foreach (������ elem in t��������)
            {
                elem.�����();
                //elem.����();
                Console.WriteLine();
            }

            // ����� ������������ �� ���� ��������
            if (t��������.Count > 0)
                min = t��������[0].����();
            else
            {
                Console.WriteLine("����� ��������� ������!");
                goto M;
            }

            for (i = 0; i < t��������.Count; i++)
            {
                if (t��������[i].����() < min)
                {
                    min = t��������[i].����();
                    n = i;
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n������� � ����� ������ ���������� �������:");
            Console.WriteLine("-----------------------------------------");
            t��������[n].�����();

            M:
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n\n ��� ������ ������� ����� �������:");
            Console.ReadKey();

        }
    }
}
