using System;
using System.Collections.Generic;

public class TextDocument : Document, IEditable
{
    // fields
    private string charset;

    // cosntructors
    public TextDocument(string inputName) //, string content = null)
        : base(inputName) // , content)
    {
            
    }
        
    public TextDocument()
        :base()
    {

    }

    // properties
    public string Charset
    {
        get { return this.charset; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The charset of the text document cannot be null or empty!");
            }

            this.charset = value;
        }
    }   

    // methods
        public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
}
