using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School
    {
        private List<Classes> classes;

        public School() : this(null)
        {
            
        }

        public School(List<Classes> classes)
        {
            this.classes = classes;
        }

        public void AddClass(Classes classToAdd)
        {
            this.classes.Add(classToAdd);
        }

        public void AddClassesList(List<Classes> classes)
        {
            this.classes.AddRange(classes);
        }

        public void RemoveClass(Classes classToRemove)
        {
            this.classes.Remove(classToRemove);
        }

        public void ClearClasses()
        {
            this.classes.Clear();
        }

        public Classes this[int index]
        {
            get
            {
                if (index >= 0 && index < this.classes.Count)
                {
                    return this.classes[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
