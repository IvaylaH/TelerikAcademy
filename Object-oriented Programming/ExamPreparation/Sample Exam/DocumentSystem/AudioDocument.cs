using System;
using System.Collections.Generic;

public class AudioDocument : MultimediaDocument
{
    // fields
    private long? sampleRate;

    // constructors
    public AudioDocument(string inputName)
        : base(inputName)
    {

    }

    public AudioDocument() : base()
    {
    }

    // properties
    public long? SampleRate
    {
        get { return this.sampleRate; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The rate of the audio document cannot be negative number!");
            }

            this.sampleRate = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRate = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        base.SaveAllProperties(output);
    }
}
