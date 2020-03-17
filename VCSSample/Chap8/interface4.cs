using System;

// インターフェイス1
interface IBaseInterface1
{
    void Method1( int a );
}

// インターフェイス2
interface IBaseInterface2
{
    void Method2(string s);
}

class SampleClass: IBaseInterface1, IBaseInterface2
{
    public void Method1( int a )
    {
        Console.WriteLine(a);
    }

    public void Method2(string s)
    {
        Console.WriteLine(s);
    }
}
