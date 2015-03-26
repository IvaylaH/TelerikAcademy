using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_8_To_11
{
    public class Matrix<T>
    {
        // constants
        private const int size = 4;

        // fields
        private int row;
        private int col;
        private T[,] matrix;

        // constructors
        public Matrix()
        {
            this.matrix = new T[size, size];
        }

        public Matrix(int row, int col)  // check if it's working properly
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentException("Neither the value of row, nor the value fo col can be a negative number!");
            }

            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }

        public Matrix(T[,] newMatrix)
        {
            this.matrix = newMatrix;
            this.Row = matrix.GetLength(0);
            this.Col = matrix.GetLength(1);
        }

        // properties
        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }

        // declare indexer

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.Row) || (col < 0 || col > this.Col))
                {
                    throw new IndexOutOfRangeException("The index is out of the range of the current matrix");
                }

                return matrix[row, col];
            }
            set
            {
                if ((row < 0 || row > this.Row) || (col < 0 || col > this.Col))
                {
                    throw new IndexOutOfRangeException("The index is out of the range of the current matrix");
                }

                matrix[row, col] = value;
            }
        }

        // overloading the operator {+, -, *}
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix) 
        {
            if ((firstMatrix.Row != secondMatrix.Row) || (firstMatrix.Col != secondMatrix.Col))
            {
		        throw new FormatException("Only matrices with equal dimensions can be added!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int i = 0; i < firstMatrix.Row; i++)
			{
                for (int j = 0; j < firstMatrix.Col; j++)
			    {
			        result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
			    }
			}
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row != secondMatrix.Row) || (firstMatrix.Col != secondMatrix.Col))
            {
                throw new FormatException("Only matrices with equal dimensions can be subtracted!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Row != secondMatrix.Col)
            {
                throw new FormatException("In order to multiply 2 matrices, the number of rows of the first matrix should be different from the number of columns of the second matrix!");
            }

            int rows = firstMatrix.Row;
            int columns = secondMatrix.Col;
            Matrix<T> result = new Matrix<T>(rows, columns);

            for (int i = 0; i < rows; i++) //?!?
            {
                for (int j = 0; j < columns; j++) //?!?
                {
                    dynamic sum = 0;
                    for (int k = 0; k < columns; k++)
                    {
                        sum = sum + (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                    }

                    result.matrix[i, j] = sum;
                }
            }

            return result;
        }

        // true and false operators are checking whether inside the matrix there is a cell with value equal to zero; 
        public static bool operator true(Matrix<T> matrix)
        {
            int checker = 0;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == checker)
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            int checker = 0;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == checker)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder matrixSb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixSb.Append(matrix[i, j]);
                    matrixSb.Append(" ");
                }

                matrixSb.Append(Environment.NewLine);
            }

            return matrixSb.ToString();
        }
    }
}
