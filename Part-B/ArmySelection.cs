using System;
public class selectionProcess
{
  public static void Main(string[] args)
  {
    string[] name = new string[10];
    double[] height = new double[10];
    int i, count = 0;
    Console.WriteLine("Enter the Name and Height of Candidates : ");

    for (i = 1; i <= 10; i++)
    {
      Console.WriteLine("Enter the Name of Candidate {0} ", i);
      name[i] = Console.ReadLine();
      Console.WriteLine("Enter the Height of Candidate {0} ", i);
      height[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("<----------------------------->");
    Console.WriteLine("NAME \t\t HEIGHT");
    Console.WriteLine("<----------------------------->");

    for (i = 0; i < 10; i++)
    {
      Console.WriteLine("{0} \t\t {0}", name[i], height[i]);
    }

    Console.WriteLine("<-------------------------------->");
    // Console.WriteLine("");
    Console.WriteLine("Selected Persons are :- ");
    Console.WriteLine("<-------------------------------->");
    Console.WriteLine("NAME \t\t HEIGHT");
     Console.WriteLine("<-------------------------------->");
     for ( i = 0; i < 10; i++)
     {
      if (height[i]>157.5)
      {
           Console.WriteLine("{0} \t\t {0}", name[i], height[i]);
           count++ ;
      }
     }

     Console.WriteLine("The Total Numbers of Candidate Selected are = {0} ",count);
     Console.ReadLine();

  }
}