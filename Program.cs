
using System;
using System.Numerics;

namespace FunQuizQuestionsForChildren
{
    internal class Program
    {

        static void Main(string[] args)
        {

           

            Console.WriteLine("**************");
            Console.WriteLine("welcome to the game");
            Console.WriteLine("**************" );

            int question=1;
            string answer;


            if (question == 1)
            {
                Console.WriteLine("question1");
                Console.WriteLine();
                Console.WriteLine("What number is on Lightning McQueen in Cars movie? ");
                Console.WriteLine("A)95");
                Console.WriteLine("B)96");
                Console.WriteLine("C)97");
                Console.WriteLine("D)98");
                Console.WriteLine("Your answer is: ");
                answer = Console.ReadLine();

                if (answer == "a" || answer == "A")
                { 
                  question = question + 1;
                }
                else
                {
                    Console.WriteLine("Your score is 0.");

                }
            }
            Console.WriteLine();
            if (question == 2)
            {
                Console.WriteLine("question2");
                Console.WriteLine();
                Console.WriteLine(" What were Padmé's last words? ");
                Console.WriteLine("A)Please give you everything. Anything you want!");
                Console.WriteLine("B)We're losing power. It looks like there's something wrong with the main reactor.");
                Console.WriteLine("C)Obi - Wan… he has… he has Goodness.There is a lesson.");
                Console.WriteLine("D)You were right, Obi-Wan");
                Console.WriteLine("Your answer is: ");
                answer = Console.ReadLine();

                if (answer == "c" || answer == "C")
                {
                    Console.WriteLine("congratulation!");
                    question++;
                }
                else
                {
                    Console.WriteLine("Your score is 1.");

                }

            }
            Console.WriteLine();
            if (question == 3)
            {
                Console.WriteLine("question3");
                Console.WriteLine();
                Console.WriteLine("What did Luke Skywalker lose in his fight against Darth Vader? ");
                Console.WriteLine("A)left hand");
                Console.WriteLine("B)right hand");
                Console.WriteLine("C)left foot");
                Console.WriteLine("D)right foot");
                Console.WriteLine("Your answer is: ");
                answer = Console.ReadLine();

                if (answer == "b" || answer == "B")
                {
                    Console.WriteLine("congratulation! YOU WIN!!");
                    question++;
                }
                else
                {
                    Console.WriteLine("Your score is 2.");

                }


                Console.Read();

            }
        }
    }
}
