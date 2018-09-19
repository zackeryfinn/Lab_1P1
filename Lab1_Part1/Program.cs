using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Part1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //Collect input for the two numbers & verify that they are true 3-digit numbers
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Hello! Please enter a three-digit number (example 123) - ");
                var numOne = Console.ReadLine();
                int first = 0;
                int second = 0;


                while ((numOne.Length != 3) | (!Int32.TryParse(numOne, out first)))
                {
                    Console.WriteLine("Sorry, that is not a valid option. Please enter a valid number.");
                    numOne = Console.ReadLine();
                }

               

                Console.Write("Great! Now please enter another three-digit number - ");
                var numTwo = Console.ReadLine();


                while ((numTwo.Length != 3) | (!Int32.TryParse(numTwo, out second)))
                {
                    Console.WriteLine("Sorry, that is not a valid option. Please enter a valid number.");
                    numTwo = Console.ReadLine();
                }

                Console.WriteLine("Your first number is " + numOne + " and your second number is " + numTwo);
                Console.WriteLine("Let's see if each corresponding place in the two nubmers (ones, tens, hundreds) are all equal.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadKey();

                //In this part we pull the 100s 10s and 1s variables

                
                var tensA = 0;
                var onesA = 0;
                var hunsA = 0;
                var tensAA = 0;

                //start with the first number

                
               // Int32.TryParse(numOne, out first);

                
                hunsA = first / 100;
                
                tensAA = (first % 100);

                tensA = (first % 100) / 10;

                onesA = (tensAA % 10);
                

                // now the second number

                var tensB = 0;
                var onesB = 0;
                var hunsB = 0;
                var tensBB = 0;

               

                
                //Int32.TryParse(numTwo, out second);

                hunsB = second / 100;
                
                tensBB = (second % 100);

                tensB = (second % 100) / 10;

                onesB = (tensBB % 10);

                // this is the part where we do the math 

                int sumHuns = 0;
                int sumTens = 0;
                int sumOnes = 0;

                sumHuns = hunsA + hunsB;
                sumTens = tensA + tensB;
                sumOnes = onesA + onesB;

                //test to see if they are equal



                if ((sumHuns == sumTens) && (sumTens == sumOnes)) 
                {
                    Console.WriteLine(hunsA + " + " + hunsB + " = " + sumHuns);
                    Console.WriteLine(tensA + " + " + tensB + " = " + sumTens);
                    Console.WriteLine(onesA + " + " + onesB + " = " + sumOnes);
                    Console.WriteLine("SOOOO COOOOL! The sums are all equal.");
                    Console.WriteLine("You sure know how to pick neat numbers!");
                }
                else
                {
                    Console.WriteLine(hunsA + " + " + hunsB + " = " + sumHuns);
                    Console.WriteLine(tensA + " + " + tensB + " = " + sumTens);
                    Console.WriteLine(onesA + " + " + onesB + " = " + sumOnes);
                    Console.WriteLine("Sorry! The sum of the columns do not equal each other.");
                    Console.WriteLine("Better luck next time!");
                }

                // this is the end part if you want to do it again

                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }











        }
    }
}
