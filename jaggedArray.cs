using System ;


namespace program3 {
    class JaggedArray{
        int[][] jagged = new int[3][];


        public void Read(){
            Console.WriteLine("Enter the Size of first inner Array :- ");
            jagged[0] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value for first inner Array :- ");
            for (int i = 0; i < jagged[0].Length; i++)
               jagged[0][i] = int.Parse(Console.ReadLine());
               //Second inner array
                Console.WriteLine("Enter the Size of Second inner Array :- ");
            jagged[1] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value for Second inner Array :- ");
            for (int i = 0; i < jagged[1].Length; i++)
               jagged[1][i] = int.Parse(Console.ReadLine());
               //3rd inner Array
                Console.WriteLine("Enter the Size of Third inner Array :- ");
            jagged[2] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter the value for Third inner Array :- ");
            for (int i = 0; i < jagged[2].Length; i++)
               jagged[2][i] = int.Parse(Console.ReadLine());
        }
        public void process(){
            int sum = 0 ;
            for (int i = 0; i < jagged[0].Length; i++)
                      sum = sum+ jagged[0][i];
                       for (int i = 0; i < jagged[1].Length; i++)
                      sum = sum+ jagged[1][i];
                       for (int i = 0; i < jagged[2].Length; i++)
                      sum = sum+ jagged[2][i];

                      Console.WriteLine("Sum of all three inner array is = {0}",sum);
        }
        public void display(){
            Console.WriteLine("Elements of first inner Array :- ");
            for (int i = 0; i < jagged[0].Length; i++)
              Console.Write(jagged[0][i]);
              //
                          Console.WriteLine("Elements of Second inner Array :- ");
            for (int i = 0; i < jagged[1].Length; i++)
              Console.Write(jagged[1][i]);
              //
                          Console.WriteLine("Elements of Third inner Array :- ");
            for (int i = 0; i < jagged[2].Length; i++)
              Console.Write(jagged[2][i]);
        }
    }
    class ArrayTest{
     public static void Main(string[]args){
           JaggedArray ja = new JaggedArray();
          ja.Read();
         
          ja.display();
           ja.process();
          Console.ReadLine();
     }


    }
}