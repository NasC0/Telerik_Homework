using System;

public class GSM
{
    Battery Batter = new Battery(null, 0.0, 0.0);
    Display Display = new Display(0.0, 0);

    private string gsmModel;
    private string manufacturer;
    private decimal? price;
    private string owner;

    public GSM(string gsmModel, string manufacturer)
        : this(gsmModel, manufacturer, null, null, null, null)
    {

    }

    public GSM(string gsmModel, string manufacturer, decimal? price)
        : this(gsmModel, manufacturer, price, null, null, null)
    {

    }

    public GSM(string gsmModel, string manufacturer, decimal? price, string owner, Battery battery, Display display)
    {
        this.gsmModel = gsmModel;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.Batter.Model = battery.Model;
        this.Batter.IdleHours = battery.IdleHours;
        this.Batter.TalkHours = battery.TalkHours;
        this.Display.ColorsNumber = display.ColorsNumber;
        this.Display.Size = display.Size;
    }

    public string Model
    {
        get { return this.gsmModel; }
        set { this.gsmModel = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public decimal? Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }
}
