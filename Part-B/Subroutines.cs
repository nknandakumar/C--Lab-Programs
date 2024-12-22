
using System ;

namespace b2 {
    class b2{
        public string show(string msg){
          Console.WriteLine("Inside Function!");
          return msg ;
        }
       public static void Main(string[]args){
          b2 b =  new b2();
          string msg = b.show("Every One");
          Console.Write("Hello.."+msg);
          Console.ReadLine();
       }
    }
}