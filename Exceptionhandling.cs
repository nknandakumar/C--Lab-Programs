using System ;

class handlingpg{
    public static void Main(string[]args){
        try{
         int a = 20 ;
         int b = 0 ;
         int c = a/b ;
        }catch(Exception e){
            Console.WriteLine(e);
        }
           Console.WriteLine("End of the program");
        Console.ReadLine();
     
    }
}