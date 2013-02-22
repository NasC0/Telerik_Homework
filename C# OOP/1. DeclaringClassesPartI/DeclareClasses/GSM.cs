using System;
using System.Text;
using System.Collections.Generic;

namespace GSMType.Common
{
    public class GSM
    {
        Battery Batter = new Battery();
        Display Display = new Display();

        private string gsmModel;
        private string manufacturer;
        private decimal? price;
        private string owner;
        static private GSM iPhone4S = new GSM("iPhone4S", "Apple", 899.99m, null, new Battery(), new Display(3.5, 16000000));
        private List<Call> callHistory = new List<Call>();

        public GSM(string gsmModel, string manufacturer)
            : this(gsmModel, manufacturer, null, null, null, null)
        {

        }

        public GSM(string gsmModel, string manufacturer, decimal? price)
            : this(gsmModel, manufacturer, price, null, null, null)
        {

        }

        public GSM(string gsmModel, string manufacturer, decimal? price, string owner)
            : this(gsmModel, manufacturer, price, owner, null, null)
        {

        }

        public GSM(string gsmModel, string manufacturer, decimal? price, string owner, Battery battery)
            : this(gsmModel, manufacturer, price, owner, battery, null)
        {

        }

        public GSM(string gsmModel, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            if (gsmModel.Length < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.gsmModel = gsmModel;
            }

            if (manufacturer.Length < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.manufacturer = manufacturer;
            }

            if (price <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.price = price;
            }

            this.owner = owner;
            this.Batter = battery;
            this.Display = display;
        }

        public void AddCall(long phoneNumber, int duration)
        {
            this.callHistory.Add(new Call(phoneNumber, duration));
        }

        public void RemoveCall(long phoneNumber)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].PhoneNumber == phoneNumber)
                {
                    this.callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CallsPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0m;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                decimal minutes = this.callHistory[i].Duration / 60.0m;
                totalPrice += minutes * pricePerMinute;
            }
            totalPrice = Math.Round(totalPrice, 2);
            return totalPrice;
        }

        public void PrintCalls()
        {
            foreach (Call calls in callHistory)
            {
                Console.WriteLine(calls.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (gsmModel != null)
                sb.AppendLine(gsmModel);
            if (manufacturer != null)
                sb.AppendLine(manufacturer);
            if (price != null)
                sb.AppendLine(price.ToString());
            if (owner != null)
                sb.AppendLine(owner);
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public string Model
        {
            get { return this.gsmModel; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.gsmModel = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        static public GSM IPhone
        {
            get { return iPhone4S; }
        }



    }
}

