using System;
using System.Collections.Generic;

public abstract class EncryptableDocument : BinaryDocument, IEncryptable
{
    // fields
    private bool isEncrypted;

    // properties

    public bool IsEncrypted
    {
        get { return this.isEncrypted; }
        protected set
        {
            this.isEncrypted = value;
        }
    }

    // methods
    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }

    public override string ToString()
    {
        if (this.IsEncrypted)
        {
            return this.GetType().Name + "[encrypted]";
        }
        else
        {
            return base.ToString();
        }
    }
}
