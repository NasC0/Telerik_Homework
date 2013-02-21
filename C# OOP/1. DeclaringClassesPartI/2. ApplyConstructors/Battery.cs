using System;

public class Battery
{
    private string model;
    private double? idleHours;
    private double? talkHours;

    public Battery() : this(null, null, null)
    {
        
    }

    public Battery(string model) : this(model, null, null)
    {

    }

    public Battery(string model, double? idleHours) : this(model, idleHours, null)
    {
        
    }

    public Battery(string model, double? idleHours, double? talkHours)
    {
        this.model = model;
        this.idleHours = idleHours;
        this.talkHours = talkHours;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double? IdleHours
    {
        get { return this.idleHours; }
        set { this.idleHours = value; }
    }

    public double? TalkHours
    {
        get { return this.talkHours; }
        set { this.talkHours = value; }
    }


}
