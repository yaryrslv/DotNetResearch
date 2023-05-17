``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |        Mean |       Error |      StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|------------------------------------ |------------:|------------:|------------:|--------:|--------:|--------:|----------:|
|            SmallStructWithArrayPool |    711.8 ns |    14.20 ns |    26.31 ns |  1.3046 |       - |       - |   8.02 KB |
|           MediumStructWithArrayPool |  4,526.4 ns |    85.73 ns |    80.19 ns |  3.9063 |       - |       - |  24.02 KB |
|            LargeStructWithArrayPool |  8,466.8 ns |   116.81 ns |   109.27 ns |  6.4850 |       - |       - |  40.02 KB |
|       VeryLargeStructsWithArrayPool | 51,519.4 ns |   683.65 ns |   639.49 ns | 28.5645 | 28.5645 | 28.5645 |  88.03 KB |
|      SmallRecordStructWithArrayPool |    684.6 ns |    13.69 ns |    24.33 ns |  1.3046 |       - |       - |   8.02 KB |
|     MediumRecordStructWithArrayPool |  4,600.5 ns |    87.48 ns |    81.83 ns |  3.9063 |       - |       - |  24.02 KB |
|      LargeRecordStructWithArrayPool |  8,393.7 ns |   165.79 ns |   177.40 ns |  6.4850 |       - |       - |  40.02 KB |
| VeryLargeRecordStructsWithArrayPool | 51,989.1 ns | 1,038.17 ns | 1,616.30 ns | 28.5645 | 28.5645 | 28.5645 |  88.03 KB |
|             SmallClassWithArrayPool |  4,804.2 ns |    96.00 ns |   106.70 ns |  5.1270 |  0.5112 |       - |  31.46 KB |
|            MediumClassWithArrayPool |  7,778.4 ns |    62.17 ns |    58.15 ns |  7.6752 |  1.1444 |       - |  47.09 KB |
|             LargeClassWithArrayPool | 11,429.5 ns |   222.16 ns |   207.81 ns | 10.2234 |  1.7700 |       - |  62.71 KB |
|         VeryLargeClassWithArrayPool | 22,485.1 ns |   432.41 ns |   480.62 ns | 17.8833 |  4.6082 |       - | 109.59 KB |
|       SmallRecordClassWithArrayPool |  4,893.6 ns |    95.36 ns |   142.73 ns |  5.1270 |  0.5112 |       - |  31.46 KB |
|      MediumRecordClassWithArrayPool |  8,059.9 ns |   159.51 ns |   201.72 ns |  7.6752 |  1.1444 |       - |  47.09 KB |
|       LargeRecordClassWithArrayPool | 11,419.6 ns |   227.05 ns |   397.66 ns | 10.2234 |  1.7700 |       - |  62.71 KB |
|   VeryLargeRecordClassWithArrayPool | 22,371.7 ns |   418.95 ns |   448.27 ns | 17.8833 |  4.6082 |       - | 109.59 KB |
