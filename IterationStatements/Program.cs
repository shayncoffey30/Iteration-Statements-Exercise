namespace MethodsWithLoopsAndConditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Threes();
            //PrintThousand();

            IsEqual(10, 9);
            Console.WriteLine(IsEqual(9, 9));
            Console.WriteLine(IsTenRange(13));
            Console.WriteLine(OfVotingAge(17));
            EvenOrOdd(9);
            Multiply(7);
        }


        //Write a method that
        //will print to the console numbers 3 through 999  by 3 each time.
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {

                Console.WriteLine(k);

            }

        }




        //Write a method that will print
        //to the console all numbers 1000 through - 1000.
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }



        //Write a method to check if an integer (from the user) is in the range -10 to 10
        static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }

            return false;
        }





        //Write a method to accept two
        //integers as parameters
        //and check whether they are equal or not.
        static bool IsEqual(int a, int b)
        {
            //how do I determine if two numbers are the same?
            if (a == b)
            {
                return true;
            }

            return false;

        }


        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else
            {
                Console.WriteLine($"Too young to vote by {18 - age} years");
                return false;
            }

        }

        public static void EvenOrOdd(int number)
        {
            
                if (number % 2 == 0)
                {
                    Console.WriteLine($"yo that's even");
                }
                else
                {
                    Console.WriteLine($"definitely odd");
                }

            

        }

        public static void Multiply(int numOne)
        {
            for (int i = 1; i <= 12; i++)

            {
                Console.WriteLine(i * numOne);

            }
            
                           


        }


    }
}

