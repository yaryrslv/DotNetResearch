``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |        Mean |     Error |      StdDev |      Median |      Gen0 |     Gen1 |     Gen2 |   Allocated |
|------------------------------------ |------------:|----------:|------------:|------------:|----------:|---------:|---------:|------------:|
|            SmallStructWithSpan |    107.2 μs |   2.12 μs |     3.71 μs |    105.8 μs |  249.8779 | 249.8779 | 249.8779 |   781.36 KB |
|           MediumStructWithSpan |  1,011.1 μs |  20.21 μs |    49.95 μs |  1,011.1 μs |   33.2031 |  33.2031 |  33.2031 |  2343.78 KB |
|            LargeStructWithSpan |  1,599.6 μs |  31.14 μs |    30.58 μs |  1,597.4 μs |   37.1094 |  37.1094 |  37.1094 |  3906.28 KB |
|       VeryLargeStructsWithSpan |  5,313.6 μs | 103.75 μs |   158.44 μs |  5,335.7 μs |  117.1875 | 117.1875 | 117.1875 |  8593.82 KB |
|      SmallRecordStructWithSpan |    111.9 μs |   1.53 μs |     1.44 μs |    111.7 μs |  249.8779 | 249.8779 | 249.8779 |   781.36 KB |
|     MediumRecordStructWithSpan |  1,032.0 μs |  20.05 μs |    55.89 μs |  1,024.9 μs |   35.1563 |  35.1563 |  35.1563 |  2343.78 KB |
|      LargeRecordStructWithSpan |  1,647.7 μs |  32.95 μs |    70.21 μs |  1,631.4 μs |   35.1563 |  35.1563 |  35.1563 |  3906.28 KB |
| VeryLargeRecordStructsWithSpan |  5,298.4 μs | 105.76 μs |   182.43 μs |  5,289.7 μs |  132.8125 | 132.8125 | 132.8125 |  8593.82 KB |
|             SmallClassWithSpan |  2,098.5 μs |  39.23 μs |    45.17 μs |  2,096.6 μs |  496.0938 | 246.0938 | 246.0938 |  3125.11 KB |
|            MediumClassWithSpan |  8,204.7 μs | 447.52 μs | 1,305.45 μs |  7,666.9 μs |  835.9375 | 421.8750 | 210.9375 |   4687.6 KB |
|             LargeClassWithSpan |  9,025.4 μs | 176.25 μs |   429.01 μs |  8,990.4 μs | 1078.1250 | 500.0000 | 218.7500 |  6250.11 KB |
|         VeryLargeClassWithSpan | 15,784.8 μs | 242.72 μs |   202.68 μs | 15,761.9 μs | 1937.5000 | 843.7500 | 281.2500 | 10937.87 KB |
|       SmallRecordClassWithSpan |  2,137.9 μs |  42.53 μs |   115.70 μs |  2,135.2 μs |  496.0938 | 246.0938 | 246.0938 |  3125.11 KB |
|      MediumRecordClassWithSpan |  6,706.8 μs | 124.84 μs |   257.82 μs |  6,740.0 μs |  812.5000 | 406.2500 | 203.1250 |   4687.6 KB |
|       LargeRecordClassWithSpan |  9,125.8 μs | 176.37 μs |   247.25 μs |  9,209.7 μs | 1078.1250 | 500.0000 | 218.7500 |  6250.11 KB |
|   VeryLargeRecordClassWithSpan | 15,773.3 μs |  89.05 μs |    74.36 μs | 15,760.2 μs | 1937.5000 | 843.7500 | 281.2500 | 10937.86 KB |
