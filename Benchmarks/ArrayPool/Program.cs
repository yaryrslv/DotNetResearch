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
    private readonly string _sampleString = new('a', 18);
    private const int A = 4444;
    private const int B = 8888;

    private const int Count = 1000000;

    #region ArrayPools
    private readonly ArrayPool<SmallStruct> _smallStructArrayPool = ArrayPool<SmallStruct>.Shared;
    private readonly ArrayPool<MediumStruct> _mediumStructArrayPool = ArrayPool<MediumStruct>.Shared;
    private readonly ArrayPool<LargeStruct> _largeStructArrayPool = ArrayPool<LargeStruct>.Shared;
    private readonly ArrayPool<VeryLargeStruct> _veryLargeStructArrayPool = ArrayPool<VeryLargeStruct>.Shared;
    
    private readonly ArrayPool<SmallRecordStruct> _smallRecordStructArrayPool = ArrayPool<SmallRecordStruct>.Shared;
    private readonly ArrayPool<MediumRecordStruct> _mediumRecordStructArrayPool = ArrayPool<MediumRecordStruct>.Shared;
    private readonly ArrayPool<LargeRecordStruct> _largeRecordStructArrayPool = ArrayPool<LargeRecordStruct>.Shared;
    private readonly ArrayPool<VeryLargeRecordStruct> _veryLargeRecordStructArrayPool = ArrayPool<VeryLargeRecordStruct>.Shared;
    
    private readonly ArrayPool<SmallClass> _smallClassArrayPool = ArrayPool<SmallClass>.Shared;
    private readonly ArrayPool<MediumClass> _mediumClassArrayPool = ArrayPool<MediumClass>.Shared;
    private readonly ArrayPool<LargeClass> _largeClassArrayPool = ArrayPool<LargeClass>.Shared;
    private readonly ArrayPool<VeryLargeClass> _veryLargeClassArrayPool = ArrayPool<VeryLargeClass>.Shared;
    
    private readonly ArrayPool<SmallRecordClass> _smallRecordClassArrayPool = ArrayPool<SmallRecordClass>.Shared;
    private readonly ArrayPool<MediumRecordClass> _mediumRecordClassArrayPool = ArrayPool<MediumRecordClass>.Shared;
    private readonly ArrayPool<LargeRecordClass> _largeRecordClassArrayPool = ArrayPool<LargeRecordClass>.Shared;
    private readonly ArrayPool<VeryLargeRecordClass> _veryLargeRecordClassArrayPool = ArrayPool<VeryLargeRecordClass>.Shared;
    #endregion

    #region Struct
    [Benchmark]
    public SmallStruct[] SmallStructWithArrayPool()
    {
        var rentArray = _smallStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            SmallStruct test = new(A, B);
            rentArray[i] = test;
        }

        return rentArray;
    }

    [Benchmark]
    public MediumStruct[] MediumStructWithArrayPool()
    {
        var rentArray = _mediumStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            MediumStruct test = new(A, B, _sampleString, _sampleString);
            rentArray[i] = test;
        }
       
        return rentArray;
    }
    
    [Benchmark]
    public LargeStruct[] LargeStructWithArrayPool()
    {
        var rentArray = _largeStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            LargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public VeryLargeStruct[] VeryLargeStructsWithArrayPool()
    {
        var rentArray = _veryLargeStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            VeryLargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion

    #region RecordStruct
    [Benchmark]
    public SmallRecordStruct[] SmallRecordStructWithArrayPool()
    {
        var rentArray = _smallRecordStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            SmallRecordStruct test = new(A, B);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumRecordStruct[] MediumRecordStructWithArrayPool()
    {
        var rentArray = _mediumRecordStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            MediumRecordStruct test = new(A, B, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public LargeRecordStruct[] LargeRecordStructWithArrayPool()
    {
        var rentArray = _largeRecordStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            LargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeRecordStruct[] VeryLargeRecordStructsWithArrayPool()
    {
        var rentArray = _veryLargeRecordStructArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion

    #region Class
    [Benchmark]
    public SmallClass[] SmallClassWithArrayPool()
    {
        var rentArray = _smallClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            SmallClass test = new(A, B);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumClass[] MediumClassWithArrayPool()
    {
        var rentArray = _mediumClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            MediumClass test = new(A, B, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public LargeClass[] LargeClassWithArrayPool()
    {
        var rentArray = _largeClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            LargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }

        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeClass[] VeryLargeClassWithArrayPool()
    {
        var rentArray = _veryLargeClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            VeryLargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    #endregion
    
    #region RecordClass
    [Benchmark]
    public SmallRecordClass[] SmallRecordClassWithArrayPool()
    {
        var rentArray = _smallRecordClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            SmallRecordClass test = new(A, B);
            rentArray[i] = test;
        }
        
        return rentArray;
    }

    [Benchmark]
    public MediumRecordClass[] MediumRecordClassWithArrayPool()
    {
        var rentArray = _mediumRecordClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            MediumRecordClass test = new(A, B, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public LargeRecordClass[] LargeRecordClassWithArrayPool()
    {
        var rentArray = _largeRecordClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            LargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }
        
        return rentArray;
    }
    
    [Benchmark]
    public VeryLargeRecordClass[] VeryLargeRecordClassWithArrayPool()
    {
        var rentArray = _veryLargeRecordClassArrayPool.Rent(Count);
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            rentArray[i] = test;
        }

        return rentArray;
    }
    #endregion
}



