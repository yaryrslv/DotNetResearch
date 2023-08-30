using BenchmarkDotNet.Attributes;
using Data;

namespace ClassAndStruct;

[MemoryDiagnoser]
public class WriteBenchmark
{
    private readonly Guid _sampleGuid = Guid.NewGuid();
    private const int A = int.MaxValue;
    private const int B = int.MaxValue;

    [Params(100, 1000, 10000, 100000, 1000000)]
    public int Count { get; set; }


    #region Struct
    [Benchmark]
    public Struct8[] Struct8()
    {
        var struct8Array = new Struct8[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct8 test = new(A, B);
            struct8Array[i] = test;
        }

        return struct8Array;
    }

    [Benchmark]
    public Struct48[] Struct48()
    {
        var struct48Array = new Struct48[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct48 test = new(A, B, _sampleGuid, _sampleGuid);
            struct48Array[i] = test;
        }
        
        return struct48Array;
    }
    
    [Benchmark]
    public Struct80[] Struct80()
    {
        var struct80Array = new Struct80[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            struct80Array[i] = test;
        }
        
        return struct80Array;
    }

    [Benchmark]
    public Struct144[] Struct144S()
    {
        var struct144Array = new Struct144[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            struct144Array[i] = test;
        }
        
        return struct144Array;
    }
    #endregion
    
    #region Class
    [Benchmark]
    public Class8[] Class8()
    {
        var class8Array = new Class8[Count];
        for (var i = 0; i < Count; i++)
        {
            Class8 test = new(A, B); 
            class8Array[i] = test;
        }
        
        return class8Array;
    }

    [Benchmark]
    public Class48[] Class48()
    {
        var class48Array = new Class48[Count];
        for (var i = 0; i < Count; i++)
        {
            Class48 test = new(A, B, _sampleGuid, _sampleGuid);
            class48Array[i] = test;
        }
        
        return class48Array;
    }

    [Benchmark]
    public Class80[] Class80()
    {
        var class80Array = new Class80[Count];
        for (var i = 0; i < Count; i++)
        {
            Class80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            class80Array[i] = test;
        }
        
        return class80Array;
    }
    
    [Benchmark]
    public Class144[] Class144()
    {
        var class144Array = new Class144[Count];
        for (var i = 0; i < Count; i++)
        {
            Class144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            class144Array[i] = test;
        }
        
        return class144Array;
    }
    #endregion
}