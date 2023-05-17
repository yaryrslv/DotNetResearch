``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |       Mean |    Error |   StdDev |   Gen0 |   Gen1 | Allocated |
|------------------------------------ |-----------:|---------:|---------:|-------:|-------:|----------:|
|            SmallStructWithArrayPool |   118.4 ns |  2.00 ns |  1.87 ns | 0.1669 |      - |   1.02 KB |
|           MediumStructWithArrayPool |   511.0 ns | 10.23 ns | 13.30 ns | 0.4930 |      - |   3.02 KB |
|            LargeStructWithArrayPool |   958.6 ns | 19.15 ns | 38.69 ns | 0.8192 |      - |   5.02 KB |
|       VeryLargeStructsWithArrayPool | 3,335.4 ns | 61.15 ns | 54.20 ns | 1.7929 |      - |  11.02 KB |
|      SmallRecordStructWithArrayPool |   120.7 ns |  2.37 ns |  2.22 ns | 0.1670 |      - |   1.02 KB |
|     MediumRecordStructWithArrayPool |   500.5 ns |  5.76 ns |  5.39 ns | 0.4930 |      - |   3.02 KB |
|      LargeRecordStructWithArrayPool |   932.7 ns | 16.53 ns | 15.46 ns | 0.8192 |      - |   5.02 KB |
| VeryLargeRecordStructsWithArrayPool | 3,317.8 ns | 24.35 ns | 21.58 ns | 1.7929 |      - |  11.02 KB |
|             SmallClassWithArrayPool |   514.2 ns | 10.22 ns | 13.30 ns | 0.5493 | 0.0067 |   3.37 KB |
|            MediumClassWithArrayPool |   820.0 ns | 15.94 ns | 15.66 ns | 0.8039 | 0.0143 |   4.93 KB |
|             LargeClassWithArrayPool | 1,123.1 ns | 19.21 ns | 17.97 ns | 1.0586 | 0.0248 |   6.49 KB |
|         VeryLargeClassWithArrayPool | 2,138.9 ns | 28.39 ns | 26.56 ns | 1.8234 | 0.0725 |  11.18 KB |
|       SmallRecordClassWithArrayPool |   490.0 ns |  7.41 ns |  6.93 ns | 0.5493 | 0.0067 |   3.37 KB |
|      MediumRecordClassWithArrayPool |   801.4 ns |  7.01 ns |  6.22 ns | 0.8039 | 0.0143 |   4.93 KB |
|       LargeRecordClassWithArrayPool | 1,166.5 ns | 18.85 ns | 17.64 ns | 1.0586 | 0.0248 |   6.49 KB |
|   VeryLargeRecordClassWithArrayPool | 2,165.5 ns | 43.32 ns | 63.50 ns | 1.8234 | 0.0725 |  11.18 KB |
