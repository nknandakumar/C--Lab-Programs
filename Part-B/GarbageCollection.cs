using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public class pg6
{
  public static async void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine("01 number of Generations \n 02 Generation n0 of objects \n 03 Numbers of Byte Allocated \n 04  Exit");
      int ch = int.Parse(Console.ReadLine());
      pg6 p = new pg6();
      switch(ch){
        case 1 : Console.WriteLine("No of Generation is {0} ",GC.MaxGeneration);
         break ;
          case 2 : Console.WriteLine("Generation no of objects {0} ",GC.GetGeneration(p));
         break ;
          case 3 : Console.WriteLine("No of byte Allocation is {0} ",GC.GetTotalMemory(true));
         break ;
         System.Environment.Exit(0);
         break ;
      }
    }

  }
}