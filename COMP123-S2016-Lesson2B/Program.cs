using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson2B
{
    /**
     * Main driver class for Lesson2 
     * 
     * @class Program
     * 
     */
    public class Program
    {
        /**
         * Main Method for our drive class
         * 
         * @constructor Main
         * @pram {string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            int numberOfEntries = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);//pass 50 = +40
            Console.WriteLine(x);
            Console.WriteLine();

          

         
              Console.WriteLine("How many entries do you want to make");
              int.TryParse(Console.ReadLine(), out numberOfEntries);
             
              if(numberOfEntries > 0)
              {
                  readUntilEnd(numberOfEntries);
              }
        
         
        }
        
        /**
         * simple Method to add two values
         * 
         * @method addXandY
         * @param {int} firstNumber
         * @param {int} secondNumber
         */
        public static int addXandY(int firstNumber, int SecondNumber)
        {
            int result = 0;
            result = firstNumber + SecondNumber;
            return result;



        }

        /**
         * simple method to demonstrate pass by reference with ref Keyword
         * 
         * @method addYtoX
         * @param {ref int} X
         * @param {ref int} Y
         * 
         */
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }
        public static int readUntilEnd(int numberOfEntries)
        {
          
           
            string[] inputs = new string[numberOfEntries];
            int inputCounter=0;


            do
            {
                Console.WriteLine("Enter a value -('end' to stop): ");
                inputs[inputCounter] = "";
                inputs[inputCounter] = Console.ReadLine();
                inputCounter++;
               
            } while ((inputs[inputCounter-1] != "end")&&(inputCounter<numberOfEntries));

            return inputCounter;
        }
    }
}