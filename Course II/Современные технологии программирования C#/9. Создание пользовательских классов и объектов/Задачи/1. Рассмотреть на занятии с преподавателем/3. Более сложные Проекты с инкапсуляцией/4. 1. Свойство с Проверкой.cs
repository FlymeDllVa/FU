using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ��������
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
            set {
                     if (value >= 0 && value <= 100)
                         ������� = value;
                     else
                         Console.WriteLine("������������ �������� ��������");
                  }
        }

        public �������(string �������, uint �������)
        {
            this.������� = �������;
            this.������� = �������;
        }

        public string ������������()
        {
            return ������� + "  " + �������;
        }
    }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    class ��������
    {
        static void Main(string[] args)
        {
            ������� �� = new �������("������", 85);
            ��.������� = ��.������� + 30;
            Console.WriteLine(��.������������());
        }
    }
}
