using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormLoading
{
    public class Location: IFormObject
    {
        public Location()
        { }

        public int LocationId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Open { get; set; }
        public DateTime DateOpened { get; set; }

        public int NumberOfProperties { get; set; }

        public ReflectedObject GetProperties()
        {
            var mirror = new Mirror();
            return mirror.GetReflectedObject(this);
        }

        public override string ToString()
        {
            return "Location";
        }
    }
}
