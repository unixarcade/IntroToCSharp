using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class Tokens : IEnumerable
{

    private string[] elements;

    Tokens(string source, char[] delimiters)
    {
        // parse string to tokens
        elements = source.Split(delimiters);
    }

    // interface implementation
    public IEnumerator GetEnumerator()
    {
        return new TokenEnumerator(this);
    }

}

// inner class implements

private class TokenEnumerator: IEnumerator
{
    private int position = -1;
    private Tokens t;


    public TokenEnumerator(Tokens t)
    {
        this.t = t;
    }
}

// declare movenext
public bool MoveNext()
{
if (position < t.elements.Length -1)
{
position++;
return true;
}
else{
return false;
}
}

// Declare rest method
public void Reset()
{
position = -1;
}

// Declare current property
public object Current
{
get 
{
return t.elements[position];
}
}
}

// test tokens

static void Main()
{
// testing tokens
Tokens f = new Tokens("This is a well-done program.", new char[]{' ', '-'});
foreach (string item in f)
{
Console.WriteLine(item);
}
}
}