using System;

namespace Version
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;
        private string fullVersion;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
            this.fullVersion = major.ToString() + "." + minor.ToString();
        }

        public int Major
        {
            get { return this.major; }
        }

        public int Minor
        {
            get { return this.minor; }
        }

        public string FullVersion
        {
            get { return this.fullVersion; }
        }
    }
}
