using System;
using System.Collections.Generic;
using System.Reflection;

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
            var propertyTypes = new List<string>();
            var propertyNames = new List<string>();
            int numberOfProperties = 0;
            Type type = this.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                string _type = propertyInfo.PropertyType.ToString();
                string name = propertyInfo.Name;
                propertyTypes.Add(_type);
                propertyNames.Add(name);
                numberOfProperties++;
            }
            NumberOfProperties = numberOfProperties - 1;
            var reflectedObject = new ReflectedObject(propertyTypes, propertyNames, NumberOfProperties);
            return reflectedObject;
        }
    }
}
