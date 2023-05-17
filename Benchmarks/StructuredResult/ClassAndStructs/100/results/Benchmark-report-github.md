``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2728/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                 Method |       Mean |    Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|----------------------- |-----------:|---------:|----------:|-------:|-------:|----------:|
|            SmallStruct |   285.6 ns |  5.43 ns |   5.08 ns | 0.3490 | 0.0014 |   2.14 KB |
|           MediumStruct |   872.0 ns | 16.18 ns |  15.90 ns | 0.9918 | 0.0143 |   6.08 KB |
|            LargeStruct | 2,140.5 ns | 41.48 ns |  40.74 ns | 1.6327 | 0.0381 |  10.02 KB |
|       VeryLargeStructs | 4,633.3 ns | 91.95 ns | 119.56 ns | 3.5553 | 0.1602 |  21.83 KB |
|      SmallRecordStruct |   289.4 ns |  4.65 ns |   4.77 ns | 0.3490 | 0.0014 |   2.14 KB |
|     MediumRecordStruct |   857.2 ns | 10.64 ns |   9.96 ns | 0.9918 | 0.0162 |   6.08 KB |
|      LargeRecordStruct | 2,089.2 ns | 29.04 ns |  27.16 ns | 1.6327 | 0.0381 |  10.02 KB |
| VeryLargeRecordStructs | 4,567.8 ns | 29.29 ns |  25.97 ns | 3.5553 | 0.1602 |  21.83 KB |
|             SmallClass |   638.1 ns |  7.25 ns |   6.05 ns | 0.7315 | 0.0095 |   4.48 KB |
|            MediumClass |   920.4 ns | 10.93 ns |  10.23 ns | 0.9861 | 0.0162 |   6.05 KB |
|             LargeClass | 1,326.5 ns | 25.64 ns |  20.02 ns | 1.2417 | 0.0305 |   7.61 KB |
|         VeryLargeClass | 2,297.9 ns | 45.44 ns |  50.51 ns | 2.0065 | 0.0801 |   12.3 KB |
|       SmallRecordClass |   663.5 ns | 10.67 ns |   9.46 ns | 0.7315 | 0.0095 |   4.48 KB |
|      MediumRecordClass |   927.7 ns | 12.54 ns |  11.73 ns | 0.9861 | 0.0162 |   6.05 KB |
|       LargeRecordClass | 1,343.0 ns | 17.27 ns |  15.31 ns | 1.2417 | 0.0305 |   7.61 KB |
|   VeryLargeRecordClass | 2,338.5 ns | 46.52 ns |  73.78 ns | 2.0065 | 0.0801 |   12.3 KB |
