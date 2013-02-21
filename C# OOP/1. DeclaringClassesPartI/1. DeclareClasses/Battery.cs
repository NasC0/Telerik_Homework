using System;

public class Battery
{
    private string model;
    private double idleHours;
    private double talkHours;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double IdleHours
    {
        get { return this.idleHours; }
        set { this.idleHours = value; }
    }

    public double TalkHours
    {
        get { return this.talkHours; }
        set { this.talkHours = value; }
    }
}
