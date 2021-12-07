namespace NewMethodExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your cats name?");
            string userCatName = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string userFrom = Console.ReadLine();

            Console.WriteLine($"There was a lady named {userName}, she was {age} years old");
            Console.WriteLine($"She had a cat named {userCatName}, she was from {userFrom}");
            Console.WriteLine($"{userName} liked the {userCatName}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The sum is {product}");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}