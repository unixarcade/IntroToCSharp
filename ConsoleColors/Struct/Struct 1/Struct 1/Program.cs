using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct SimpleStruct
{
    private int xval;
    public int x
    {
        get
        {
            return xval;
        }
        set
        {
            if (value < 100)
                xval = value;
        }
    }
}

public void DisplayX()
{
Console.WriteLine("The store value is: {0}", xval );
}

class TestClass
{
    public static void Main()
    {
        SimpleStruct ss = new SimpleStruct();
        ss.x =5;
        ss.DisplayX();

    }
}