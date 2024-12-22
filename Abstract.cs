using System ;

abstract class Employee {
    public abstract float GetSalary();
}

 class Developer : Employee {
    float salary ; 
    public void  DevDetails(){
        Console.Write("Enter the Salary of Developer :- ");
        salary = float.Parse(Console.ReadLine());
    }
    public override float GetSalary()
    {
        return salary ;
    }
}

class Driver : Employee {
    float salary ;
    public void DriverDetails(){
         Console.Write("Enter the Salary of Driver :- ");
        salary = float.Parse(Console.ReadLine());
    }
    public override float GetSalary()
    {
        return salary ;
    }
}

class Test {
    public static void Main(string[]args){
        Developer d1 = new Developer();
        Driver d2 = new Driver();
        d1.DevDetails();
        d2.DriverDetails();

        Console.WriteLine("Salary of Developer = {0} ",d1.GetSalary());
        
        Console.WriteLine("Salary of Driver = {0} ",d2.GetSalary());
        Console.ReadLine();
    }
}