
namespace DynamicFormLoading
{
    public class Product: IFormObject
    {
        public Product()
        { }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int InventoryCount { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }

        //  Final property is not included on form,
        //  leave as numberofprop property
        public int NumberOfProperties { get; set; }

        public ReflectedObject GetProperties()
        {
            var newMirror = new Mirror();
            return newMirror.GetReflectedObject(this);
        }

        public override string ToString()
        {
            return "Product";
        }
    }
}
