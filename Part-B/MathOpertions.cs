using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
delegate int MyDel(int n1, int n2);

public class mathOper
{
  public static int add(int n1, int n2)
  {
    return n1 + n2;
  }
  public static int sub(int n1, int n2)
  {
    return n1 - n2;
  }
  public static int multi(int n1, int n2)
  {
    return n1 * n2;
  }
  public static int div(int n1, int n2)
  {
    return n1 / n2;
  }
}

class program
{
static void Main()
  {
    MyDel[] oper = { mathOper.add, mathOper.sub, mathOper.multi, mathOper.div };
    int res = 0;
    Console.WriteLine("Input the two Numbers :- ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < oper.Length; i++)
    {
      res = oper[i](n1,n2);
      Console.WriteLine("operationof [{0}]",i);
      Console.WriteLine("Result = {0}",+res);
    }
    Console.ReadLine();
  }
}