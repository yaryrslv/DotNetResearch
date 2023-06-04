// See https://aka.ms/new-console-template for more information

using System.Buffers;
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
    .AddColumnProvider(DefaultColumnProviders.Instance)
    .AddExporter(RPlotExporter.Default, CsvExporter.Default);

BenchmarkRunner.Run<Benchmark>(config);

[MemoryDiagnoser]
public class Benchmark
{
    private readonly Guid _sampleGuid = Guid.NewGuid();
    private const int A = Int32.MaxValue;
    private const int B = Int32.MaxValue;

    [Params(100, 1000, 10000, 100000, 1000000)]
    public int Count { get; set; }

    #region ArrayPools
    private readonly ArrayPool<Struct8> _struct8ArrayPool = ArrayPool<Struct8>.Shared;
    private readonly ArrayPool<Struct48> _struct48ArrayPool = ArrayPool<Struct48>.Shared;
    private readonly ArrayPool<Struct80> _struct80ArrayPool = ArrayPool<Struct80>.Shared;
    private readonly ArrayPool<Struct144> _struct144ArrayPool = ArrayPool<Struct144>.Shared;

    private readonly ArrayPool<Class8> _class8ArrayPool = ArrayPool<Class8>.Shared;
    private readonly ArrayPool<Class48> _class48ArrayPool = ArrayPool<Class48>.Shared;
    private readonly ArrayPool<Class80> _class80ArrayPool = ArrayPool<Class80>.Shared;
    private readonly ArrayPool<Class144> _class144ArrayPool = ArrayPool<Class144>.Shared;
    
    #endregion

    #region Struct
    [Benchmark]
    public Struct8[] Struct8WithArrayPool()
    {
        var rentArray = _struct8ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Struct8 test = new(A, B);
            rentArray[i] = test;
        }

        return rentArray;
    }

    [Benchmark]
    public Struct48[] Struct48WithArrayPool()
    {
        var rentArray = _struct48ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Struct48 test = new(A, B, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }
       
        return rentArray;
    }
    
    [Benchmark]
    public Struct80[] Struct80WithArrayPool()
    {
        var rentArray = _struct80ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Struct80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public Struct144[] Struct144WithArrayPool()
    {
        var rentArray = _struct144ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Struct144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion

    #region Class
    [Benchmark]
    public Class8[] Class8WithArrayPool()
    {
        var rentArray = _class8ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Class8 test = new(A, B);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public Class48[] Class48WithArrayPool()
    {
        var rentArray = _class48ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Class48 test = new(A, B, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public Class80[] Class80WithArrayPool()
    {
        var rentArray = _class80ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Class80 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }

        return rentArray;
    }
    
    [Benchmark]
    public Class144[] Class144WithArrayPool()
    {
        var rentArray = _class144ArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            Class144 test = new(A, B, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid, _sampleGuid);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion
}



