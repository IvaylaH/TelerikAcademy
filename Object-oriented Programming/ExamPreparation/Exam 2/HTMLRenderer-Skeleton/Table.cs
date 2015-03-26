using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLRenderer
{
    public class Table : Element, ITable
    {
        // fields
        private int rows;
        private int cols;
        private IElement[,] tableElements;

        // constructors
        public Table(int inputRows, int inputCols)
            : base("table")
        {
            this.Rows = inputRows;
            this.Cols = inputCols;
            this.tableElements = new IElement[this.Rows, this.Cols];
        }

        // properties
        public int Rows
        {
            get { return this.rows; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("We cannot have as negative number for rows!");
                }
                this.rows = value; 
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("We cannot have as negative number for cols!");
                } 
                
                this.cols = value; 
            }
        }

        public override string TextContent
        {
            get {  return null; }
            set
            {
                throw new  InvalidOperationException("Table elements do not have content!");
            }
        }
        public virtual IElement this[int row, int col]
        {
            get { return this.tableElements[row, col]; }
            set
            {
                if (row < 0 || row > this.Rows || col < 0 || col > this.Cols)
                {
                    throw new ArgumentOutOfRangeException("The current index is out of the range ot the table!");
                }

                this.tableElements[row, col] = value;
            }
        }

        // methods
        public override void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int i = 0; i < this.Rows; i++)
            {
                output.Append("<tr>");
                for (int j = 0; j < this.Cols; j++)
                {
                    output.Append("<td>");
                    this.tableElements[i, j].Render(output);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }
    }
}
