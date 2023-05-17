``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |       Mean |     Error |    StdDev |       Gen0 |      Gen1 |      Gen2 | Allocated |
|------------------------------------ |-----------:|----------:|----------:|-----------:|----------:|----------:|----------:|
|            SmallStructWithArrayPool |   1.743 ms | 0.0731 ms | 0.2133 ms |   421.8750 |  421.8750 |  421.8750 |      8 MB |
|           MediumStructWithArrayPool |  11.290 ms | 0.2709 ms | 0.7987 ms |   406.2500 |  406.2500 |  406.2500 |     24 MB |
|            LargeStructWithArrayPool |  16.896 ms | 0.1829 ms | 0.1622 ms |   968.7500 |  968.7500 |  968.7500 |     40 MB |
|       VeryLargeStructsWithArrayPool |  49.877 ms | 0.6743 ms | 0.5978 ms |   909.0909 |  909.0909 |  909.0909 |     88 MB |
|      SmallRecordStructWithArrayPool |   1.640 ms | 0.0562 ms | 0.1621 ms |   445.3125 |  445.3125 |  445.3125 |      8 MB |
|     MediumRecordStructWithArrayPool |  11.308 ms | 0.2903 ms | 0.8514 ms |   375.0000 |  375.0000 |  375.0000 |     24 MB |
|      LargeRecordStructWithArrayPool |  16.900 ms | 0.1855 ms | 0.1735 ms |   968.7500 |  968.7500 |  968.7500 |     40 MB |
| VeryLargeRecordStructsWithArrayPool |  48.743 ms | 0.5356 ms | 0.5010 ms |   909.0909 |  909.0909 |  909.0909 |     88 MB |
|             SmallClassWithArrayPool |  42.355 ms | 0.2471 ms | 0.2190 ms |  4538.4615 | 2230.7692 | 1000.0000 |  30.89 MB |
|            MediumClassWithArrayPool |  57.325 ms | 0.8320 ms | 0.7783 ms |  7100.0000 | 2900.0000 | 1000.0000 |  46.15 MB |
|             LargeClassWithArrayPool |  89.372 ms | 1.4184 ms | 1.3268 ms | 10000.0000 | 4166.6667 | 1500.0000 |  61.41 MB |
|         VeryLargeClassWithArrayPool | 135.181 ms | 2.5678 ms | 2.2763 ms | 18250.0000 | 7500.0000 | 2250.0000 | 107.19 MB |
|       SmallRecordClassWithArrayPool |  42.163 ms | 0.2105 ms | 0.1758 ms |  4538.4615 | 2230.7692 | 1000.0000 |  30.89 MB |
|      MediumRecordClassWithArrayPool |  56.859 ms | 1.0821 ms | 1.2461 ms |  7111.1111 | 2888.8889 | 1000.0000 |  46.15 MB |
|       LargeRecordClassWithArrayPool |  89.889 ms | 1.7007 ms | 1.6703 ms | 10000.0000 | 4166.6667 | 1500.0000 |  61.41 MB |
|   VeryLargeRecordClassWithArrayPool | 136.307 ms | 2.5967 ms | 3.0912 ms | 18250.0000 | 7250.0000 | 2250.0000 | 107.18 MB |
