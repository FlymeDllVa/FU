
using System;
// ����� Account ���������� ���������� ����.
public class Account
{
   //�������� ���� ������
   int debit  = 0, 
        credit = 0;

   // ���������� �� ���� � ���������

   public void putMoney (int sum)
   {
      int res =1;
      if (sum >0)credit += sum;
      else res = -1;
      Mes(res,sum);
   }


   // ������ �� ����� � ���������
   public void getMoney (int sum)
   {
      int res=2;
      if(sum <= balance())debit += sum;
      else res = -2;
      balance();
      Mes(res, sum);
   }


   // ���������� �������
   int balance()
   {
      return(credit - debit);	
   }

   // ����������� � ���������� ��������
   void Mes (int result, int sum)
   {
      switch (result)
      {
         case 1:
            Console.WriteLine("�������� ���������� ����� ������ �������!");
            Console.WriteLine("C����={0}, 
               ��� ������� ������={1}", sum,balance());
            break;
         case 2:
            Console.WriteLine("�������� ������ ����� 
               ������ �������!");
            Console.WriteLine("C����={0}, 
               ��� ������� ������={1}", sum,balance());
            break;
         case -1:
            Console.WriteLine("�������� ���������� ����� 
               �� ���������!");
            Console.WriteLine("����� ������ ���� ������ ����!");
            Console.WriteLine("C����={0}, 
               ��� ������� ������={1}", sum,balance());
            break;
         case -2:
            Console.WriteLine("�������� ������ ����� �� ���������!");
            Console.WriteLine("����� ������ ���� 
               �� ������ �������!");
            Console.WriteLine("C����={0}, 
               ��� ������� ������={1}", sum,balance());
            break;
         default:
            Console.WriteLine("����������� ��������!");
            break;
      }
   }
}//Account


public class Test1
{
   public void Main()
   {
      Account1 myAccount = new Account1();
      myAccount.putMoney(6000);
      myAccount.getMoney(2500);
      myAccount.putMoney(1000);
      myAccount.getMoney(4000);
      myAccount.getMoney(1000);
   }
}
