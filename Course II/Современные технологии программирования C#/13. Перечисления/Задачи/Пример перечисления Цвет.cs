using System;
using System.Collections.Generic;
using System.Text;

namespace ������������1
{
    //enum ���� { �������, ������, ������� }
    //enum ���� { �������=1, ������, ������� }
    enum ���� { ������� = 1, ������, �������=5 }
    class ��������
    {
        public ���� ����;

        public ��������(���� ����) 
        {this.���� = ����;}
       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int ���;
            �������� �� = new ��������(����.�������);
            ��� = (int)��.����;
            Console.WriteLine(���);

            ��.���� = ����.������;
            ��� = (int)��.����;
            Console.WriteLine(���);

            ��.���� = ����.�������;
            ��� = (int)��.����;
            Console.WriteLine(���);

            //��.���� = ����.�����;
            //��.���� = 100;
            ��.���� = (����)100;
            ��� = (int)��.����;
            Console.WriteLine(���);
        }
    }
}
