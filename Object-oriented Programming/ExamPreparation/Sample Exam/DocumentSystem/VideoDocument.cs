using System;
using System.Collections.Generic;

public class VideoDocument : MultimediaDocument
{
    // fields
    private long? frameRate;

    // constructors
    public VideoDocument(string inputName)
        : base(inputName)
    {

    }

    public VideoDocument() : base()
    {
    }

    // properties
    public long? FrameRate
    {
        get { return this.frameRate; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The frame rate of the video document cannot be negative number!");
            }

            this.frameRate = value;
        }
    }

    // methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);   
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        base.SaveAllProperties(output);
    }
}
