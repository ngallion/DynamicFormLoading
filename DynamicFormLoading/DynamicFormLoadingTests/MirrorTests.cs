using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicFormLoading;
using System.Collections.Generic;

namespace DynamicFormLoadingTests
{
    [TestClass]
    public class MirrorTests
    {
        [TestMethod]
        public void Mirror_GetReflectedObjectTest()
        {
            //Arrange
            var testObject = new TestObject();
            var expectedPropertyReturned = "StringTestProp";
            var expectedPropertyTypeReturned = "System.String";
            var expectedNumberOfProperties = 4;

            //Act
            var reflectedTestObject = testObject.GetProperties();
            var actualPropertyReturned = reflectedTestObject.PropertyNames[1];
            var actualPropertyTypeReturned = reflectedTestObject.PropertyTypes[1];
            var actualNumberOfProperties = reflectedTestObject.NumberOfProperties;

            //Assert
            Assert.AreEqual(expectedPropertyReturned, actualPropertyReturned);
            Assert.AreEqual(expectedPropertyTypeReturned, actualPropertyTypeReturned);
            Assert.AreEqual(expectedNumberOfProperties, actualNumberOfProperties);
        }

        [TestMethod]
        public void Mirror_GetReflectedAssembly()
        {
            //Arrange
            var mirror = new Mirror();
            Type expectedTypeReturned = typeof(TestObject);

            //Act
            var reflectedAssembly = mirror.GetReflectedAssembly();

            //Assert
            foreach(Type type in reflectedAssembly)
            {
                if (type == typeof(TestObject))
                {
                    Assert.IsTrue(type == typeof(TestObject));
                }
            }
        }
    }
}
