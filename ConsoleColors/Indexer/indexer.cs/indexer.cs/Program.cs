using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FileByteArray
{
    Stream stream; // holds underlying stream

    //Create new filebytearray
    public FileByteArray(string FileName)
    {
        stream = new FileStream(FileName, FileMode.Open);
    }

    // close stream
    public void Close()
    {
        stream.Close();
        stream = null;
    }

    public byte this[long index]
    {
        get
        {
            byte[] buffer = new byte[1];
            stream.Seek(index, SeekOrigin.Begin);
            stream.Read(buffer, 0, 1);
            return buffer[0];
        }

        // Write one byte at offset index and return it
        set
        {
            byte[] buffer = new byte[1] { value };
            stream.Seek(index, SeekOrigin.Begin);
            stream.Write(buffer, 0, 1);
        }
    }

}

    class Reverse
    {
        static void Main(string[] args)
        {
        }
    }

