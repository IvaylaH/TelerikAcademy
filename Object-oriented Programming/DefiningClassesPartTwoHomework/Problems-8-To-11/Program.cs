using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_8_To_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] doubleMatrix = { { 1, 3, 4.5, 3.6 }, { 1.5, 12, 0.3, 2.1}, { 1.4, 7.2, 3, 0.4 }, {1.1, 5.6, 0.3, 1.4} };
            double [,] intMatrix = { { 1.2, 6, 3, 2 }, { 2.8, 7, 11, 0.0 }, { 5, 9, 3.9, 6 }, {1.2, 3.6, 0.7, 0.4} };

            Matrix<double> firstMatrix = new Matrix<double>(doubleMatrix);
            Matrix<double> secondMatrix = new Matrix<double>(intMatrix);

            // check if inside the matrix there is a cell with value equal to 0
            if (firstMatrix)
            {
                Console.WriteLine("There is no cell equal to 0 inside our matrix");
            }
            else
            {
                Console.WriteLine("There is at least one cell inside the current matrix with value equal to 0");
            }

            if (secondMatrix)
            {
                Console.WriteLine("There is no cell equal to 0 inside our matrix");
            }
            else
            {
                Console.WriteLine("There is at least one cell inside the current matrix with value equal to 0");
            }

            // testing if the override of the operators is working properly
            Console.WriteLine(new string ('-', 50));
            Console.WriteLine("The result from: 'firstMatrix + secondMatrix' is: ");
            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine("The result from: 'firstMatrix - seconteMatrix' is: ");
            Console.WriteLine(firstMatrix - secondMatrix); 
            Console.WriteLine("The result from: 'firstMatrix * secondMatrix' is: ");
            Console.WriteLine(firstMatrix * secondMatrix);
        }
    }
}
