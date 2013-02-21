using System;

namespace GSMType.Common
{
    public class Battery
    {
        private string model;
        private double? idleHours;
        private double? talkHours;
        private BatteryType? type;


        public Battery(BatteryType type)
            : this(null, null, null, type)
        {

        }

        public Battery(string model)
            : this(model, null, null, null)
        {

        }

        public Battery(string model, double? idleHours)
            : this(model, idleHours, null, null)
        {

        }

        public Battery(string model, double? idleHours, double? talkHours)
            : this(model, idleHours, talkHours, null)
        {

        }

        public Battery(string model, double? idleHours, double? talkHours, BatteryType? type)
        {
            this.model = model;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
            this.type = type;
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

        public BatteryType? Type
        {
            get { return this.type; }
        }

    }
}

