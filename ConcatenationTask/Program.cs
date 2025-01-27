namespace ConcatenationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            int age;
            Console.WriteLine("Enter first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + FirstName + " " + LastName + " you are " + age + " years old");
            // save and commit your program
            // add evidence of the test input and your own input running the program
        }
    }
}
