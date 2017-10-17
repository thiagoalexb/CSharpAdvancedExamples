using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvancedExamples.LambdaExpressions
{
    public class LambdaExpressions
    {
        //Usa-se delegates para as lambdas (Func e Action)
        public void Lambdas()
        {
            //Se nao precisar de argumento () =>
            //Um argumento x =>
            //Varios argumentos (x,z,y) =>
            Func<int, int> NomeDaLambda = Square; //Ponteiro para o método
            Console.WriteLine(NomeDaLambda(5));
            //or
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(15));
        }
        

        public int Square(int number)
        {
            return number * number;
        }
    }
}
