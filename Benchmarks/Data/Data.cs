using System;

namespace Data;

//8 bytes
public record struct Struct8(int A, int B);
//48 bytes
public record struct Struct48(int A, int B, Guid X, Guid Y);
//80 bytes
public record struct Struct80(int A, int B, Guid X, Guid Y, Guid Z, Guid W);
//144 bytes
public record struct Struct144(int A, int B, Guid X, Guid Y, Guid Z, Guid W, Guid A1, Guid B1, Guid X1, Guid Y1, Guid Z1, Guid W1);

//8 bytes
public class Class8
{
    public Class8 (int a, int b)
    {
        A = a;
        B = b;
    }
    public int A { get; set;}
    public int B { get; set;}
}

//48 bytes
public class Class48
{
    public Class48 (int a, int b, Guid x, Guid y)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
    }
    public int A { get; set;}
    public int B { get; set;}
    public Guid X { get; set;}
    public Guid Y { get; set;}
}

//80 bytes
public class Class80
{
    public Class80 (int a, int b, Guid x, Guid y, Guid z, Guid w)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
        Z = z;
        W = w;
    }
    public int A { get; set;}
    public int B { get; set;}
    public Guid X { get; set;}
    public Guid Y { get; set;}
    public Guid Z { get; set;}
    public Guid W { get; set;}
}
//144 bytes
public class Class144
{
    public Class144 (int a, int b, Guid x, Guid y, Guid z, Guid w, Guid a1, Guid b1, Guid x1, Guid y1, Guid z1, Guid w1)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
        Z = z;
        W = w;
        A1 = a1;
        B1 = b1;
        X1 = x1;
        Y1 = y1;
        Z1 = z1;
        W1 = w1;
    }
    public int A { get; set;}
    public int B { get; set;}
    public Guid X { get; set;}
    public Guid Y { get; set;}
    public Guid Z { get; set;}
    public Guid W { get; set;}
    public Guid A1 { get; set;}
    public Guid B1 { get; set;}
    public Guid X1 { get; set;}
    public Guid Y1 { get; set;}
    public Guid Z1 { get; set;}
    public Guid W1 { get; set;}
}