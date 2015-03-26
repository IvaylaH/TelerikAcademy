using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Document : IDocument
{
    // fields
    private string name;
//    private IList<KeyValuePair<string, object>> listOfProperties;

    // cosntructors
    public Document(string inputName) //, string content = null)
    {
        this.Name = inputName;
        // this.Content = content;
    //       listOfProperties = new List<KeyValuePair<string, object>>();
    }

    public Document()
    {

    }

        // properties
    public string Name
    {
        get { return this.name; }
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name of the text document cannot be null or empty!");
            }

            this.name = value;
        }
    }

    public string Content { get; protected set; }

/*    public IList<KeyValuePair<string, object>> ListOfProperties
    {
        get { return new List<KeyValuePair<string, object>>(this.listOfProperties); }
    }*/

    public virtual void LoadProperty(string key, string value) // !?!?!?!?
    {
        if (key == "name")
        {
            this.Name = value;
        }

        if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output) // !?!?!
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");
        IList<KeyValuePair<string, object>> propeties = new List<KeyValuePair<string, object>>();
        SaveAllProperties(propeties);
        var sortedProps = propeties.OrderBy(pr => pr.Key);
        foreach (var prop in sortedProps)
        {
            if (prop.Value != null)
            {
                result.Append(prop.Key);
                result.Append("=");
                result.Append(prop.Value);
                result.Append(";");
            }   
        }
        result.Length--;
        result.Append("]");

        return result.ToString();
    }
}
