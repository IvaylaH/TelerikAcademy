using System;
using System.Collections.Generic;

public abstract class OfficeDocument : EncryptableDocument
{
    // fields
    private string version;

    // properties
    public string Version
    {
        get { return this.version; }
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The version of the office document cannot be null or empty!");
            }

            this.version = value;
        }
    }
    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
        {
            this.Version = value;
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("version", this.Version));
        base.SaveAllProperties(output);
    }
}