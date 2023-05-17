``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
# ArrayPool

## 100

|                              Method |        Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|------------------------------------ |------------:|----------:|----------:|-------:|-------:|----------:|
|            SmallStructWithSpan |    93.06 ns |  1.841 ns |  1.809 ns | 0.1312 | 0.0004 |     824 B |
|           MediumStructWithSpan |   449.99 ns |  9.007 ns |  8.426 ns | 0.3862 | 0.0033 |    2424 B |
|            LargeStructWithSpan |   783.97 ns | 15.098 ns | 15.505 ns | 0.6409 | 0.0095 |    4024 B |
|       VeryLargeStructsWithSpan | 3,034.49 ns | 40.914 ns | 38.271 ns | 1.4038 | 0.0420 |    8824 B |
|      SmallRecordStructWithSpan |    93.50 ns |  1.581 ns |  2.056 ns | 0.1312 | 0.0004 |     824 B |
|     MediumRecordStructWithSpan |   437.54 ns |  6.984 ns |  6.533 ns | 0.3862 | 0.0033 |    2424 B |
|      LargeRecordStructWithSpan |   786.89 ns | 15.562 ns | 23.765 ns | 0.6409 | 0.0095 |    4024 B |
| VeryLargeRecordStructsWithSpan | 3,054.67 ns | 22.618 ns | 20.050 ns | 1.4038 | 0.0420 |    8824 B |
|             SmallClassWithSpan |   395.27 ns |  6.214 ns |  5.812 ns | 0.5136 | 0.0119 |    3224 B |
|            MediumClassWithSpan |   649.39 ns | 12.894 ns | 13.796 ns | 0.7687 | 0.0267 |    4824 B |
|             LargeClassWithSpan |   913.88 ns |  5.516 ns |  4.890 ns | 1.0233 | 0.0458 |    6424 B |
|         VeryLargeClassWithSpan | 1,974.12 ns | 23.592 ns | 20.913 ns | 1.7891 | 0.1335 |   11224 B |
|       SmallRecordClassWithSpan |   402.14 ns |  7.914 ns | 11.846 ns | 0.5136 | 0.0119 |    3224 B |
|      MediumRecordClassWithSpan |   637.39 ns | 10.505 ns |  9.826 ns | 0.7687 | 0.0267 |    4824 B |
|       LargeRecordClassWithSpan | 1,006.33 ns | 18.354 ns | 23.866 ns | 1.0223 | 0.0458 |    6424 B |
|   VeryLargeRecordClassWithSpan | 2,029.18 ns | 39.122 ns | 80.794 ns | 1.7891 | 0.1335 |   11224 B |


## 1000

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


## 10000

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


## 100000

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

## 1000000

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

