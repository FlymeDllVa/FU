using System;
using System.Collections.Generic;
using System.Text;

namespace ������
{
    public class �����
    {
        private int     �����;
        private string  ����������;
        private �����[] ������;

        public �����(int �����, string ����������, �����[] ������)
        {
            this.����� = �����;
            this.���������� = ����������;
            this.������ = ������;
        }

        public int �����
        {   get { return �����; }      set { ����� = value; } }

        public string ����������
        {   get { return ����������; } set { ���������� = value; } }

        public �����[] ������
        {   get { return ������; }     set { ������ = value; } }


    }
    public abstract class �����
    {
        public abstract string ���������������();
    }

    public class ������������� : �����
    {
        
        public �������������(int �����, string ����������, �������������[] ������)
            : base(�����, ����������, ������)
        {  }
    }

    public class ����������������� : �����
    {
        public �����������������(int �����, string ����������, �����������������[] ������)
            : base(�����, ����������, ������)
        {  }
    }

    public class ������������� : �����
    {
        
        double ��������������������;
        double ���������;
        public �������������(double ����, double ���������)
        {
            �������������������� = ����;
            this.��������� = ���������;
        }
        public override string ���������������()
        {
            return String.Format("�������� �����, �������� {0:F2}� �� {1:F2}�", ���������, ��������������������);
        }
    }

    public class ����������������� : �����
    {
        public static int ������������ = 180;
        int ������������;
        public �����������������(int ��������)
        {
            ������������ = ��������;
        }
        public override string ���������������()
        {
            return String.Format("������������ �����, ������ {0} �� {1} ����", ������������, ������������);
        }
    }

}
