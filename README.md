# DotNetResearch
``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
```


<details>
  <summary>ClassStruct</summary>
  
## 100

|                 Method |       Mean |    Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|----------------------- |-----------:|---------:|----------:|-------:|-------:|----------:|
|            SmallStruct |   285.6 ns |  5.43 ns |   5.08 ns | 0.3490 | 0.0014 |   2.14 KB |
|           MediumStruct |   872.0 ns | 16.18 ns |  15.90 ns | 0.9918 | 0.0143 |   6.08 KB |
|            LargeStruct | 2,140.5 ns | 41.48 ns |  40.74 ns | 1.6327 | 0.0381 |  10.02 KB |
|       VeryLargeStructs | 4,633.3 ns | 91.95 ns | 119.56 ns | 3.5553 | 0.1602 |  21.83 KB |
|      SmallRecordStruct |   289.4 ns |  4.65 ns |   4.77 ns | 0.3490 | 0.0014 |   2.14 KB |
|     MediumRecordStruct |   857.2 ns | 10.64 ns |   9.96 ns | 0.9918 | 0.0162 |   6.08 KB |
|      LargeRecordStruct | 2,089.2 ns | 29.04 ns |  27.16 ns | 1.6327 | 0.0381 |  10.02 KB |
| VeryLargeRecordStructs | 4,567.8 ns | 29.29 ns |  25.97 ns | 3.5553 | 0.1602 |  21.83 KB |
|             SmallClass |   638.1 ns |  7.25 ns |   6.05 ns | 0.7315 | 0.0095 |   4.48 KB |
|            MediumClass |   920.4 ns | 10.93 ns |  10.23 ns | 0.9861 | 0.0162 |   6.05 KB |
|             LargeClass | 1,326.5 ns | 25.64 ns |  20.02 ns | 1.2417 | 0.0305 |   7.61 KB |
|         VeryLargeClass | 2,297.9 ns | 45.44 ns |  50.51 ns | 2.0065 | 0.0801 |   12.3 KB |
|       SmallRecordClass |   663.5 ns | 10.67 ns |   9.46 ns | 0.7315 | 0.0095 |   4.48 KB |
|      MediumRecordClass |   927.7 ns | 12.54 ns |  11.73 ns | 0.9861 | 0.0162 |   6.05 KB |
|       LargeRecordClass | 1,343.0 ns | 17.27 ns |  15.31 ns | 1.2417 | 0.0305 |   7.61 KB |
|   VeryLargeRecordClass | 2,338.5 ns | 46.52 ns |  73.78 ns | 2.0065 | 0.0801 |   12.3 KB |

## 1000

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

## 10000

|                 Method |        Mean |     Error |    StdDev |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|----------------------- |------------:|----------:|----------:|---------:|---------:|---------:|-----------:|
|            SmallStruct |    49.12 μs |  0.981 μs |  1.866 μs |  41.6260 |  41.6260 |  41.6260 |  256.32 KB |
|           MediumStruct |   228.81 μs |  4.344 μs |  4.267 μs | 199.7070 | 199.7070 | 199.7070 |  768.31 KB |
|            LargeStruct |   451.85 μs |  8.817 μs |  8.247 μs | 333.0078 | 333.0078 | 333.0078 | 1280.29 KB |
|       VeryLargeStructs |   707.83 μs | 11.013 μs | 10.301 μs | 664.0625 | 664.0625 | 664.0625 | 2816.19 KB |
|      SmallRecordStruct |    47.20 μs |  0.551 μs |  0.460 μs |  41.6260 |  41.6260 |  41.6260 |  256.32 KB |
|     MediumRecordStruct |   229.61 μs |  3.767 μs |  3.339 μs | 199.9512 | 199.9512 | 199.9512 |  768.31 KB |
|      LargeRecordStruct |   459.57 μs |  9.015 μs | 13.493 μs | 333.0078 | 333.0078 | 333.0078 | 1280.29 KB |
| VeryLargeRecordStructs |   725.68 μs | 14.277 μs | 19.060 μs | 666.0156 | 666.0156 | 666.0156 | 2816.19 KB |
|             SmallClass |   213.52 μs |  4.024 μs |  7.656 μs |  83.0078 |  41.5039 |  41.5039 |  490.69 KB |
|            MediumClass |   414.10 μs | 10.660 μs | 31.431 μs | 101.0742 |  60.5469 |  40.0391 |  646.95 KB |
|             LargeClass | 1,003.29 μs |  4.037 μs |  3.776 μs | 141.6016 | 102.5391 |  38.0859 |  803.19 KB |
|         VeryLargeClass | 1,135.73 μs | 21.973 μs | 32.888 μs | 220.7031 | 111.3281 |  39.0625 | 1271.98 KB |
|       SmallRecordClass |   207.24 μs |  3.614 μs |  3.381 μs |  83.0078 |  41.5039 |  41.5039 |  490.69 KB |
|      MediumRecordClass |   428.09 μs | 10.794 μs | 31.827 μs | 101.0742 |  60.5469 |  40.0391 |  646.95 KB |
|       LargeRecordClass |   997.32 μs | 14.524 μs | 13.586 μs | 141.6016 | 102.5391 |  38.0859 |  803.19 KB |
|   VeryLargeRecordClass | 1,165.73 μs | 23.163 μs | 53.222 μs | 220.7031 | 111.3281 |  39.0625 | 1271.95 KB |

## 100000

|                 Method |        Mean |     Error |    StdDev |      Gen0 |      Gen1 |     Gen2 | Allocated |
|----------------------- |------------:|----------:|----------:|----------:|----------:|---------:|----------:|
|            SmallStruct |    662.4 μs |  13.09 μs |  15.58 μs |  499.0234 |  499.0234 | 499.0234 |      2 MB |
|           MediumStruct |  1,439.1 μs |  28.57 μs |  34.02 μs |  859.3750 |  845.7031 | 843.7500 |      6 MB |
|            LargeStruct |  4,600.6 μs |  66.67 μs |  59.10 μs |  515.6250 |  500.0000 | 492.1875 |     10 MB |
|       VeryLargeStructs | 10,111.5 μs | 196.84 μs | 300.60 μs |  750.0000 |  734.3750 | 734.3750 |     22 MB |
|      SmallRecordStruct |    688.4 μs |  13.26 μs |  11.75 μs |  499.0234 |  499.0234 | 499.0234 |      2 MB |
|     MediumRecordStruct |  1,412.0 μs |  28.02 μs |  41.94 μs |  970.7031 |  955.0781 | 955.0781 |      6 MB |
|      LargeRecordStruct |  4,507.3 μs |  58.24 μs |  48.63 μs |  507.8125 |  484.3750 | 484.3750 |     10 MB |
| VeryLargeRecordStructs |  9,825.7 μs | 194.62 μs | 216.32 μs |  812.5000 |  796.8750 | 796.8750 |     22 MB |
|             SmallClass |  1,401.9 μs |  22.39 μs |  20.94 μs |  498.0469 |  498.0469 | 498.0469 |   4.29 MB |
|            MediumClass |  3,169.6 μs |  38.99 μs |  34.57 μs |  996.0938 |  496.0938 | 496.0938 |   5.82 MB |
|             LargeClass |  3,482.0 μs |  41.92 μs |  37.16 μs |  996.0938 |  496.0938 | 496.0938 |   7.34 MB |
|         VeryLargeClass | 14,330.4 μs | 199.19 μs | 186.33 μs | 2015.6250 | 1046.8750 | 500.0000 |  11.92 MB |
|       SmallRecordClass |  1,392.6 μs |  22.11 μs |  20.68 μs |  498.0469 |  498.0469 | 498.0469 |   4.29 MB |
|      MediumRecordClass |  3,188.8 μs |  60.81 μs |  56.89 μs |  996.0938 |  496.0938 | 496.0938 |   5.82 MB |
|       LargeRecordClass |  3,517.8 μs |  65.52 μs |  61.29 μs |  996.0938 |  496.0938 | 496.0938 |   7.34 MB |
|   VeryLargeRecordClass | 14,409.4 μs | 128.82 μs | 114.20 μs | 2000.0000 | 1031.2500 | 500.0000 |  11.92 MB |

## 1000000

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


</details>

<details>
  <summary>ArrayPool</summary>

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
  
</details>

<details>
  <summary>Span</summary>
  
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

</details>
