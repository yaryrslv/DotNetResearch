using System;
using BenchmarkDotNet.Attributes;
using Data;

namespace SpanMemory;

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
    public Span<Struct8> Struct8WithSpan()
    {
        Span<Struct8> span = new Struct8[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct8 test = new(A, B);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<Struct48> Struct48WithSpan()
    {
        Span<Struct48> span = new Struct48[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct48 test = new(A, B, _sampleGuid, _sampleGuid);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<Struct80> Struct80WithSpan()
    {
        Span<Struct80> span = new Struct80[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<Struct144> Struct144WithSpan()
    {
        Span<Struct144> span = new Struct144[Count];
        for (var i = 0; i < Count; i++)
        {
            Struct144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            span[i] = test;
        }
        
        return span;
    }
    #endregion

    #region Class
    [Benchmark]
    public Span<Class8> Class8WithSpan()
    {
        Span<Class8> span = new Class8[Count];
        for (var i = 0; i < Count; i++)
        {
            Class8 test = new(A, B);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<Class48> Class48WithSpan()
    {
        Span<Class48> span = new Class48[Count];
        for (var i = 0; i < Count; i++)
        {
            Class48 test = new(A, B, _sampleGuid, _sampleGuid);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<Class80> Class80WithSpan()
    {
        Span<Class80> span = new Class80[Count];
        for (var i = 0; i < Count; i++)
        {
            Class80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<Class144> Class144WithSpan()
    {
        Span<Class144> span = new Class144[Count];
        for (var i = 0; i < Count; i++)
        {
            Class144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            span[i] = test;
        }
        
        return span;
    }
    #endregion
}