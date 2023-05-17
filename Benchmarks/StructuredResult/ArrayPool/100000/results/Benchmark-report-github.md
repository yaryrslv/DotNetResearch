``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |        Mean |     Error |    StdDev |      Gen0 |     Gen1 |     Gen2 | Allocated |
|------------------------------------ |------------:|----------:|----------:|----------:|---------:|---------:|----------:|
|            SmallStructWithArrayPool |    276.1 μs |   5.51 μs |  12.56 μs |  333.0078 | 333.0078 | 333.0078 |      1 MB |
|           MediumStructWithArrayPool |  1,040.2 μs |  21.34 μs |  62.91 μs |  998.0469 | 998.0469 | 998.0469 |      3 MB |
|            LargeStructWithArrayPool |  2,007.3 μs |  39.62 μs |  76.34 μs |  285.1563 | 285.1563 | 285.1563 |      5 MB |
|       VeryLargeStructsWithArrayPool |  5,764.0 μs | 111.89 μs | 288.83 μs |  328.1250 | 328.1250 | 328.1250 |     11 MB |
|      SmallRecordStructWithArrayPool |    256.1 μs |   3.19 μs |   2.83 μs |  333.0078 | 333.0078 | 333.0078 |      1 MB |
|     MediumRecordStructWithArrayPool |    905.7 μs |   6.27 μs |   5.55 μs |  999.0234 | 999.0234 | 999.0234 |      3 MB |
|      LargeRecordStructWithArrayPool |  1,748.5 μs |  27.05 μs |  23.98 μs |  412.1094 | 412.1094 | 412.1094 |      5 MB |
| VeryLargeRecordStructsWithArrayPool |  5,416.4 μs | 106.69 μs | 242.99 μs |  375.0000 | 375.0000 | 375.0000 |     11 MB |
|             SmallClassWithArrayPool |  3,595.8 μs |   8.50 μs |   7.54 μs |  535.1563 | 457.0313 | 304.6875 |   3.29 MB |
|            MediumClassWithArrayPool |  2,031.5 μs |  18.76 μs |  17.55 μs |  664.0625 | 332.0313 | 332.0313 |   4.81 MB |
|             LargeClassWithArrayPool |  6,771.4 μs | 134.82 μs | 393.28 μs | 1085.9375 | 632.8125 | 312.5000 |   6.34 MB |
|         VeryLargeClassWithArrayPool | 11,392.4 μs | 163.25 μs | 152.71 μs | 1890.6250 | 843.7500 | 390.6250 |  10.92 MB |
|       SmallRecordClassWithArrayPool |  3,578.4 μs |   9.01 μs |   8.43 μs |  535.1563 | 457.0313 | 304.6875 |   3.29 MB |
|      MediumRecordClassWithArrayPool |  2,164.0 μs |  42.49 μs |  63.59 μs |  664.0625 | 332.0313 | 332.0313 |   4.81 MB |
|       LargeRecordClassWithArrayPool |  6,837.0 μs | 136.62 μs | 305.58 μs | 1085.9375 | 640.6250 | 312.5000 |   6.34 MB |
|   VeryLargeRecordClassWithArrayPool | 11,127.1 μs | 200.86 μs | 294.42 μs | 1890.6250 | 843.7500 | 390.6250 |  10.92 MB |
