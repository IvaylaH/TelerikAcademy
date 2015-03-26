using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLRenderer
{
    public class Element : IElement
    {
        // fields
        private string name;
        private string textContent;
        private IList<IElement> childElements;

        // constructors
        public Element(string inputName)
        {
            this.Name = inputName;
            this.childElements = new List<IElement>();
        }

        public Element(string inputName, string inputContent) // not sure if I should set the values to 0
        : this(inputName)
        {
            this.TextContent = inputContent;
        }

        // properties
        public virtual string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public virtual string TextContent
        {
            get { return this.textContent; }
            set { this.textContent = value; }
        }

        public virtual IEnumerable<IElement> ChildElements
        {
            get { return new List<IElement>(this.childElements); }
        }

        // methods
        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append(string.Format("<{0}>", this.Name));
            }

            if (this.TextContent != null)
            {
                output.Append(HTMLEndoce(this.TextContent));
            }

            if (this.childElements.Count > 0)
            {
                foreach (var element in this.childElements)
                {
                    element.Render(output);
                }
            }

            if (this.Name != null)
            {
                output.Append(string.Format("</{0}>", this.Name));
            }
        }

        protected string HTMLEndoce(string textContent)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < textContent.Length; i++)
            {
                if (textContent[i] == '<')
                {
                    result.Append("&lt;");
                }
                else if (textContent[i] == '>')
                {
                    result.Append("&gt;");
                }
                else if (textContent[i] == '&')
                {
                    result.Append("&amp;");
                }
                else
                {
                    result.Append(textContent[i]);
                }
            }    

            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder ouptut = new StringBuilder();
            this.Render(ouptut);

            return ouptut.ToString();
        }
    }
}
