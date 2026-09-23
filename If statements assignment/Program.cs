namespace If_statements_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartOne();
            //PartTwo();
            //PartThree();
        }
        public static void PartOne()
        {
            string weight;
            string planet;
            Console.WriteLine("please enter your current Earth weight");
            weight = Console.ReadLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter 4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("Which planet are you visiting?");
            planet = Console.ReadLine();
            if (planet == "1")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 0.78) + " pounds on Venus.");
            }
            else if (planet == "2")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 0.39) + " pounds on Mars.");
            }
            else if (planet == "3")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 2.65) + " pounds on Jupiter.");
            }
            else if (planet == "4")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 1.17) + " pounds on Saturn.");
            }
            else if (planet == "5")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 1.05) + " pounds on Uranus.");
            }
            else if (planet == "6")
            {
                Console.WriteLine("Your weight would be " + (Convert.ToDouble(weight) * 1.23) + " pounds on Neptune.");
            }

        }
        public static void PartTwo()
        {
            string num1;
            string num2;
            string operation;
            Console.WriteLine("Please enter a number");
            num1 = Console.ReadLine();
            Console.WriteLine("Please enter an operation (+, -, /, X");
            operation = Console.ReadLine();
            Console.WriteLine("Please enter another number");
            num2 = Console.ReadLine();
            if (operation == "+")
            {
                Console.WriteLine("The result is " + (Convert.ToDouble(num1) + Convert.ToDouble(num2)));
            }
            else if (operation == "-")
            {
                Console.WriteLine("The result is " + (Convert.ToDouble(num1) - Convert.ToDouble(num2)));
            }
            else if (operation == "/")
            {
                Console.WriteLine("The result is " + (Convert.ToDouble(num1) / Convert.ToDouble(num2)));
            }
            else if (operation == "X")
            {
                Console.WriteLine("The result is " + (Convert.ToDouble(num1) * Convert.ToDouble(num2)));
            }

        }
        public static void PartThree()
        {
            string ans1;
            string ans2;
            string ans3;
            string ans4;
            string score;
            score = "0";
            Console.WriteLine("Welcome to the quiz! Please answer the following questions with a, b, or c.");
            Console.WriteLine("Question 1: What is the capital of France?");
            Console.WriteLine("a) Paris");
            Console.WriteLine("b) London");
            Console.WriteLine("c) Berlin");
            ans1 = Console.ReadLine();
            if (ans1 == "a")
            {
                Console.WriteLine("Correct!");
                score = (Convert.ToInt32(score) + 1).ToString();
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is a) Paris.");
            }
            Console.WriteLine("Question 2: The CN Tower is the worlds tallest tower");
            Console.WriteLine("True");
            Console.WriteLine("False");
            ans2 = Console.ReadLine();
            if (ans2 == "False")
            {
                Console.WriteLine("Correct!");
                score = (Convert.ToInt32(score) + 1).ToString();
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is False.");
            }
            Console.WriteLine("Question 3: What is the chemical symbol for gold?");
            ans3 = Console.ReadLine();
            if (ans3 == "AU")
            {
                Console.WriteLine("Correct!");
                score = (Convert.ToInt32(score) + 1).ToString();
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is Au.");
            }
            Console.WriteLine("Question 4: number between 1 and 20");
            ans4 = Console.ReadLine();
            if (ans4 == "7")
            {
                Console.WriteLine("Correct!");
                score = (Convert.ToInt32(score) + 1).ToString();
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 7.");
            }
            Console.WriteLine("Your final score is " + score + "/4");
        }

    }
}
