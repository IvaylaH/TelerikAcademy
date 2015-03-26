using System;
using System.Collections.Generic;

public class PDFDocument : EncryptableDocument
{
    // fields
    private long? numberOfPages;

    // properties
    public long? NumberOfPages
    {
        get { return this.numberOfPages; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The number of pages the current PDF document contains cannot be a negative number!");
            }

            this.numberOfPages = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.NumberOfPages = long.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        base.SaveAllProperties(output);
    }
}
