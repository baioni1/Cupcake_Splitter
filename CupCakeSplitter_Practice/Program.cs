using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupCakeSplitter_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
             Console.WriteLine("How many cupcakes do you have?");
             int cupcakes = 0;
            //this is a way to not continue until the TryParse succeeds and cupcakes is >0
            //you can use this way to catch issues with the code instead of using a try/catch
             while (!int.TryParse(Console.ReadLine(),out cupcakes) || cupcakes<=0)
                 {
                      Console.WriteLine("Please enter a whole number.");
                 }
             Console.WriteLine("How many people are sharing?");
             int people = 0;
             while(!int.TryParse(Console.ReadLine(),out people)&& people>0)
                 {
                      Console.WriteLine("Please enter a whole number");
                 }
             //example of using a try/catch to catch exeptions
            try
            {
                int cupcakesPerPerson = cupcakes / people;
                int remainingCupcakes = cupcakes % people;
                Console.WriteLine($"Each person gets {cupcakesPerPerson}, and there are {remainingCupcakes} left over.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide cupcakes by 0 people.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Exeption");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number.");
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
