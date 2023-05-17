// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Data;

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance);

BenchmarkRunner.Run<Benchmark>(config);

[MemoryDiagnoser]
public class Benchmark
{
    private string _sampleString = new('a', 18);
    private int _a = 4444;
    private int _b = 8888;

    private readonly int _count = 1000000;

    #region Struct
    [Benchmark]
    public Span<SmallStruct> SmallStructWithSpan()
    {
        Span<SmallStruct> span = new SmallStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallStruct test = new(_a, _b);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<MediumStruct> MediumStructWithSpan()
    {
        Span<MediumStruct> span = new MediumStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumStruct test = new(_a, _b, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeStruct> LargeStructWithSpan()
    {
        Span<LargeStruct> span = new LargeStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }

        return span;
    }

    [Benchmark]
    public Span<VeryLargeStruct> VeryLargeStructsWithSpan()
    {
        Span<VeryLargeStruct> span = new VeryLargeStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion

    #region RecordStruct
    [Benchmark]
    public Span<SmallRecordStruct> SmallRecordStructWithSpan()
    {
        Span<SmallRecordStruct> span = new SmallRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallRecordStruct test = new(_a, _b);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumRecordStruct> MediumRecordStructWithSpan()
    {
        Span<MediumRecordStruct> span = new MediumRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumRecordStruct test = new(_a, _b, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeRecordStruct> LargeRecordStructWithSpan()
    {
        Span<LargeRecordStruct> span = new LargeRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeRecordStruct> VeryLargeRecordStructsWithSpan()
    {
        Span<VeryLargeRecordStruct> span = new VeryLargeRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion

    #region Class
    [Benchmark]
    public Span<SmallClass> SmallClassWithSpan()
    {
        Span<SmallClass> span = new SmallClass[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallClass test = new(_a, _b);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumClass> MediumClassWithSpan()
    {
        Span<MediumClass> span = new MediumClass[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumClass test = new(_a, _b, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<LargeClass> LargeClassWithSpan()
    {
        Span<LargeClass> span = new LargeClass[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeClass> VeryLargeClassWithSpan()
    {
        Span<VeryLargeClass> span = new VeryLargeClass[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion
    
    #region RecordClass
    [Benchmark]
    public Span<SmallRecordClass> SmallRecordClassWithSpan()
    {
        Span<SmallRecordClass> span = new SmallRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallRecordClass test = new(_a, _b);
            span[i] = test;
        }
        
        return span;
    }

    [Benchmark]
    public Span<MediumRecordClass> MediumRecordClassWithSpan()
    {
        Span<MediumRecordClass> span = new MediumRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumRecordClass test = new(_a, _b, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<LargeRecordClass> LargeRecordClassWithSpan()
    {
        Span<LargeRecordClass> span = new LargeRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    
    [Benchmark]
    public Span<VeryLargeRecordClass> VeryLargeRecordClassWithSpan()
    {
        Span<VeryLargeRecordClass> span = new VeryLargeRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            span[i] = test;
        }
        
        return span;
    }
    #endregion
}



