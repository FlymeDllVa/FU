using System;
using System.Collections.Generic;
using System.Text;

namespace ����
{
    class �������
    {
        private string �������;
        private uint �������;

        private static string ������;   // !!!!!!!!




        //------- ����������� ����������� --------
        static �������()
        {
            ������ = "1��1";
        }


        //------- ����������� ����� --------------
        public static string ������������()
        {
            return ������;
        }


        //------- ����������� 1 --------------------
        public �������(string �������, uint �������)
        {
            this.������� = �������;
            this.������� = �������;
        }


        //------- ����������� 2 --------------------
        public �������(string �������)
        {
            this.������� = �������;
            ������� = 50;
        }


        //------------------------------------------
        public string ������������()
        {
            return ������� + " " + ������� + " " + ������;
        }
    }
}
