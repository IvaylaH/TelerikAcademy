using System;
using System.Collections.Generic;

public class WordDocument : OfficeDocument, IEditable
{
    // fields
    private long? numOfChars;

    // properties
    public long? NumOfChars
    {
        get { return this.numOfChars; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The number of characters in the word document cannot be a negative number!");
            }

            this.numOfChars = value;
        }
    }
    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.NumOfChars = long.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.NumOfChars));
        base.SaveAllProperties(output);
    }
    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }
}