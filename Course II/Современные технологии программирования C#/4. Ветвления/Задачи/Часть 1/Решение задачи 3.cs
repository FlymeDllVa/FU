/*
 ��������� �������� ������� G=F(X,Y)

	     |  X+sin(Y), ���� X<Y � X>0;
    G = <
	     |  Y-cos(X), ���� X>Y � X<0;
	     |  0.5*X*Y   - �� ���� ��������� �������
 
*/
using System;

class Operator
{
 public static void Main()
  {
	 double         x,y,       //���������� �����
	                g;         //�������� �������
	 string         str;       //������ ��� ������ ������ � ������ ������
		           
	 Console.Write("������� X:  "); 
	 str = Console.ReadLine();
	 x = double.Parse(str); 	

	 Console.Write("������� Y:  "); 
	 str = Console.ReadLine();
	 y = double.Parse(str); 	
	 
	 if(x<y && x>0)
		 g = x + Math.Sin(y);
	 else
		 if(x>y && x<0)
		    g = y - Math.Cos(x);
	 else
		    g = 0.5 * x * y;

	 str = string.Format("G({0:f3}, {1:f3}) = {2:f3}",x,y,g); 
	 Console.WriteLine(str);

	 Console.Write("��� ���������� ��������� ������ ������� Enter: ");
	 Console.ReadLine();  
	 
  } //����� ����������� ������
} //����� ���������� ������
