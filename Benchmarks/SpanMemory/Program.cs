// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Data;

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance).
    AddExporter(RPlotExporter.Default, CsvExporter.Default);

BenchmarkRunner.Run<Benchmark>(config);

[MemoryDiagnoser]
public class Benchmark
{
    private readonly string _sampleString = new('a', 18);
    private const int A = 4444;
    private const int B = 8888;

    private const int Count = 1000000;

    #region Struct
    [Benchmark]
    public Span<SmallStruct> SmallStructWithSpan()
    {
        Span<SmallStruct> span = new SmallStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallStruct test = new(A, B);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<MediumStruct> MediumStructWithSpan()
    {
        Span<MediumStruct> span = new MediumStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumStruct test = new(A, B, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeStruct> LargeStructWithSpan()
    {
        Span<LargeStruct> span = new LargeStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<VeryLargeStruct> VeryLargeStructsWithSpan()
    {
        Span<VeryLargeStruct> span = new VeryLargeStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion

    #region Class
    [Benchmark]
    public Span<SmallClass> SmallClassWithSpan()
    {
        Span<SmallClass> span = new SmallClass[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallClass test = new(A, B);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumClass> MediumClassWithSpan()
    {
        Span<MediumClass> span = new MediumClass[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumClass test = new(A, B, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<LargeClass> LargeClassWithSpan()
    {
        Span<LargeClass> span = new LargeClass[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeClass> VeryLargeClassWithSpan()
    {
        Span<VeryLargeClass> span = new VeryLargeClass[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion
}



