using System;

namespace ������������
{
    class �������
    {
        private string �������;
        private uint �������;

        public string �������
        {
            get { return �������; }
            set { ������� = value; }
        }
       
        public uint �������
        {
            get { return �������; }
            set { ������� = value; }
        }

        public �������(string �������,uint �������)
        {
            this.������� = �������;
            this.������� = �������;
        }
       
        public string ������������()
        {
            return ������� + "  " + �������;
        }
    }
    class ��������
    {
        static void Main(string[] args)
        {
            ������� �� = new �������("������",85);
            Console.WriteLine(��.������������());
            //��.������� = "������";
            //��.������� = ��.������� + 10;
            ��.������� = "������";
            ��.������� = ��.������� + 10;
            Console.WriteLine(��.������������());
        }
    }
}
