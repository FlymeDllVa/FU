using System;

namespace ������������������
{
    class �������
    {
        private string �������;
        private uint �������;
               
        public �������(string ���, uint ��)
        {
            ������� = ���;
            ������� = ��;
        }

        public string �������������()
        {
            return �������;
        }

        public void ����������������(string ���)
        {
            ������� = ���;
        }

        public uint �������������()
        {
            return �������;
        }

        public void ����������������(uint ��)
        {
            ������� = ��;
        }
    }

    class �������������
    {
        static void Main(string[] args)
        {
            ������� �� = new �������("������", 85);
            //Console.WriteLine(��.������� + "  " + ��.�������);
            Console.WriteLine(��.�������������() + " " + ��.�������������());

            //��.������� = "������";    ��.������� = 15;
            ��.����������������("������");
            ��.����������������(15);
            Console.WriteLine(��.�������������() + " " + ��.�������������());
        }
    }
}
