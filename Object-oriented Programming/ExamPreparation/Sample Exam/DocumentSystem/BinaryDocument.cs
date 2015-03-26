using System;
using System.Collections.Generic;

public abstract class BinaryDocument : Document
{
    // fields
    private long? size;

    // constructors
    protected BinaryDocument(string inputName) // string content = null)
        : base(inputName) //, content)
    {

    }

    protected BinaryDocument()
        :base()
    {

    }

    // properties
    public long? Size
    {
        get { return this.size; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("The size of the binary document cannot be a negative number!");
            }

            this.size = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.Size = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("size", this.Size));
        base.SaveAllProperties(output);
    }
}
