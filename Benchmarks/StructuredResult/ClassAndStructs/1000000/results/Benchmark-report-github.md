``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2728/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                 Method |       Mean |     Error |    StdDev |     Median |       Gen0 |      Gen1 |      Gen2 | Allocated |
|----------------------- |-----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|----------:|
|            SmallStruct |   5.871 ms | 0.1114 ms | 0.1283 ms |   5.843 ms |   742.1875 |  742.1875 |  742.1875 |     16 MB |
|           MediumStruct |  19.969 ms | 0.3977 ms | 0.8214 ms |  20.160 ms |   875.0000 |  875.0000 |  875.0000 |     48 MB |
|            LargeStruct |  41.736 ms | 0.8333 ms | 2.3774 ms |  42.393 ms |  2750.0000 | 2750.0000 | 2750.0000 |     80 MB |
|       VeryLargeStructs |  97.027 ms | 1.8366 ms | 2.0414 ms |  97.242 ms |  3500.0000 | 3500.0000 | 3500.0000 |    176 MB |
|      SmallRecordStruct |   5.707 ms | 0.0911 ms | 0.0852 ms |   5.691 ms |   742.1875 |  742.1875 |  742.1875 |     16 MB |
|     MediumRecordStruct |  19.854 ms | 0.3954 ms | 0.6038 ms |  19.866 ms |  1531.2500 | 1531.2500 | 1531.2500 |     48 MB |
|      LargeRecordStruct |  42.111 ms | 0.8325 ms | 1.7740 ms |  42.403 ms |  2750.0000 | 2750.0000 | 2750.0000 |     80 MB |
| VeryLargeRecordStructs |  97.332 ms | 1.6569 ms | 1.5499 ms |  97.332 ms |  3800.0000 | 3800.0000 | 3800.0000 |    176 MB |
|             SmallClass |  53.659 ms | 1.0649 ms | 0.9961 ms |  53.907 ms |  4600.0000 | 2300.0000 | 1300.0000 |  38.89 MB |
|            MediumClass |  76.830 ms | 1.5144 ms | 2.3127 ms |  76.692 ms |  7666.6667 | 3833.3333 | 2000.0000 |  54.15 MB |
|             LargeClass |  89.653 ms | 1.7242 ms | 1.6128 ms |  89.118 ms |  9833.3333 | 4000.0000 | 1500.0000 |  69.41 MB |
|         VeryLargeClass | 147.843 ms | 2.9342 ms | 2.6011 ms | 148.063 ms | 18000.0000 | 7000.0000 | 2000.0000 | 115.18 MB |
|       SmallRecordClass |  52.674 ms | 0.6387 ms | 0.5334 ms |  52.692 ms |  4600.0000 | 2300.0000 | 1300.0000 |  38.89 MB |
|      MediumRecordClass |  74.736 ms | 1.4503 ms | 2.3420 ms |  75.171 ms |  7571.4286 | 3714.2857 | 1857.1429 |  54.15 MB |
|       LargeRecordClass |  89.647 ms | 1.6549 ms | 1.5480 ms |  89.036 ms |  9833.3333 | 4000.0000 | 1500.0000 |  69.41 MB |
|   VeryLargeRecordClass | 147.543 ms | 2.7525 ms | 2.4400 ms | 147.505 ms | 18000.0000 | 7000.0000 | 2000.0000 | 115.19 MB |
