/*
  ������������ ������� 4. ������ 2.2
  �������������� ������ ������ 2.1.
  ��� ������ � ��������� ������������ ������ �������� ���� char
 */
using System;
class Operator
{
 public static void Main()
  {  
	 char   cifra,      //������ ������ (�����)
	        bukva,      //������ ������ (��������� �����)
	        newbuk;     //����� �����   
	 int    delta;      //�������� ������ � ��������
	 char   rep;        //������� ���������� ����������  // ����� string
	 string str;      //������ ��� ������ ������ � ������ ������
	
	 REPEAT:
	 Console.Write("������� ������ ������ (�����):  "); 
	 str = Console.ReadLine();
	 cifra= char.Parse(str); 	
	 Console.Write("������� ������ ������ (�����):  "); 
	 str = Console.ReadLine();
	 bukva= char.Parse(str); 	
	 
	 newbuk = bukva;
	 delta = (int)char.GetNumericValue(cifra);
	 if(delta >0)
		 if(char.IsUpper(bukva))
		   {
			 newbuk = (char)(bukva + delta);
			 if(newbuk > 'Z')
				 newbuk = (char)('A' + (newbuk - 'Z' - 1));
		   }

	 if(newbuk == bukva)
		str = "�������������� �� ����";
	 else
	    str = string.Format("{0} ---> {1}",bukva,newbuk);
	 Console.WriteLine(str);
	 
	 Console.Write("��� ������� ���������� ������ ������� Y: ");
	 rep = char.Parse(Console.ReadLine());  // ���� string, �� ��� Parse
	 Console.WriteLine();
	 if(rep == 'Y' || rep == 'y') goto REPEAT;	// "Y" , "y"
  } //����� ����������� ������
} //����� ���������� ������

