using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicFormLoading;

namespace DynamicFormLoadingTests
{
    public class TestObject: IFormObject
    {
        public TestObject()
        { }

        public int TestId { get; set; }
        public string StringTestProp { get; set; }
        public bool BoolTestProp { get; set; }
        public DateTime DateTimeTestProp { get; set; }

        public int NumberOfProperties { get; set; }

        public ReflectedObject GetProperties()
        {
            var mirror = new Mirror();
            return mirror.GetReflectedObject(this);
        }
    }
}
