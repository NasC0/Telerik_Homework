using System;

public class GSM
{
    Battery battery = new Battery();
    Display display = new Display();

    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public decimal Price
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
