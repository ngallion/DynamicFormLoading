
namespace DynamicFormLoading
{
    public interface IFormObject
    {
        int NumberOfProperties { get; set; }
        ReflectedObject GetProperties();
    }
}
