/* ����������� ���������� ���������� ��� ����� ����������� ���������� ���������� � ������ ���������� ����������. ���������� ������������ �� �������� �� 100 �. � �� ������� � ���� � 10 �. ���������. ��� ���������� ������� � ���� ������ ��� �������, ������ ������� ����������� � ������, � ����� ���� ����� ������. �������� ������� � ���� ����� ����������. 
������� ������ �����������, ���������� �� ����� 5-� �����������. �������� ������ ����� ������ � ��������� � ���� ��������. ������� ���������� ��� ���� �����������. ���������� ����������, �������� ������ �����. ���� ������ �����, ������� �� ���� ���������.
��� ���������� ��������� ������������ �������� ����������� �������� ���.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace �������_8
{
    class ��������������������
    {
        private string ���������������;

        private string �������;

        public ��������������������(string ���������������, string �������)
        {
            this.��������������� = ���������������;
            this.������� = �������;
        }
        public string ���������������
        { get { return ���������������; } }

        public virtual double ���������
        { get { return 0; } }

        public virtual void �����()
        {
            Console.WriteLine(��������������� + ", ��������� " + �������);
        }
    }


    //---------------------------------------------------------------
    class ��������100 : ��������������������
    {
        public static double �������� = 30.0;
        private double time;


        public ��������100(string ���������������, string �������, double time)
            : base(���������������, �������)
        {
            this.time = time;
        }

        public override double ���������
        { get { return time; } }

        public override void �����()
        {
            base.�����();
            Console.WriteLine("   ���������� ����� " + time);
        }
    }

    //---------------------------------------------------------------
    class ������10� : ��������������������
    {
        public static double �������� = 60.0;

        private double p1, p2, p3;

        public ������10�(string ���������������, string �������, double p1, double p2, double p3)
            : base(���������������, �������)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public override double ���������
        { get { return p1 + p2 + p3; } }


        public override void �����()
        {
            base.�����();
            Console.WriteLine("   ��������� ����� ������ " + (p1 + p2 + p3));
        }
    }

    //---------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            int ����;                       // ����� ������ ����
            string �������;
            double time, minPl;             // ����� � ����������� ��������� �� ��������
            double p1, p2, p3, maxPr;       // ���� � ������������ ��������� �� ������� � ����
            int m1pl, m1pr;                 // ������� ����������� � ������
            List<��������������������> ����� = new List<��������������������>();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n������ �� �������� �� 100 �. �����������   = " + ��������100.�������� + " ������");
            Console.WriteLine("������ �� ������� � ���� � 10 �. ��������� = " + ������10�.�������� + " ������\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            while (true)
            {
                Console.WriteLine("\n\t--------------------- ���� ----------------------");
                Console.WriteLine("\t1 - �������� � ����� ��������� �� ��������");
                Console.WriteLine("\t2 - �������� � ����� ��������� �� ������� � ����");
                Console.WriteLine("\t3 - ������ ������ ���������� � �� ����������");
                Console.WriteLine("\t4 - ���������� �����������");
                Console.WriteLine("\t5 - �����");
                Console.WriteLine("\t-------------------------------------------------");
                Console.Write("������� ����� ������ ����: ");

                ���� = int.Parse(Console.ReadLine());

                switch (����)
                {
                    case 1:     // ��������
                        Console.Write("������� �������: ");
                        ������� = Console.ReadLine();

                        Console.Write("������� �����: ");
                        time = double.Parse(Console.ReadLine());

                        �����.Add(new ��������100("��������", �������, time));

                        break;

                    //-----------------------------
                    case 2:
                        Console.Write("������� �������: ");
                        ������� = Console.ReadLine();

                        Console.Write("������� ���������� ������ �� 1-� ������: ");
                        p1 = double.Parse(Console.ReadLine());

                        Console.Write("������� ���������� ������ �� 2-� ������: ");
                        p2 = double.Parse(Console.ReadLine());

                        Console.Write("������� ���������� ������ �� 3-� ������: ");
                        p3 = double.Parse(Console.ReadLine());

                        �����.Add(new ������10�("������ � ����", �������, p1, p2, p3));

                        break;

                    //-----------------------------
                    case 3:         // ������ ������ ���������� � �� ����������
                        if (�����.Count == 0)
                        {
                            Console.WriteLine("������ �����������.");
                            break;
                        }

                        Console.WriteLine("���������� ������������:");
                        Console.WriteLine("-----------------------");

                        int j = 1;
                        foreach (�������������������� x in �����)
                        {
                            Console.Write("\n" + j++ + ". ");
                            x.�����();
                        }

                        break;

                    //-----------------------------
                    case 4:         // ���������� �����������
                        if (�����.Count == 0)
                        {
                            Console.WriteLine("������ �����������.");
                            break;
                        }


                        m1pl = m1pr = 0;
                        minPl = 999999999;      // �������� ������� �������� 
                        maxPr = -1;             // �������� ������� ��������

                        for (int i = 0; i < �����.Count; i++)
                        {
                            if (�����[i].��������������� == "��������" && minPl > �����[i].���������)
                            {
                                m1pl = i;
                                minPl = �����[i].���������;
                            }
                            else if (�����[i].��������������� == "������ � ����" && maxPr < �����[i].���������)
                            {
                                m1pr = i;
                                maxPr = �����[i].���������;
                            }
                            else Console.WriteLine(�����[i].��������������� + " - ���� ��� ������������ �� ��������������!");

                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n������ ����� �� �������� �� 100 �.");
                        Console.WriteLine("----------------------------------");
                        �����[m1pl].�����();
                        if (�����[m1pl].��������� < ��������100.��������)
                            Console.WriteLine("!!!!! ��� ����� ������� ������ !!!!");

                        Console.WriteLine("\n������ ����� �� ������� � ���� � 10 �. ���������");
                        Console.WriteLine("------------------------------------------------");
                        �����[m1pr].�����();
                        if (�����[m1pr].��������� > ������10�.��������)
                            Console.WriteLine("!!!!! ��� ����� ������� ������ !!!!");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();

                        break;

                    //-----------------------------
                    case 5:         // �����
                        Console.WriteLine("\n��� ���������� ��������� ����� Esc");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)

                            return;
                        else
                            break;

                    //-----------------------------
                    default:
                        Console.WriteLine("������ �������� �����!");
                        break;
                }
                Console.WriteLine("\n--������--");
            }
        }
    }
}
