// See https://aka.ms/new-console-template for more information

using System.Buffers;
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

    #region ArrayPools
    private ArrayPool<SmallStruct> _smallStructArrayPool = ArrayPool<SmallStruct>.Shared;
    private ArrayPool<MediumStruct> _mediumStructArrayPool = ArrayPool<MediumStruct>.Shared;
    private ArrayPool<LargeStruct> _largeStructArrayPool = ArrayPool<LargeStruct>.Shared;
    private ArrayPool<VeryLargeStruct> _veryLargeStructArrayPool = ArrayPool<VeryLargeStruct>.Shared;
    
    private ArrayPool<SmallRecordStruct> _smallRecordStructArrayPool = ArrayPool<SmallRecordStruct>.Shared;
    private ArrayPool<MediumRecordStruct> _mediumRecordStructArrayPool = ArrayPool<MediumRecordStruct>.Shared;
    private ArrayPool<LargeRecordStruct> _largeRecordStructArrayPool = ArrayPool<LargeRecordStruct>.Shared;
    private ArrayPool<VeryLargeRecordStruct> _veryLargeRecordStructArrayPool = ArrayPool<VeryLargeRecordStruct>.Shared;
    
    private ArrayPool<SmallClass> _smallClassArrayPool = ArrayPool<SmallClass>.Shared;
    private ArrayPool<MediumClass> _mediumClassArrayPool = ArrayPool<MediumClass>.Shared;
    private ArrayPool<LargeClass> _largeClassArrayPool = ArrayPool<LargeClass>.Shared;
    private ArrayPool<VeryLargeClass> _veryLargeClassArrayPool = ArrayPool<VeryLargeClass>.Shared;
    
    private ArrayPool<SmallRecordClass> _smallRecordClassArrayPool = ArrayPool<SmallRecordClass>.Shared;
    private ArrayPool<MediumRecordClass> _mediumRecordClassArrayPool = ArrayPool<MediumRecordClass>.Shared;
    private ArrayPool<LargeRecordClass> _largeRecordClassArrayPool = ArrayPool<LargeRecordClass>.Shared;
    private ArrayPool<VeryLargeRecordClass> _veryLargeRecordClassArrayPool = ArrayPool<VeryLargeRecordClass>.Shared;
    #endregion

    #region Struct
    [Benchmark]
    public SmallStruct[] SmallStructWithArrayPool()
    {
        var rentArray = _smallStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            SmallStruct test = new(_a, _b);
            rentArray[i] = test;
        }

        return rentArray;
    }

    [Benchmark]
    public MediumStruct[] MediumStructWithArrayPool()
    {
        var rentArray = _mediumStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            MediumStruct test = new(_a, _b, _sampleString, _sampleString);
            rentArray[i] = test;
        }
       
        return rentArray;
    }
    
    [Benchmark]
    public LargeStruct[] LargeStructWithArrayPool()
    {
        var rentArray = _largeStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            LargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public VeryLargeStruct[] VeryLargeStructsWithArrayPool()
    {
        var rentArray = _veryLargeStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            VeryLargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion

    #region RecordStruct
    [Benchmark]
    public SmallRecordStruct[] SmallRecordStructWithArrayPool()
    {
        var rentArray = _smallRecordStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            SmallRecordStruct test = new(_a, _b);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumRecordStruct[] MediumRecordStructWithArrayPool()
    {
        var rentArray = _mediumRecordStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            MediumRecordStruct test = new(_a, _b, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public LargeRecordStruct[] LargeRecordStructWithArrayPool()
    {
        var rentArray = _largeRecordStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            LargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeRecordStruct[] VeryLargeRecordStructsWithArrayPool()
    {
        var rentArray = _veryLargeRecordStructArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion

    #region Class
    [Benchmark]
    public SmallClass[] SmallClassWithArrayPool()
    {
        var rentArray = _smallClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            SmallClass test = new(_a, _b);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumClass[] MediumClassWithArrayPool()
    {
        var rentArray = _mediumClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            MediumClass test = new(_a, _b, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public LargeClass[] LargeClassWithArrayPool()
    {
        var rentArray = _largeClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            LargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }

        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeClass[] VeryLargeClassWithArrayPool()
    {
        var rentArray = _veryLargeClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            VeryLargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion
    
    #region RecordClass
    [Benchmark]
    public SmallRecordClass[] SmallRecordClassWithArrayPool()
    {
        var rentArray = _smallRecordClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            SmallRecordClass test = new(_a, _b);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumRecordClass[] MediumRecordClassWithArrayPool()
    {
        var rentArray = _mediumRecordClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            MediumRecordClass test = new(_a, _b, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public LargeRecordClass[] LargeRecordClassWithArrayPool()
    {
        var rentArray = _largeRecordClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            LargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeRecordClass[] VeryLargeRecordClassWithArrayPool()
    {
        var rentArray = _veryLargeRecordClassArrayPool.Rent(_count);
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }

        return rentArray;
    }
    #endregion
}



