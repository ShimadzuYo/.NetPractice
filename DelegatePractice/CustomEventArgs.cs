using System;

public class CustomEventArgs : EventArgs
{
    public CustomEventArgs(int val)
    {
        Value = val;

    }

    public int Value { get; set; }
}