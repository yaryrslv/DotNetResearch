``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i5-11400 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.407
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
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
