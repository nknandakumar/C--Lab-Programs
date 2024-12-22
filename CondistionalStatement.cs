using System ;

class program1 {
    public static void Main(){
        int num1 ,num2, num3 ;
        Console.Write("Enter the Number1 value : - ");
        num1 = Convert.ToInt32(Console.ReadLine());

          Console.Write("Enter the Number2 value : - ");
        num2 = Convert.ToInt32(Console.ReadLine());
        

          Console.Write("Enter the Number3 value : - ");
        num3 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("")

        if (num1 > num2)
        {
            if(num1 > num2){
               Console.Write("Number 1 is greatest among three numbers");
            }else{
                  Console.Write("Number 3 is greatest among three numbers");
            }
            
        }else if(num2 > num3){
              Console.Write("Number 2 is greatest among three numbers");
        }else{
                Console.Write("Number 3 is greatest among three numbers");
        }
        
        Console.ReadLine();
    }
}