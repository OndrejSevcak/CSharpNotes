using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.Strings
{
    public static class StreamsReadersWriters
    {
        //Streams are by their nature binary - they read and write bytes

        //System.IO.TextReader - stream for reading text, abstract class
        //System.IO.TextWriter - stream for writing text

        //System.IO.StreamReader - for existing streams
        //System.IO.StreamWriter

        public static void WriteTextToFileUsingStream(string textContext)
        {
            string path = @"C:\Users\ondre\OneDrive\Plocha\Temp\FilesFromCSharp";

            System.IO.StreamWriter writer = new StreamWriter(path);
            writer.Write(textContext);
        }

    }
}
