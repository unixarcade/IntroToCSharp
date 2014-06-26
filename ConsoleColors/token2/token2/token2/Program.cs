using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tokens: IEnumerable
{
    private string[] elements;
    Tokens(string source, char[] delimiters)
    {
        elements = source.Split(delimiters);


    }
    public TokenEnumerator GetEnumerator()
    {
        return new TokenEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)new TokenEnumerator(this);
    }


}

public class TokenEnumerator: IEnumerator
{
    private int position = -1;
    private Tokens t;

    public TokenEnumerator(Tokens t)
    {
        this.t = t;
    }
    public bool MoveNext()
    {
        if (position < t.elements.Length - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }
}

public void Reset()
{
position = -1;
}

public string Current
{
get
{
return t.elements[position];
}
}

object IEnumerator.Current
{
get
{
return t.elements[position];
}
}
}

static void Main()
{
Tokens f = new Tokens("Hi Hi Hello Wow", new char[]{' ','-'});

foreach (string item in f)
{
Console.WriteLine(item);
}
}
}
