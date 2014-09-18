using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the function 
            maxPrime(1001);
           
            //call the function 
            FibonacciSequencer(1000000000);
           
            Console.ReadKey();
        }



        //maxPrime Fuction
        //create a loop that looops through all the numbers and prints the prime numbers
        static void maxPrime(int max)
        {
            //declare the variables

            int i = 0;
            int p = 0;
            //add one the prime numbers
            int prime = 1; 
            List<int> output = new List<int>();


            //test for prime
            //Loop numbers untill 10001

            for (p = 1; prime <= max + 1; p = p + 1)
            {
                //i is not prime
                if (i % p == 0 && p != i && i != 1)
                {
                    p = 1;
                    i = i + 1;
                }
                //i is prime and +1 to the output
                else if (p == i)
                {
                    output.Add(i);
                    p = 1;
                    i = i + 1;
                }

            }

            Console.WriteLine(output);
        }

        //Even FibonacciSequencer
        //Adds the fibonncaci numbers together to get the sum, starting with 1 and 2 
        static int FibonacciSequencer(int maxValue)
        {
            //variables
            int currNum = 2;
            int prevNum = 1;
            int output = 0;
            List<int> evenNum = new List<int>();
            List<int> fibNum = new List<int>(1);
            //use a while loop to loop through to the max number
            while (currNum < maxValue)
            {

                currNum = prevNum + currNum;
                if (currNum <= maxValue)
                {
                    fibNum.Add(currNum);
                }
                prevNum = fibNum[fibNum.Count - 1];
            }
            //add all even numbers to a list then add them together to get the output
            evenNum = fibNum.Where(x => x % 2 == 0).ToList();
            foreach (var item in evenNum)
            {
                output = output + item;
            }
            return output;
        }
    }
}



       