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

    #region RecordStruct
    [Benchmark]
    public Span<SmallRecordStruct> SmallRecordStructWithSpan()
    {
        Span<SmallRecordStruct> span = new SmallRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallRecordStruct test = new(A, B);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumRecordStruct> MediumRecordStructWithSpan()
    {
        Span<MediumRecordStruct> span = new MediumRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumRecordStruct test = new(A, B, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeRecordStruct> LargeRecordStructWithSpan()
    {
        Span<LargeRecordStruct> span = new LargeRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeRecordStruct> VeryLargeRecordStructsWithSpan()
    {
        Span<VeryLargeRecordStruct> span = new VeryLargeRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
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
    
    #region RecordClass
    [Benchmark]
    public Span<SmallRecordClass> SmallRecordClassWithSpan()
    {
        Span<SmallRecordClass> span = new SmallRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallRecordClass test = new(A, B);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumRecordClass> MediumRecordClassWithSpan()
    {
        Span<MediumRecordClass> span = new MediumRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumRecordClass test = new(A, B, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeRecordClass> LargeRecordClassWithSpan()
    {
        Span<LargeRecordClass> span = new LargeRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeRecordClass> VeryLargeRecordClassWithSpan()
    {
        Span<VeryLargeRecordClass> span = new VeryLargeRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion
}



