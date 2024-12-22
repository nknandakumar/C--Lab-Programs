using System ;

class switchPg {
    public static void Main(string[]args){
        Console.WriteLine("Enter the Character :- ");
        char c = char.Parse(Console.ReadLine());
        switch(c){
            case 'a':
            case 'i':
            case 'o':
            case 'u':
            case 'e':
             Console.Write("You Entered Vowel ");
             Console.ReadLine();
             break ;
             default :
              Console.Write("You Entered Consonants");
               Console.ReadLine();
             break ;
        }
    }
}