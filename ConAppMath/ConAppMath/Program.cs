using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ConAppMath
{
    class Program
    {
        static void Main(string[] args)
        {
            multiplicationExample();
        }

        private static void multiplicationExample()
        {
            DenseMatrix matrixA = DenseMatrix.OfArray(new[,] { { 2.0, 3.0 }, { 1.0, 4.0 } });
            DenseMatrix matrixB = DenseMatrix.OfArray(new[,] { { 3.0, 2.0}, { 1.0, -6.0 } });

            DenseMatrix result = matrixA * matrixB;
            Console.WriteLine(result);
        }
    }
}
