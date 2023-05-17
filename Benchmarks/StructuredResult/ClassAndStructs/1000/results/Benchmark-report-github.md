``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2728/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|----------------------- |----------:|----------:|----------:|--------:|--------:|--------:|----------:|
|            SmallStruct |  2.033 μs | 0.0366 μs | 0.0436 μs |  2.6436 |  0.0954 |       - |  16.21 KB |
|           MediumStruct |  7.562 μs | 0.1511 μs | 0.2307 μs |  7.8430 |  0.7782 |       - |  48.15 KB |
|            LargeStruct | 19.490 μs | 0.2657 μs | 0.2485 μs | 12.9700 |  1.6174 |       - |  80.09 KB |
|       VeryLargeStructs | 65.223 μs | 1.0216 μs | 0.9556 μs | 28.5645 | 28.5645 | 28.5645 | 175.91 KB |
|      SmallRecordStruct |  2.015 μs | 0.0296 μs | 0.0247 μs |  2.6436 |  0.0954 |       - |  16.21 KB |
|     MediumRecordStruct |  7.358 μs | 0.0890 μs | 0.0832 μs |  7.8430 |  0.7782 |       - |  48.15 KB |
|      LargeRecordStruct | 19.559 μs | 0.1355 μs | 0.1202 μs | 12.9700 |  1.6174 |       - |  80.09 KB |
| VeryLargeRecordStructs | 67.127 μs | 1.3332 μs | 1.7335 μs | 28.5645 | 28.5645 | 28.5645 | 175.91 KB |
|             SmallClass |  6.050 μs | 0.1327 μs | 0.3849 μs |  6.4697 |  0.7019 |       - |  39.65 KB |
|            MediumClass |  8.480 μs | 0.1683 μs | 0.4636 μs |  9.0179 |  1.3733 |       - |  55.27 KB |
|             LargeClass | 12.179 μs | 0.2401 μs | 0.3287 μs | 11.5662 |  2.0599 |       - |   70.9 KB |
|         VeryLargeClass | 21.748 μs | 0.4160 μs | 0.4272 μs | 19.1956 |  4.6997 |       - | 117.77 KB |
|       SmallRecordClass |  5.711 μs | 0.1129 μs | 0.1725 μs |  6.4697 |  0.7019 |       - |  39.65 KB |
|      MediumRecordClass |  8.436 μs | 0.1664 μs | 0.3791 μs |  9.0179 |  1.3733 |       - |  55.27 KB |
|       LargeRecordClass | 12.560 μs | 0.1617 μs | 0.1433 μs | 11.5662 |  2.0599 |       - |   70.9 KB |
|   VeryLargeRecordClass | 22.137 μs | 0.3545 μs | 0.3316 μs | 19.1956 |  4.6997 |       - | 117.77 KB |
