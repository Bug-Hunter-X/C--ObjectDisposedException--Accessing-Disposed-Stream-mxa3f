public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Correct way to handle the stream
        using (var stream = new FileStream("myfile.txt", FileMode.Open))
        {
            // Access the stream within the using block
            while (stream.Position < stream.Length)
            {
                int byteRead = stream.ReadByte();
                //Process byteRead
            }
        }

        // The stream is automatically disposed here. No attempt to access it outside the using block.
    }
}