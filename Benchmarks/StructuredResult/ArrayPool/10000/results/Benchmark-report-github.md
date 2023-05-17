``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |        Mean |     Error |    StdDev |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|------------------------------------ |------------:|----------:|----------:|---------:|---------:|---------:|-----------:|
|            SmallStructWithArrayPool |    30.24 μs |  0.600 μs |  1.199 μs |  41.6565 |  41.6565 |  41.6565 |  128.04 KB |
|           MediumStructWithArrayPool |   100.02 μs |  1.656 μs |  1.293 μs | 124.8779 | 124.8779 | 124.8779 |  384.06 KB |
|            LargeStructWithArrayPool |   178.32 μs |  3.425 μs |  4.206 μs | 199.9512 | 199.9512 | 199.9512 |  640.09 KB |
|       VeryLargeStructsWithArrayPool |   481.48 μs |  6.585 μs |  6.159 μs | 204.1016 | 204.1016 | 204.1016 | 1408.09 KB |
|      SmallRecordStructWithArrayPool |    29.94 μs |  0.575 μs |  0.768 μs |  41.6565 |  41.6565 |  41.6565 |  128.04 KB |
|     MediumRecordStructWithArrayPool |   102.28 μs |  1.983 μs |  2.360 μs | 124.8779 | 124.8779 | 124.8779 |  384.06 KB |
|      LargeRecordStructWithArrayPool |   179.25 μs |  3.562 μs |  5.108 μs | 199.9512 | 199.9512 | 199.9512 |  640.09 KB |
| VeryLargeRecordStructsWithArrayPool |   484.35 μs |  8.848 μs | 11.812 μs | 205.0781 | 205.0781 | 205.0781 | 1408.09 KB |
|             SmallClassWithArrayPool |   107.41 μs |  1.283 μs |  1.200 μs |  41.6260 |  41.6260 |  41.6260 |  362.41 KB |
|            MediumClassWithArrayPool |   238.61 μs |  4.404 μs |  7.112 μs |  83.0078 |  41.5039 |  41.5039 |  518.66 KB |
|             LargeClassWithArrayPool |   608.85 μs |  3.223 μs |  2.691 μs | 117.1875 |  78.1250 |  39.0625 |  674.91 KB |
|         VeryLargeClassWithArrayPool | 1,080.20 μs | 21.362 μs | 48.652 μs | 195.3125 | 105.4688 |  41.0156 | 1143.67 KB |
|       SmallRecordClassWithArrayPool |   108.31 μs |  1.396 μs |  1.306 μs |  41.6260 |  41.6260 |  41.6260 |  362.41 KB |
|      MediumRecordClassWithArrayPool |   242.67 μs |  4.757 μs |  4.886 μs |  83.2520 |  41.5039 |  41.5039 |  518.66 KB |
|       LargeRecordClassWithArrayPool |   608.41 μs |  2.748 μs |  2.436 μs | 117.1875 |  78.1250 |  39.0625 |  674.91 KB |
|   VeryLargeRecordClassWithArrayPool | 1,068.53 μs | 21.255 μs | 46.206 μs | 197.2656 | 105.4688 |  41.0156 | 1143.66 KB |
