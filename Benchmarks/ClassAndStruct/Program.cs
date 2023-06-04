// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Data;

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance)
    .AddExporter(RPlotExporter.Default, CsvExporter.Default, MarkdownExporter.GitHub, HtmlExporter.Default);

BenchmarkRunner.Run<Benchmark>(config);

[MemoryDiagnoser]
public class Benchmark
{
    private readonly Guid _sampleGuid = Guid.NewGuid();
    private const int A = Int32.MaxValue;
    private const int B = Int32.MaxValue;

    [Params(1, 10)]
    public int Count { get; set; }


    #region Struct
    [Benchmark]
    public Struct8[] Struct8()
    {
        var struct8Array = new Struct8[Count];
        for (int i = 0; i < Count; i++)
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
        for (int i = 0; i < Count; i++)
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
        for (int i = 0; i < Count; i++)
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
        for (int i = 0; i < Count; i++)
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
        var Class8Array = new Class8[Count];
        for (int i = 0; i < Count; i++)
        {
            Class8 test = new(A, B); 
            Class8Array[i] = test;
        }
        
        return Class8Array;
    }

    [Benchmark]
    public Class48[] Class48()
    {
        var Class48Array = new Class48[Count];
        for (int i = 0; i < Count; i++)
        {
            Class48 test = new(A, B, _sampleGuid, _sampleGuid);
            Class48Array[i] = test;
        }
        
        return Class48Array;
    }

    [Benchmark]
    public Class80[] Class80()
    {
        var Class80Array = new Class80[Count];
        for (int i = 0; i < Count; i++)
        {
            Class80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            Class80Array[i] = test;
        }
        
        return Class80Array;
    }
    
    [Benchmark]
    public Class144[] Class144()
    {
        var Class144Array = new Class144[Count];
        for (int i = 0; i < Count; i++)
        {
            Class144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            Class144Array[i] = test;
        }
        
        return Class144Array;
    }
    #endregion
}