public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var stream = new FileStream("myfile.txt", FileMode.Open))
        {
            // ... some code that uses the stream ...
        }

        // The stream is disposed here, but we try to access it again
        int byteRead = stream.ReadByte(); // This will throw an ObjectDisposedException
    }
}