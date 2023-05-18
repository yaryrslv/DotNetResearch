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
    private readonly string _sampleString = new('a', 18);
    private const int A = 4444;
    private const int B = 8888;

    private const int Count = 1000;

    #region Struct
    [Benchmark]
    public SmallStruct[] SmallStruct()
    {
        var smallStructArray = new SmallStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallStruct test = new(A, B);
            smallStructArray[i] = test;
        }

        return smallStructArray;
    }

    [Benchmark]
    public MediumStruct[] MediumStruct()
    {
        var mediumStructArray = new MediumStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumStruct test = new(A, B, _sampleString, _sampleString);
            mediumStructArray[i] = test;
        }
        
        return mediumStructArray;
    }
    
    [Benchmark]
    public LargeStruct[] LargeStruct()
    {
        var largeStructArray = new LargeStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            largeStructArray[i] = test;
        }
        
        return largeStructArray;
    }

    [Benchmark]
    public VeryLargeStruct[] VeryLargeStructs()
    {
        var veryLargeStructArray = new VeryLargeStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeStructArray[i] = test;
        }
        
        return veryLargeStructArray;
    }
    #endregion

    #region RecordStruct
    [Benchmark]
    public SmallRecordStruct[] SmallRecordStruct()
    {
        var smallRecordStructArray = new SmallRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallRecordStruct test = new(A, B);
            smallRecordStructArray[i] = test;
        }
        
        return smallRecordStructArray;
    }

    [Benchmark]
    public MediumRecordStruct[] MediumRecordStruct()
    {
        var mediumRecordStructArray = new MediumRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumRecordStruct test = new(A, B, _sampleString, _sampleString);
            mediumRecordStructArray[i] = test;
        }
        
        return mediumRecordStructArray;
    }

    [Benchmark]
    public LargeRecordStruct[] LargeRecordStruct()
    {
        var largeRecordStructArray = new LargeRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            largeRecordStructArray[i] = test;
        }
        
        return largeRecordStructArray;
    }
    
    [Benchmark]
    public VeryLargeRecordStruct[] VeryLargeRecordStructs()
    {
        var veryLargeRecordStructList = new VeryLargeRecordStruct[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordStruct test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeRecordStructList[i] = test;
        }
        
        return veryLargeRecordStructList;
    }
    #endregion

    #region Class
    [Benchmark]
    public SmallClass[] SmallClass()
    {
        var smallClassArray = new SmallClass[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallClass test = new(A, B); 
            smallClassArray[i] = test;
        }
        
        return smallClassArray;
    }

    [Benchmark]
    public MediumClass[] MediumClass()
    {
        var mediumClassArray = new MediumClass[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumClass test = new(A, B, _sampleString, _sampleString);
            mediumClassArray[i] = test;
        }
        
        return mediumClassArray;
    }

    [Benchmark]
    public LargeClass[] LargeClass()
    {
        var largeClassArray = new LargeClass[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            largeClassArray[i] = test;
        }
        
        return largeClassArray;
    }
    
    [Benchmark]
    public VeryLargeClass[] VeryLargeClass()
    {
        var veryLargeClassArray = new VeryLargeClass[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeClassArray[i] = test;
        }
        
        return veryLargeClassArray;
    }
    #endregion
    
    #region RecordClass
    [Benchmark]
    public SmallRecordClass[] SmallRecordClass()
    {
        var smallRecordClassArray = new SmallRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            SmallRecordClass test = new(A, B);
            smallRecordClassArray[i] = test;
        }
        
        return smallRecordClassArray;
    }

    [Benchmark]
    public MediumRecordClass[] MediumRecordClass()
    {
        var mediumRecordClassArray = new MediumRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            MediumRecordClass test = new(A, B, _sampleString, _sampleString);
            mediumRecordClassArray[i] = test;
        }
        
        return mediumRecordClassArray;
    }
    
    [Benchmark]
    public LargeRecordClass[] LargeRecordClass()
    {
        var largeRecordClassArray = new LargeRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            LargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString);
            largeRecordClassArray[i] = test;
        }
        
        return largeRecordClassArray;
    }
    
    [Benchmark]
    public VeryLargeRecordClass[] VeryLargeRecordClass()
    {
        var veryLargeRecordClassArray = new VeryLargeRecordClass[Count];
        for (int i = 0; i < Count; i++)
        {
            VeryLargeRecordClass test = new(A, B, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeRecordClassArray[i] = test;
        }
        
        return veryLargeRecordClassArray;
    }
    #endregion
}