using System;
using System.Collections.Generic;

public abstract class MultimediaDocument : BinaryDocument
{
    // fields
    private long? length;

    // constructors
    protected MultimediaDocument(string inputName)
        : base(inputName)
    {

    }

    protected MultimediaDocument() : base()
    {
    }

    // properties
    public long? Length
    {
        get { return this.length; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("The length of the multimedia document cannot be negative number!");
            }

            this.length = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.Length = long.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("length", this.Length));
        base.SaveAllProperties(output);
    }
}
