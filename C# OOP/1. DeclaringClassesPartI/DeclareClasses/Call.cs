using System;
using System.Globalization;
using System.Text;

namespace GSMType.Common
{
    public class Call
    {
        private DateTime time;
        private long phoneNumber;
        private int duration;

        public Call(long phoneNumber, int duration)
        {
            this.time = DateTime.Now;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.time.ToString());
            sb.AppendLine(this.phoneNumber.ToString());
            sb.AppendLine(this.duration.ToString());
            return sb.ToString();
        }

        public DateTime Time
        {
            get { return this.time; }
        }

        public long PhoneNumber
        {
            get { return this.phoneNumber; }
        }

        public int Duration
        {
            get { return this.duration; }
        }
    }
}
