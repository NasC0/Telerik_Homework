using System;
using System.Text;

namespace Points
{
    public struct Point
    {
        private int xCoord;
        private int yCoord;
        private int zCoord;
        static private Point coordStart = new Point(0, 0, 0);

        public Point(int x, int y, int z)
        {
            this.xCoord = x;
            this.yCoord = y;
            this.zCoord = z;
        }

        public override string ToString()
        {
            StringBuilder stringHolder = new StringBuilder();
            stringHolder.AppendLine(this.xCoord.ToString());
            stringHolder.AppendLine(this.yCoord.ToString());
            stringHolder.AppendLine(this.zCoord.ToString());
            stringHolder.Remove(stringHolder.Length - 1, 1);
            return stringHolder.ToString();
        }

        public int XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }

        public int YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

        public int ZCoord
        {
            get { return this.zCoord; }
            set { this.zCoord = value; }
        }

        static public Point CoordStart
        {
            get { return coordStart; }
        }
    }
}
