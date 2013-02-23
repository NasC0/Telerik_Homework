using System;
using System.Collections.Generic;
using System.Text;

namespace Points
{
    public class Path
    {
        private List<Point> sequence = new List<Point>();

        public void AddPoint(Point point)
        {
            this.sequence.Add(point);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Point point in sequence)
            {
                sb.Append(point.XCoord.ToString());
                sb.Append(" ");
                sb.Append(point.YCoord.ToString());
                sb.Append(" ");
                sb.Append(point.ZCoord.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public List<Point> Sequence
        {
            get { return this.sequence; }
        }
    }
}
