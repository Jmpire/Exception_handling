using System;
using System.Text;
using System.Linq;
using System.IO;

namespace Exception_handling
{
    
    class Program
    {
        // This method divides 2 numbers and throws an exception if we divide by zero
        static int Divide(int num2)
        {
            int num1 = 10;
            if (num2 != 0)
            {
                int answer = num1 / num2;
                return answer;

            }
            else // If we try dividing by zero
            {
                throw new DivideByZeroException("You can't divide by zero");
            }

        }
        static void Main(string[] args)
        {
            // Get 2nd number from the user and call the divide method
            int num2;
            Console.Write("Num2: ");

            // Try block, Catch and finally
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Answer: {Divide(num2)}");;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException fe) // If person enters a string instead of a number
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Code is done running");
            }
        }
       
    }
}
