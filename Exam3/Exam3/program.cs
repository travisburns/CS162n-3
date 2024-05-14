class Program
{
    static void Main(string[] args)
    {
        
        Professor professor = new Professor("L123456", "Tom", "Wayne", "Computer Science");

       
        Console.WriteLine(professor.ToString());

      
        professor.LNumber = "L654321";
        professor.Department = "Mathematics";

        Console.WriteLine(professor.ToString());
    }
}