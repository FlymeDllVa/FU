/*
     ������ � ���������� ��� ������������ ������������� �����.
   ��������� � ������� �� �����:
    1. ����� ������� ������ ���� �����
    2. ������� �������� ����� ������
   ��������, ��� 2.25 � 3.75 ����� ������� ������ 1.0,
   � ������� �������� ����� ������ 2.5
*/

using System;
class Chislo
{
 public static void Main()
  {
	float  x1,x2,    // �������� �����
		   s,        // ����� ������� ������
		   sr;       // ������� �������� ����� ������
	int    cx1,cx2;  // ����� ����� �����
   	string str;      // ������ ��� ������ ������ � ������ ������
	
	Console.Write("������� ������ �����:  "); 
	str = Console.ReadLine(); 
	x1 = float.Parse(str); 
	Console.Write("������� ������ �����:  "); 
	str = Console.ReadLine(); 
	x2 = float.Parse(str); 
	   
	s = (x1 - (int)x1) + (x2 - (int)x2);
	cx1 = (int)x1;
	cx2 = (int)x2;
	sr = (float)(cx1 + cx2) / 2;

	str = s.ToString();
      str = "����� ������� ������=" + str;
	Console.WriteLine(str);
	str = sr.ToString();
	str = "������� �������� ����� ������=" + str;
	Console.WriteLine(str);

	Console.ReadLine();  
  } //����� ����������� ������
} //����� ���������� ������
