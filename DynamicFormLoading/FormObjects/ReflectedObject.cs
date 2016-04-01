using System;
using System.Collections.Generic;

namespace DynamicFormLoading
{
    public class ReflectedObject
    {
        public ReflectedObject()
        { }

        public ReflectedObject(List<String> propertyTypes, List<String> propertyNames, int numberOfProperties)
        {
            this.propertyTypes = propertyTypes;
            this.propertyNames = propertyNames;
            this.numberOfProperties = numberOfProperties;
        }

        private List<String> propertyTypes;

        public List<String> PropertyTypes
        {
            get { return propertyTypes; }
            set { propertyTypes = value; }
        }

        private List<String> propertyNames;

        public List<String> PropertyNames
        {
            get { return propertyNames; }
            set { propertyNames = value; }
        }


        private int numberOfProperties;

        public int NumberOfProperties
        {
            get { return numberOfProperties; }
            set { numberOfProperties = value; }
        }


    }
}
