﻿namespace Data;

public record struct SmallStruct(int A, int B);
public record struct MediumStruct(int A, int B, string X, string Y);
public record struct LargeStruct(int A, int B, string X, string Y, string Z, string W);
public record struct VeryLargeStruct(int A, int B, string X, string Y, string Z, string W, string A1, string B1, string X1, string Y1, string Z1, string W1);


public struct SmallRecordStruct
{
    public int A;
    public int B;

    public SmallRecordStruct(int a, int b)
    {
        A = a;
        B = b;
    }
}

public struct MediumRecordStruct
{
    public int A;
    public int B;
    public string X;
    public string Y;
    
    public MediumRecordStruct(int a, int b, string x, string y)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
    }
}

public struct LargeRecordStruct
{
    public int A;
    public int B;
    public string X;
    public string Y;
    public string Z;
    public string W;
    
    public LargeRecordStruct(int a, int b, string x, string y, string z, string w)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
        Z = z;
        W = w;
    }
}

public struct VeryLargeRecordStruct
{
    public int A;
    public int B;
    public string X;
    public string Y;
    public string Z;
    public string W;
    public string A1;
    public string B1;
    public string X1;
    public string Y1;
    public string Z1;
    public string W1;
    
    public VeryLargeRecordStruct(int a, int b, string x, string y, string z, string w, string a1, string b1, string x1, string y1, string z1, string w1)
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
}

public class SmallClass
{
    public SmallClass (int a, int b)
    {
        A = a;
        B = b;
    }
    public int A { get; set;}
    public int B { get; set;}
}

public class MediumClass
{
    public MediumClass (int a, int b, string x, string y)
    {
        A = a;
        B = b;
        X = x;
        Y = y;
    }
    public int A { get; set;}
    public int B { get; set;}
    public string X { get; set;}
    public string Y { get; set;}
}
public class LargeClass
{
    public LargeClass (int a, int b, string x, string y, string z, string w)
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
    public string X { get; set;}
    public string Y { get; set;}
    public string Z { get; set;}
    public string W { get; set;}
}
public class VeryLargeClass
{
    public VeryLargeClass (int a, int b, string x, string y, string z, string w, string a1, string b1, string x1, string y1, string z1, string w1)
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
    public string X { get; set;}
    public string Y { get; set;}
    public string Z { get; set;}
    public string W { get; set;}
    public string A1 { get; set;}
    public string B1 { get; set;}
    public string X1 { get; set;}
    public string Y1 { get; set;}
    public string Z1 { get; set;}
    public string W1 { get; set;}
}


public record class SmallRecordClass(int A, int B);
public record class MediumRecordClass(int A, int B, string X, string Y);
public record class LargeRecordClass(int A, int B, string X, string Y, string Z, string W);
public record class VeryLargeRecordClass(int A, int B, string X, string Y, string Z, string W, string A1, string B1, string X1, string Y1, string Z1, string W1);