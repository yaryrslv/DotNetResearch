``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                              Method |       Mean |     Error |    StdDev |       Gen0 |      Gen1 |      Gen2 | Allocated |
|------------------------------------ |-----------:|----------:|----------:|-----------:|----------:|----------:|----------:|
|            SmallStructWithSpan |   3.226 ms | 0.0475 ms | 0.0421 ms |   183.5938 |  183.5938 |  183.5938 |   7.63 MB |
|           MediumStructWithSpan |   9.535 ms | 0.1867 ms | 0.2492 ms |   109.3750 |  109.3750 |  109.3750 |  22.89 MB |
|            LargeStructWithSpan |  16.970 ms | 0.3307 ms | 0.4950 ms |   156.2500 |  156.2500 |  156.2500 |  38.15 MB |
|       VeryLargeStructsWithSpan |  56.089 ms | 1.1030 ms | 1.4342 ms |   333.3333 |  333.3333 |  333.3333 |  83.92 MB |
|      SmallRecordStructWithSpan |   3.252 ms | 0.0649 ms | 0.1370 ms |   183.5938 |  183.5938 |  183.5938 |   7.63 MB |
|     MediumRecordStructWithSpan |   9.822 ms | 0.1960 ms | 0.3484 ms |   109.3750 |  109.3750 |  109.3750 |  22.89 MB |
|      LargeRecordStructWithSpan |  17.776 ms | 0.3333 ms | 0.7592 ms |   156.2500 |  156.2500 |  156.2500 |  38.15 MB |
| VeryLargeRecordStructsWithSpan |  57.830 ms | 1.1304 ms | 1.9797 ms |   300.0000 |  300.0000 |  300.0000 |  83.92 MB |
|             SmallClassWithSpan |  56.131 ms | 1.1093 ms | 1.8533 ms |  4500.0000 | 2000.0000 |  700.0000 |  30.52 MB |
|            MediumClassWithSpan |  84.256 ms | 1.6471 ms | 3.2894 ms |  7500.0000 | 3333.3333 | 1166.6667 |  45.78 MB |
|             LargeClassWithSpan |  87.558 ms | 1.7320 ms | 3.0335 ms |  9833.3333 | 4000.0000 | 1000.0000 |  61.04 MB |
|         VeryLargeClassWithSpan | 197.150 ms | 3.6307 ms | 5.6525 ms | 18000.0000 | 7000.0000 | 1500.0000 | 106.81 MB |
|       SmallRecordClassWithSpan |  54.746 ms | 1.0817 ms | 1.4806 ms |  4437.5000 | 1875.0000 |  625.0000 |  30.52 MB |
|      MediumRecordClassWithSpan |  77.597 ms | 1.5295 ms | 3.5449 ms |  7285.7143 | 3142.8571 | 1000.0000 |  45.78 MB |
|       LargeRecordClassWithSpan |  89.635 ms | 1.7768 ms | 3.0171 ms |  9833.3333 | 4000.0000 | 1000.0000 |  61.04 MB |
|   VeryLargeRecordClassWithSpan | 188.448 ms | 2.0417 ms | 1.7049 ms | 18000.0000 | 7000.0000 | 1500.0000 | 106.81 MB |
