// ��������, ����� ����� (�� ����� ������ � �����) ���� ��������� � ����� 1022, 
// ����� ���������� ����� ������������ �������� �� 7, 8, 9. 
// ������ ������ � �������������� �������� �� ��������.

using System;
class Program
{
    static void Main(string[] args)
    {
        int A, B; 	//loop
        int b;    	//�������� �����
        string str; 	
        
        Console.Write("������ �������: ");
        for (A = 0; A < 10; A++)
        {
            for (B = 0; B < 10; B++)
            {
                str = (A + "1022" + B);
                b = int.Parse(str);
                if (b%7 == 0 && b%8 == 0 && b% 9 ==0)
                {
                    Console.WriteLine("�����:" + b);
                 
                }
            }
        }
        
        Console.Read();
    }
}

