using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var answer = 13;
            //string response;

            // Console.WriteLine((answer <= 9) ? response = answer + " is less than nine" : response = answer + " is greater than or equal to nine" )  ;

            var answer = 15;
            var response = (answer <= 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);




        }
    }
}
