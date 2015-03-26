using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExcelDocument : OfficeDocument
{
    // fields
    private long? numberOfRows;
    private long? numberOfCols;

    // properties
    public long? NumberOfRows
    {
        get { return this.numberOfRows; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The number of rows of the table cannot be a negative number!");
            }

            this.numberOfRows = value;
        }
    }

    public long? NumberOfCols
    {
        get { return this.numberOfCols; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The number of columns of the table cannot be a negative number!");
            }

            this.numberOfCols = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.NumberOfRows = long.Parse(value);
        }
        if (key == "cols")
        {
            this.NumberOfCols = long.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
        output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
        base.SaveAllProperties(output);
    }
}
