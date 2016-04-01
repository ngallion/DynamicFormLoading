using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace DynamicFormLoading
{
    public class Mirror
    {
        public Mirror()
        { }

        public ReflectedObject GetReflectedObject(Object currentObject)
        {
            var propertyTypes = new List<string>();
            var propertyNames = new List<string>();
            int numberOfProperties = 0;
            Type objectType = currentObject.GetType();
            foreach (PropertyInfo propertyInfo in objectType.GetProperties())
            {
                string _type = propertyInfo.PropertyType.ToString();
                string name = propertyInfo.Name;
                propertyTypes.Add(_type);
                propertyNames.Add(name);
                numberOfProperties++;
            }
            var reflectedObject = new ReflectedObject(propertyTypes, propertyNames, numberOfProperties - 1);
            return reflectedObject;
        }
        
        public List<Type> GetReflectedAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var results = from type in assembly.GetTypes()
                          where typeof(IFormObject).IsAssignableFrom(type)
                          select type;
            return results.ToList();
        }
    }
}
