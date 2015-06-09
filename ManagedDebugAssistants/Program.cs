using System.IO;

namespace ManagedDebugAssistants
{
    // Run second time with StreamWriterBufferedDataLost MDA enabled
    class Program
    {
        static void Main(string[] args)
        {
            var stream = File.Create("file.txt");

            var writer = new StreamWriter(stream);

            writer.Write("This is some text");

            stream.Close();

            System.Diagnostics.Process.Start("file.txt");
        }
    }
}
