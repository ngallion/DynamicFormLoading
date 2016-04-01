using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormLoading
{
    public class Vendor: IFormObject
    {
        public Vendor()
        { }

        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ItemsInInventory { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }




        public int NumberOfProperties { get; set; }

        public ReflectedObject GetProperties()
        {
            var mirror = new Mirror();
            return mirror.GetReflectedObject(this);
        }

        public override string ToString()
        {
            return "Vendor";
        }
    }
}
