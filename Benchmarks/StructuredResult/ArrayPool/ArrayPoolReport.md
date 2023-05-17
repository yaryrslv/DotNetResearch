``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
# ArrayPool

## 100

|                              Method |       Mean |    Error |   StdDev |   Gen0 |   Gen1 | Allocated |
|------------------------------------ |-----------:|---------:|---------:|-------:|-------:|----------:|
|            SmallStructWithArrayPool |   118.4 ns |  2.00 ns |  1.87 ns | 0.1669 |      - |   1.02 KB |
|           MediumStructWithArrayPool |   511.0 ns | 10.23 ns | 13.30 ns | 0.4930 |      - |   3.02 KB |
|            LargeStructWithArrayPool |   958.6 ns | 19.15 ns | 38.69 ns | 0.8192 |      - |   5.02 KB |
|       VeryLargeStructsWithArrayPool | 3,335.4 ns | 61.15 ns | 54.20 ns | 1.7929 |      - |  11.02 KB |
|      SmallRecordStructWithArrayPool |   120.7 ns |  2.37 ns |  2.22 ns | 0.1670 |      - |   1.02 KB |
|     MediumRecordStructWithArrayPool |   500.5 ns |  5.76 ns |  5.39 ns | 0.4930 |      - |   3.02 KB |
|      LargeRecordStructWithArrayPool |   932.7 ns | 16.53 ns | 15.46 ns | 0.8192 |      - |   5.02 KB |
| VeryLargeRecordStructsWithArrayPool | 3,317.8 ns | 24.35 ns | 21.58 ns | 1.7929 |      - |  11.02 KB |
|             SmallClassWithArrayPool |   514.2 ns | 10.22 ns | 13.30 ns | 0.5493 | 0.0067 |   3.37 KB |
|            MediumClassWithArrayPool |   820.0 ns | 15.94 ns | 15.66 ns | 0.8039 | 0.0143 |   4.93 KB |
|             LargeClassWithArrayPool | 1,123.1 ns | 19.21 ns | 17.97 ns | 1.0586 | 0.0248 |   6.49 KB |
|         VeryLargeClassWithArrayPool | 2,138.9 ns | 28.39 ns | 26.56 ns | 1.8234 | 0.0725 |  11.18 KB |
|       SmallRecordClassWithArrayPool |   490.0 ns |  7.41 ns |  6.93 ns | 0.5493 | 0.0067 |   3.37 KB |
|      MediumRecordClassWithArrayPool |   801.4 ns |  7.01 ns |  6.22 ns | 0.8039 | 0.0143 |   4.93 KB |
|       LargeRecordClassWithArrayPool | 1,166.5 ns | 18.85 ns | 17.64 ns | 1.0586 | 0.0248 |   6.49 KB |
|   VeryLargeRecordClassWithArrayPool | 2,165.5 ns | 43.32 ns | 63.50 ns | 1.8234 | 0.0725 |  11.18 KB |

## 1000

|                              Method |        Mean |       Error |      StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|------------------------------------ |------------:|------------:|------------:|--------:|--------:|--------:|----------:|
|            SmallStructWithArrayPool |    711.8 ns |    14.20 ns |    26.31 ns |  1.3046 |       - |       - |   8.02 KB |
|           MediumStructWithArrayPool |  4,526.4 ns |    85.73 ns |    80.19 ns |  3.9063 |       - |       - |  24.02 KB |
|            LargeStructWithArrayPool |  8,466.8 ns |   116.81 ns |   109.27 ns |  6.4850 |       - |       - |  40.02 KB |
|       VeryLargeStructsWithArrayPool | 51,519.4 ns |   683.65 ns |   639.49 ns | 28.5645 | 28.5645 | 28.5645 |  88.03 KB |
|      SmallRecordStructWithArrayPool |    684.6 ns |    13.69 ns |    24.33 ns |  1.3046 |       - |       - |   8.02 KB |
|     MediumRecordStructWithArrayPool |  4,600.5 ns |    87.48 ns |    81.83 ns |  3.9063 |       - |       - |  24.02 KB |
|      LargeRecordStructWithArrayPool |  8,393.7 ns |   165.79 ns |   177.40 ns |  6.4850 |       - |       - |  40.02 KB |
| VeryLargeRecordStructsWithArrayPool | 51,989.1 ns | 1,038.17 ns | 1,616.30 ns | 28.5645 | 28.5645 | 28.5645 |  88.03 KB |
|             SmallClassWithArrayPool |  4,804.2 ns |    96.00 ns |   106.70 ns |  5.1270 |  0.5112 |       - |  31.46 KB |
|            MediumClassWithArrayPool |  7,778.4 ns |    62.17 ns |    58.15 ns |  7.6752 |  1.1444 |       - |  47.09 KB |
|             LargeClassWithArrayPool | 11,429.5 ns |   222.16 ns |   207.81 ns | 10.2234 |  1.7700 |       - |  62.71 KB |
|         VeryLargeClassWithArrayPool | 22,485.1 ns |   432.41 ns |   480.62 ns | 17.8833 |  4.6082 |       - | 109.59 KB |
|       SmallRecordClassWithArrayPool |  4,893.6 ns |    95.36 ns |   142.73 ns |  5.1270 |  0.5112 |       - |  31.46 KB |
|      MediumRecordClassWithArrayPool |  8,059.9 ns |   159.51 ns |   201.72 ns |  7.6752 |  1.1444 |       - |  47.09 KB |
|       LargeRecordClassWithArrayPool | 11,419.6 ns |   227.05 ns |   397.66 ns | 10.2234 |  1.7700 |       - |  62.71 KB |
|   VeryLargeRecordClassWithArrayPool | 22,371.7 ns |   418.95 ns |   448.27 ns | 17.8833 |  4.6082 |       - | 109.59 KB |

## 10000

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

## 100000

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


## 1000000

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

