using System;

namespace ��������������������
{
    class �������
    {
       private string �������;
       private uint �������;
        private static string ���������������(string s)
        {
            string kod = "";
            for (int i = 0; i < s.Length; i++)
                kod = kod + (char)(s[i] + 1);
            return kod;
        }

        private static string ������������������(string s)
        {
            string kod = "";
            for (int i = 0; i < s.Length; i++)
                kod = kod + (char)(s[i] - 1);
            return kod;
        }

        private static uint ��������������(uint a)
        {
            return a + 50;
        }

        private static uint �����������������(uint a)
        {
            return a - 50;
        }

        public �������(string ���, uint ��)
        {
            ������� = ���������������(���);
            ������� = ��������������(��); 
        }

        public string �������������()
        {
            return ������������������(�������);
        }

        public void ����������������(string ���)
        {
            ������� = ���������������(���);
        }

        public uint �������������()
        {
            return �����������������(�������);
        }

        public void ����������������(uint ��)
        {
            ������� = ��������������(��);
        }
    }

    class �����������
    {
        static void Main(string[] args)
        {
            ������� �� = new �������("������", 85);
            //Console.WriteLine(��.������� + "  " + ��.�������);
            Console.WriteLine(��.�������������() + " " + ��.�������������());

            //��.������� = "������"; 
            //��.������� = 15;
            ��.����������������("������");
            ��.����������������(15);
            Console.WriteLine(��.�������������() + " " + ��.�������������());
        }
    }
}
