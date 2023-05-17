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

    private readonly int _count = 1000;

    #region Struct
    [Benchmark]
    public SmallStruct[] SmallStruct()
    {
        var smallStructArray = new SmallStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallStruct test = new(_a, _b);
            smallStructArray[i] = test;
        }

        return smallStructArray;
    }

    [Benchmark]
    public MediumStruct[] MediumStruct()
    {
        var mediumStructArray = new MediumStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumStruct test = new(_a, _b, _sampleString, _sampleString);
            mediumStructArray[i] = test;
        }
        
        return mediumStructArray;
    }
    
    [Benchmark]
    public LargeStruct[] LargeStruct()
    {
        var largeStructArray = new LargeStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            largeStructArray[i] = test;
        }
        
        return largeStructArray;
    }

    [Benchmark]
    public VeryLargeStruct[] VeryLargeStructs()
    {
        var veryLargeStructArray = new VeryLargeStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeStructArray[i] = test;
        }
        
        return veryLargeStructArray;
    }
    #endregion

    #region RecordStruct
    [Benchmark]
    public SmallRecordStruct[] SmallRecordStruct()
    {
        var smallRecordStructArray = new SmallRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallRecordStruct test = new(_a, _b);
            smallRecordStructArray[i] = test;
        }
        
        return smallRecordStructArray;
    }

    [Benchmark]
    public MediumRecordStruct[] MediumRecordStruct()
    {
        var mediumRecordStructArray = new MediumRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumRecordStruct test = new(_a, _b, _sampleString, _sampleString);
            mediumRecordStructArray[i] = test;
        }
        
        return mediumRecordStructArray;
    }

    [Benchmark]
    public LargeRecordStruct[] LargeRecordStruct()
    {
        var largeRecordStructArray = new LargeRecordStruct[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            largeRecordStructArray[i] = test;
        }
        
        return largeRecordStructArray;
    }
    
    [Benchmark]
    public List<VeryLargeRecordStruct> VeryLargeRecordStructs()
    {
        var veryLargeRecordStructList = new List<VeryLargeRecordStruct>();
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordStruct test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeRecordStructList.Add(test);
        }
        
        return veryLargeRecordStructList;
    }
    #endregion

    #region Class
    [Benchmark]
    public SmallClass[] SmallClass()
    {
        var smallClassArray = new SmallClass[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallClass test = new(_a, _b); 
            smallClassArray[i] = test;
        }
        
        return smallClassArray;
    }

    [Benchmark]
    public MediumClass[] MediumClass()
    {
        var mediumClassArray = new MediumClass[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumClass test = new(_a, _b, _sampleString, _sampleString);
            mediumClassArray[i] = test;
        }
        
        return mediumClassArray;
    }

    [Benchmark]
    public LargeClass[] LargeClass()
    {
        var largeClassArray = new LargeClass[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            largeClassArray[i] = test;
        }
        
        return largeClassArray;
    }
    
    [Benchmark]
    public VeryLargeClass[] VeryLargeClass()
    {
        var veryLargeClassArray = new VeryLargeClass[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeClassArray[i] = test;
        }
        
        return veryLargeClassArray;
    }
    #endregion
    
    #region RecordClass
    [Benchmark]
    public SmallRecordClass[] SmallRecordClass()
    {
        var smallRecordClassArray = new SmallRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            SmallRecordClass test = new(_a, _b);
            smallRecordClassArray[i] = test;
        }
        
        return smallRecordClassArray;
    }

    [Benchmark]
    public MediumRecordClass[] MediumRecordClass()
    {
        var mediumRecordClassArray = new MediumRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            MediumRecordClass test = new(_a, _b, _sampleString, _sampleString);
            mediumRecordClassArray[i] = test;
        }
        
        return mediumRecordClassArray;
    }
    
    [Benchmark]
    public LargeRecordClass[] LargeRecordClass()
    {
        var largeRecordClassArray = new LargeRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            LargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString);
            largeRecordClassArray[i] = test;
        }
        
        return largeRecordClassArray;
    }
    
    [Benchmark]
    public VeryLargeRecordClass[] VeryLargeRecordClass()
    {
        var veryLargeRecordClassArray = new VeryLargeRecordClass[_count];
        for (int i = 0; i < _count; i++)
        {
            VeryLargeRecordClass test = new(_a, _b, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString, _sampleString);
            veryLargeRecordClassArray[i] = test;
        }
        
        return veryLargeRecordClassArray;
    }
    #endregion
}