public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned a value can lead to unexpected behavior or exceptions.
        int value = this.MyProperty; // Potential problem here!
        // ...rest of the method
    }
}