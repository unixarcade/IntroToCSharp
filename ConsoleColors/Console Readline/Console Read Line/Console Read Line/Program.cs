using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsertTabs
{
    private const int tabSize = 4;
    private const string usageText = "Usage: INSERTTABS inputfile.txt out";
    public static int Main(string[] args) {
        StreamWriter writer = null;
        if (args.Length < 2)
        {
            Console.WriteLine(usageText);
            return 1;
        } try {
            // attempt to open output file
            writer = new StreamWriter(args[1]);
            // redirect standard output
            Console.SetOut(writer);
            // Redirect standard input
            Console.SetIn(new StreamReader(args[0]));
        }
        catch (IOException)
        {
            TextWriter errorWriter = Console.Error;
            errorWriter.WriteLine(e.Message);
            errorWriter.WriteLine(usageText);
            return 1;
        }
        string line;
        while((line = Console.ReadLine()) !null) {
            string newLine = line.Replace(("").PadRight(tabSize, ' '), "\t");
            Console.WriteLine(newLine);
        }
        writer.Close();
        //recover standad output stream
        // completion message can be displayed
        StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
        Console.WriteLine("INSERTTABS has comppleted the processing of {0}.", args[0]);
    }
}