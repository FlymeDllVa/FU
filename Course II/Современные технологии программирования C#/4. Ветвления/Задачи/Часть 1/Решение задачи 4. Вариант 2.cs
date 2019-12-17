/*
 ��������� �������� ������� G=F(X,Y)
       | true, ���� ����� � ������������ (X,Y) �������� � ������
  G = <
       | false, ���� ����� � ������������ (X,Y) �� �������� � ������
  ������ - ������ ����� �������� R=2 � ��������� ����� 180<= fi <=45
  ������ �������� ������� �� ���������: ������������, ��� ����� ��
  ����������� ������, � �� ����������� �������� ������������
  ��� �������������
*/

using System;

class Operator
{
 public static void Main()
  {
	 const double   R = 2.0;   //������
	
	 double         x,y;       //���������� �����
	 bool           g;         //�������� �������
	 string           rep;       //������� ���������� ����������
	 string         str;       //������ ��� ������ ������ � ������ ������
		           
	 REPEAT:
	 Console.Write("������� X:  "); 
	 str = Console.ReadLine();
	 x = double.Parse(str); 	
	 Console.Write("������� Y:  "); 
	 str = Console.ReadLine();
	 y = double.Parse(str); 	
	
	 g = false;     //��������������� ������� � �������
	 if(x*x + y*y <= R*R)    //� �����
		 if(x >= 0)             //������ �� ��� Y
			 if(y <= x)            //� ���� ������ y = x
				 g = true;             //������������ �������      
	 
	 str = string.Format("G({0:f3},{1:f3}) = {2}",x,y,g);
	 Console.WriteLine(str);

	 Console.Write("��� ������� ���������� ������ ������� Y: ");
	 rep = Console.ReadLine();  
	 Console.WriteLine();
	 if(rep == "Y" || rep == "y") goto REPEAT;
  } //����� ����������� ������
} //����� ���������� ������
