namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
             string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine();
        }
        //Exercise 2
        public static double Add(double x, double y) 
        { 
            return x + y;
        }

        public static int Multiply (int x, int y)
        {
          return x * y;

        }

        public static int Quotient (int x, int y)

        {
            return x / y; 
        }

        public static int Subtract (int x, int y)
        {
            return x- y;
        }




    }





}
