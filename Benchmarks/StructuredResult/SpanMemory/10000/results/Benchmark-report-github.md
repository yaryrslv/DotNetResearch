``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |       Mean |     Error |     StdDev |     Median |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|------------------------------------ |-----------:|----------:|-----------:|-----------:|---------:|---------:|---------:|-----------:|
|            SmallStructWithSpan |   8.741 μs | 0.1564 μs |  0.1387 μs |   8.761 μs |  12.6495 |   2.5177 |        - |   78.15 KB |
|           MediumStructWithSpan |  47.565 μs | 0.7764 μs |  0.7263 μs |  47.582 μs |  71.4111 |  71.4111 |  71.4111 |  234.42 KB |
|            LargeStructWithSpan |  87.841 μs | 1.2201 μs |  1.1413 μs |  87.834 μs | 124.8779 | 124.8779 | 124.8779 |  390.69 KB |
|       VeryLargeStructsWithSpan | 399.842 μs | 5.8572 μs |  5.4788 μs | 399.522 μs | 154.2969 | 154.2969 | 154.2969 |  859.44 KB |
|      SmallRecordStructWithSpan |   9.193 μs | 0.1837 μs |  0.4838 μs |   9.151 μs |  12.6495 |   2.5177 |        - |   78.15 KB |
|     MediumRecordStructWithSpan |  49.657 μs | 0.9837 μs |  2.0533 μs |  49.622 μs |  71.4111 |  71.4111 |  71.4111 |  234.42 KB |
|      LargeRecordStructWithSpan |  93.229 μs | 1.8073 μs |  2.6492 μs |  92.563 μs | 124.8779 | 124.8779 | 124.8779 |  390.69 KB |
| VeryLargeRecordStructsWithSpan | 407.877 μs | 8.0295 μs |  8.9248 μs | 408.232 μs | 155.2734 | 155.2734 | 155.2734 |  859.44 KB |
|             SmallClassWithSpan |  58.388 μs | 1.1589 μs |  2.3411 μs |  57.652 μs |  50.8423 |  25.3906 |        - |  312.52 KB |
|            MediumClassWithSpan | 106.265 μs | 1.5078 μs |  1.2591 μs | 105.952 μs |  76.4160 |  38.2080 |        - |  468.77 KB |
|             LargeClassWithSpan | 174.369 μs | 3.4595 μs |  6.4123 μs | 173.719 μs | 101.8066 |  50.7813 |        - |  625.02 KB |
|         VeryLargeClassWithSpan | 389.036 μs | 7.7554 μs | 20.4309 μs | 378.035 μs | 178.2227 |  88.8672 |        - | 1093.77 KB |
|       SmallRecordClassWithSpan |  59.186 μs | 1.1340 μs |  1.5139 μs |  59.608 μs |  50.8423 |  25.3906 |        - |  312.52 KB |
|      MediumRecordClassWithSpan | 108.366 μs | 2.0903 μs |  2.5671 μs | 108.463 μs |  76.4160 |  38.2080 |        - |  468.77 KB |
|       LargeRecordClassWithSpan | 171.141 μs | 3.3730 μs |  3.1551 μs | 171.274 μs | 101.8066 |  50.7813 |        - |  625.02 KB |
|   VeryLargeRecordClassWithSpan | 395.741 μs | 7.7454 μs | 10.6020 μs | 396.552 μs | 178.2227 |  88.8672 |        - | 1093.77 KB |
