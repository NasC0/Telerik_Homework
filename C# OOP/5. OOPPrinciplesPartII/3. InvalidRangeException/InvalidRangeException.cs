using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class InvalidRangeException<T> : ApplicationException
{
    private T min;
    private T max;

    public T Min
    {
        get { return this.min; }
    }

    public T Max
    {
        get { return this.max; }
    }

    public InvalidRangeException(string message, T min, T max, Exception exceptionCause = null)
        : base(message, exceptionCause)
    {
        this.min = min;
        this.max = max;
    }

    public InvalidRangeException(string message, T min, T max)
        : this(message, min, max, null)
    {
        
    }

    public InvalidRangeException(T min, T max)
        : this(null, min, max, null)
    {
        
    }
}
