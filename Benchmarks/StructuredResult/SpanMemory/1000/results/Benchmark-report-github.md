``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |        Mean |     Error |    StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|------------------------------------ |------------:|----------:|----------:|--------:|--------:|--------:|----------:|
|            SmallStructWithSpan |    886.5 ns |  17.40 ns |  26.04 ns |  1.2779 |  0.0372 |       - |   7.84 KB |
|           MediumStructWithSpan |  4,236.4 ns |  32.66 ns |  25.50 ns |  3.8147 |  0.3128 |       - |  23.46 KB |
|            LargeStructWithSpan |  7,978.1 ns | 158.72 ns | 194.92 ns |  6.3248 |  0.7858 |       - |  39.09 KB |
|       VeryLargeStructsWithSpan | 32,345.3 ns | 620.44 ns | 637.15 ns | 27.7710 | 27.7710 | 27.7710 |  85.97 KB |
|      SmallRecordStructWithSpan |    909.2 ns |  14.58 ns |  16.20 ns |  1.2779 |  0.0372 |       - |   7.84 KB |
|     MediumRecordStructWithSpan |  4,475.5 ns |  88.95 ns |  83.21 ns |  3.8147 |  0.3128 |       - |  23.46 KB |
|      LargeRecordStructWithSpan |  7,866.5 ns | 118.67 ns | 111.00 ns |  6.3171 |  0.7782 |       - |  39.09 KB |
| VeryLargeRecordStructsWithSpan | 32,631.6 ns | 292.18 ns | 259.01 ns | 27.7710 | 27.7710 | 27.7710 |  85.97 KB |
|             SmallClassWithSpan |  4,228.0 ns |  82.53 ns |  91.73 ns |  5.0964 |  0.8469 |       - |  31.27 KB |
|            MediumClassWithSpan |  7,119.5 ns | 142.41 ns | 146.24 ns |  7.6523 |  1.9073 |       - |   46.9 KB |
|             LargeClassWithSpan |  9,838.7 ns | 126.33 ns | 111.99 ns | 10.1929 |  2.5482 |       - |  62.52 KB |
|         VeryLargeClassWithSpan | 21,234.2 ns | 334.54 ns | 296.56 ns | 17.8528 |  0.0305 |       - |  109.4 KB |
|       SmallRecordClassWithSpan |  3,941.0 ns |  78.49 ns |  80.60 ns |  5.0964 |  0.8469 |       - |  31.27 KB |
|      MediumRecordClassWithSpan |  6,817.8 ns |  60.13 ns |  53.31 ns |  7.6523 |  1.9073 |       - |   46.9 KB |
|       LargeRecordClassWithSpan | 10,577.1 ns | 113.60 ns |  94.86 ns | 10.1929 |  2.5482 |       - |  62.52 KB |
|   VeryLargeRecordClassWithSpan | 21,862.0 ns | 304.02 ns | 284.38 ns | 17.8528 |  0.0305 |       - |  109.4 KB |
