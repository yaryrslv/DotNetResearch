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

| Method      |   Count |              Mean |            Error |            StdDev |            Median |       Gen0 |       Gen1 |      Gen2 |   Allocated |
|-------------|-------- |------------------:|-----------------:|------------------:|------------------:|-----------:|-----------:|----------:|------------:|
| **Struct8** |     **100** |          **93.99 ns** |         **1.842 ns** |          **2.262 ns** |          **93.50 ns** |     **0.1312** |          **-** |         **-** |       **824 B** |
| Struct48    |     100 |         732.70 ns |        12.172 ns |         10.790 ns |         729.11 ns |     0.6409 |          - |         - |      4024 B |
| Struct80    |     100 |       1,041.54 ns |        12.945 ns |         11.476 ns |       1,042.21 ns |     1.1501 |          - |         - |      7224 B |
| Struct144   |     100 |       1,607.62 ns |        31.862 ns |         86.683 ns |       1,584.34 ns |     2.6722 |          - |         - |     16824 B |
| Class8      |     100 |         419.85 ns |         8.248 ns |         13.081 ns |         414.81 ns |     0.5136 |     0.0057 |         - |      3224 B |
| Class48     |     100 |         591.86 ns |        11.598 ns |         12.410 ns |         592.96 ns |     1.0233 |     0.0238 |         - |      6424 B |
| Class80     |     100 |         874.76 ns |        17.531 ns |         19.486 ns |         867.52 ns |     1.5335 |     0.0505 |         - |      9624 B |
| Class144    |     100 |       1,545.83 ns |        30.816 ns |         66.334 ns |       1,531.00 ns |     3.0632 |     0.1945 |         - |     19224 B |
| **Struct8** |    **1000** |         **785.09 ns** |        **14.130 ns** |         **15.705 ns** |         **785.48 ns** |     **1.2779** |     **0.0010** |         **-** |      **8024 B** |
| Struct48    |    1000 |       7,321.46 ns |       146.440 ns |        260.297 ns |       7,276.70 ns |     6.3248 |          - |         - |     40024 B |
| Struct80    |    1000 |      11,332.89 ns |       216.099 ns |        280.990 ns |      11,322.80 ns |    11.3525 |          - |         - |     72024 B |
| Struct144   |    1000 |      66,549.79 ns |     1,297.230 ns |      3,637.572 ns |      66,774.68 ns |   249.7559 |   249.7559 |   41.6260 |    168052 B |
| Class8      |    1000 |       4,168.76 ns |        76.205 ns |         67.554 ns |       4,172.55 ns |     5.0964 |     0.5035 |         - |     32024 B |
| Class48     |    1000 |       6,147.49 ns |       122.585 ns |        298.388 ns |       6,125.02 ns |    10.2005 |     1.6937 |         - |     64024 B |
| Class80     |    1000 |       8,408.74 ns |        85.997 ns |         67.141 ns |       8,400.84 ns |    15.3046 |     3.8147 |         - |     96024 B |
| Class144    |    1000 |      16,170.21 ns |       376.830 ns |      1,105.178 ns |      15,990.47 ns |    30.6091 |     0.2441 |         - |    192024 B |
| **Struct8** |   **10000** |       **8,852.19 ns** |       **174.386 ns** |        **407.621 ns** |       **8,815.40 ns** |    **12.6495** |          **-** |         **-** |     **80024 B** |
| Struct48    |   10000 |     161,941.29 ns |     3,222.248 ns |      5,727.543 ns |     160,483.70 ns |   262.4512 |   262.4512 |   98.6328 |    400068 B |
| Struct80    |   10000 |     147,319.76 ns |     2,892.672 ns |      6,226.781 ns |     146,856.64 ns |   152.0996 |   152.0996 |  145.9961 |    720070 B |
| Struct144   |   10000 |     450,996.52 ns |    41,827.259 ns |    123,328.616 ns |     530,492.38 ns |   499.5117 |   499.5117 |  499.5117 |   1680192 B |
| Class8      |   10000 |      52,316.98 ns |       614.328 ns |        574.643 ns |      52,201.20 ns |    50.8423 |    16.9067 |         - |    320024 B |
| Class48     |   10000 |      75,778.80 ns |     1,036.953 ns |        919.231 ns |      75,536.19 ns |   101.8066 |    50.9033 |         - |    640024 B |
| Class80     |   10000 |     131,541.63 ns |     6,544.965 ns |     19,297.978 ns |     124,453.74 ns |   152.8320 |    76.4160 |         - |    960024 B |
| Class144    |   10000 |     252,811.71 ns |    15,975.224 ns |     46,852.567 ns |     226,538.87 ns |   305.6641 |   152.8320 |         - |   1920024 B |
| **Struct8** |  **100000** |     **233,637.37 ns** |     **4,568.666 ns** |      **5,438.672 ns** |     **231,676.95 ns** |   **429.4434** |   **429.4434** |  **163.3301** |    **800078 B** |
| Struct48    |  100000 |   1,172,299.15 ns |    23,250.185 ns |     37,544.715 ns |   1,169,725.59 ns |   412.1094 |   412.1094 |  343.7500 |   4000137 B |
| Struct80    |  100000 |   2,384,367.50 ns |    70,061.861 ns |    206,578.978 ns |   2,396,989.45 ns |   355.4688 |   355.4688 |  335.9375 |   7200132 B |
| Struct144   |  100000 |   4,698,045.00 ns |   142,258.073 ns |    419,451.138 ns |   4,656,503.52 ns |   343.7500 |   343.7500 |  343.7500 |  16800136 B |
| Class8      |  100000 |   1,974,077.50 ns |    11,803.005 ns |     11,040.539 ns |   1,967,142.19 ns |   498.0469 |   248.0469 |  248.0469 |   3200109 B |
| Class48     |  100000 |   5,430,400.44 ns |   101,460.226 ns |     99,647.508 ns |   5,431,667.19 ns |  1046.8750 |   515.6250 |  242.1875 |   6400112 B |
| Class80     |  100000 |   8,144,979.27 ns |   145,497.553 ns |    136,098.502 ns |   8,083,326.56 ns |  1593.7500 |   703.1250 |  296.8750 |   9600168 B |
| Class144    |  100000 |  22,011,936.58 ns |   416,845.598 ns |    428,069.739 ns |  22,004,437.50 ns |  3375.0000 |  1500.0000 |  500.0000 |  19200249 B |
| **Struct8** | **1000000** |   **2,167,807.07 ns** |    **67,999.047 ns** |    **200,496.723 ns** |   **2,151,857.62 ns** |   **300.7813** |   **300.7813** |  **300.7813** |   **8000121 B** |
| Struct48    | 1000000 |  16,511,118.96 ns |   169,277.011 ns |    158,341.821 ns |  16,557,221.88 ns |   968.7500 |   968.7500 |  968.7500 |  40000370 B |
| Struct80    | 1000000 |  28,374,733.04 ns |   186,187.019 ns |    165,049.943 ns |  28,312,015.62 ns |   968.7500 |   968.7500 |  968.7500 |  72000371 B |
| Struct144   | 1000000 |  60,754,146.83 ns |   414,191.904 ns |    367,170.334 ns |  60,762,116.67 ns |   888.8889 |   888.8889 |  888.8889 | 168000464 B |
| Class8      | 1000000 |  43,593,642.92 ns |   784,541.362 ns |    733,860.477 ns |  43,518,706.25 ns |  4562.5000 |  2187.5000 |  937.5000 |  32000388 B |
| Class48     | 1000000 |  72,249,971.43 ns |   927,840.899 ns |    867,902.953 ns |  72,650,071.43 ns | 10000.0000 |  4142.8571 | 1428.5714 |  64001296 B |
| Class80     | 1000000 |  89,101,604.76 ns | 1,325,922.688 ns |  1,175,395.927 ns |  89,546,616.67 ns | 15333.3333 |  6000.0000 | 1833.3333 |  96000924 B |
| Class144    | 1000000 | 252,870,903.70 ns | 5,024,278.318 ns | 11,544,114.960 ns | 255,444,700.00 ns | 31666.6667 | 12000.0000 | 3000.0000 | 192001400 B |
</details>

<details>
  <summary>ArrayPool</summary>

|                 Method |   Count |             Mean |           Error |          StdDev |           Median |       Gen0 |       Gen1 |      Gen2 |    Allocated |
|----------------------- |-------- |-----------------:|----------------:|----------------:|-----------------:|-----------:|-----------:|----------:|-------------:|
|   **Struct8WithArrayPool** |     **100** |         **111.3 ns** |         **2.27 ns** |         **5.07 ns** |         **109.3 ns** |     **0.1669** |          **-** |         **-** |      **1.02 KB** |
|  Struct48WithArrayPool |     100 |         644.9 ns |         4.35 ns |         3.63 ns |         644.1 ns |     0.8163 |          - |         - |      5.02 KB |
|  Struct80WithArrayPool |     100 |         864.1 ns |        10.85 ns |         9.61 ns |         860.0 ns |     1.4677 |          - |         - |      9.02 KB |
| Struct144WithArrayPool |     100 |       1,318.2 ns |        17.61 ns |        16.47 ns |       1,317.9 ns |     3.4122 |          - |         - |     21.02 KB |
|    Class8WithArrayPool |     100 |         436.4 ns |         3.39 ns |         3.01 ns |         436.0 ns |     0.5493 |     0.0067 |         - |      3.37 KB |
|   Class48WithArrayPool |     100 |         621.7 ns |         3.92 ns |         3.06 ns |         621.8 ns |     1.0595 |     0.0248 |         - |      6.49 KB |
|   Class80WithArrayPool |     100 |         869.4 ns |         9.06 ns |         8.03 ns |         869.6 ns |     1.5697 |     0.0553 |         - |      9.62 KB |
|  Class144WithArrayPool |     100 |       1,427.9 ns |        15.68 ns |        13.09 ns |       1,425.3 ns |     3.0994 |     0.2022 |         - |     18.99 KB |
|   **Struct8WithArrayPool** |    **1000** |         **592.5 ns** |         **4.57 ns** |         **4.28 ns** |         **593.9 ns** |     **1.3046** |          **-** |         **-** |      **8.02 KB** |
|  Struct48WithArrayPool |    1000 |       5,997.7 ns |        46.42 ns |        43.42 ns |       5,986.4 ns |     6.4926 |          - |         - |     40.02 KB |
|  Struct80WithArrayPool |    1000 |       8,650.1 ns |        51.57 ns |        43.06 ns |       8,629.1 ns |    11.6272 |          - |         - |     72.02 KB |
| Struct144WithArrayPool |    1000 |      65,439.1 ns |       582.74 ns |       516.58 ns |      65,335.5 ns |   249.7559 |   249.7559 |   41.6260 |    168.05 KB |
|    Class8WithArrayPool |    1000 |       4,241.3 ns |        56.90 ns |        53.22 ns |       4,237.7 ns |     5.1270 |     0.5112 |         - |     31.46 KB |
|   Class48WithArrayPool |    1000 |       5,909.6 ns |       111.15 ns |       114.14 ns |       5,847.1 ns |    10.2310 |     1.7700 |         - |     62.71 KB |
|   Class80WithArrayPool |    1000 |       8,395.8 ns |       101.27 ns |        89.78 ns |       8,421.0 ns |    15.3351 |     3.0670 |         - |     93.96 KB |
|  Class144WithArrayPool |    1000 |      14,836.8 ns |       129.39 ns |       101.02 ns |      14,827.8 ns |    30.6396 |    11.1084 |         - |    187.71 KB |
|   **Struct8WithArrayPool** |   **10000** |      **26,903.0 ns** |       **278.36 ns** |       **260.38 ns** |      **26,872.3 ns** |    **41.6565** |    **41.6565** |   **41.6565** |    **128.04 KB** |
|  Struct48WithArrayPool |   10000 |     165,052.0 ns |     2,631.64 ns |     2,461.64 ns |     165,260.1 ns |   199.9512 |   199.9512 |  199.9512 |    640.09 KB |
|  Struct80WithArrayPool |   10000 |     279,140.8 ns |     2,910.68 ns |     2,430.55 ns |     279,744.8 ns |   333.0078 |   333.0078 |  333.0078 |   1152.13 KB |
| Struct144WithArrayPool |   10000 |     282,437.1 ns |    12,039.57 ns |    35,498.94 ns |     263,670.2 ns |   325.6836 |   325.6836 |  325.6836 |   2688.12 KB |
|    Class8WithArrayPool |   10000 |      97,041.8 ns |       777.54 ns |       727.31 ns |      96,914.2 ns |    41.6260 |    41.6260 |   41.6260 |    362.41 KB |
|   Class48WithArrayPool |   10000 |     501,891.8 ns |    11,124.69 ns |    32,801.40 ns |     509,055.8 ns |   117.1875 |    78.1250 |   39.0625 |    674.91 KB |
|   Class80WithArrayPool |   10000 |     900,515.8 ns |    17,842.08 ns |    48,842.41 ns |     907,721.3 ns |   173.8281 |   107.4219 |   40.0391 |    987.42 KB |
|  Class144WithArrayPool |   10000 |   1,122,014.5 ns |    22,114.90 ns |    25,467.55 ns |   1,124,458.1 ns |   328.1250 |   173.8281 |   68.3594 |   1924.93 KB |
|   **Struct8WithArrayPool** |  **100000** |     **251,721.6 ns** |     **3,081.20 ns** |     **2,882.15 ns** |     **251,636.5 ns** |   **333.0078** |   **333.0078** |  **333.0078** |   **1024.13 KB** |
|  Struct48WithArrayPool |  100000 |   1,097,118.8 ns |    14,834.58 ns |    13,150.47 ns |   1,098,952.8 ns |   363.2813 |   363.2813 |  363.2813 |   5120.14 KB |
|  Struct80WithArrayPool |  100000 |   2,029,955.2 ns |    40,110.31 ns |    86,341.68 ns |   2,022,686.9 ns |   398.4375 |   398.4375 |  398.4375 |   9216.15 KB |
| Struct144WithArrayPool |  100000 |   5,287,464.9 ns |   140,275.77 ns |   413,606.27 ns |   5,397,146.5 ns |   406.2500 |   406.2500 |  406.2500 |  21504.15 KB |
|    Class8WithArrayPool |  100000 |   3,570,457.4 ns |    11,096.89 ns |    10,380.04 ns |   3,570,169.9 ns |   535.1563 |   457.0313 |  304.6875 |    3367.9 KB |
|   Class48WithArrayPool |  100000 |   5,641,567.2 ns |    94,587.99 ns |    88,477.67 ns |   5,599,684.0 ns |  1078.1250 |   585.9375 |  304.6875 |   6492.91 KB |
|   Class80WithArrayPool |  100000 |   6,657,290.2 ns |   112,325.82 ns |   105,069.65 ns |   6,652,571.9 ns |  1609.3750 |   773.4375 |  367.1875 |   9617.95 KB |
|  Class144WithArrayPool |  100000 |  19,874,888.8 ns |   101,265.65 ns |    89,769.36 ns |  19,891,206.2 ns |  3375.0000 |  1500.0000 |  500.0000 |  18992.99 KB |
|   **Struct8WithArrayPool** | **1000000** |   **1,618,861.0 ns** |    **36,328.98 ns** |   **107,116.83 ns** |   **1,602,700.1 ns** |   **453.1250** |   **453.1250** |  **453.1250** |   **8192.16 KB** |
|  Struct48WithArrayPool | 1000000 |  16,717,869.0 ns |    91,635.55 ns |    81,232.53 ns |  16,753,631.2 ns |   968.7500 |   968.7500 |  968.7500 |  40960.36 KB |
|  Struct80WithArrayPool | 1000000 |  28,243,196.7 ns |   161,348.88 ns |   143,031.58 ns |  28,191,929.7 ns |   968.7500 |   968.7500 |  968.7500 |  73728.36 KB |
| Struct144WithArrayPool | 1000000 |  60,484,982.9 ns |   336,360.79 ns |   280,876.49 ns |  60,481,333.3 ns |   888.8889 |   888.8889 |  888.8889 | 172032.87 KB |
|    Class8WithArrayPool | 1000000 |  43,783,542.5 ns |   700,125.44 ns |   654,897.77 ns |  44,067,912.5 ns |  4562.5000 |  2187.5000 |  937.5000 |  31629.88 KB |
|   Class48WithArrayPool | 1000000 |  72,745,489.0 ns | 1,017,896.98 ns |   849,990.08 ns |  72,988,414.3 ns | 10000.0000 |  4142.8571 | 1428.5714 |  62880.72 KB |
|   Class80WithArrayPool | 1000000 |  91,243,270.4 ns | 1,818,865.62 ns | 4,629,593.73 ns |  89,817,800.0 ns | 15333.3333 |  6000.0000 | 1833.3333 |   94130.3 KB |
|  Class144WithArrayPool | 1000000 | 226,337,891.7 ns | 4,512,341.70 ns | 5,867,318.79 ns | 226,187,700.0 ns | 32000.0000 | 12333.3333 | 2666.6667 | 187880.73 KB |
</details>

<details>
  <summary>Span</summary>

|            Method |   Count |              Mean |            Error |           StdDev |            Median |       Gen0 |       Gen1 |      Gen2 |   Allocated |
|------------------ |-------- |------------------:|-----------------:|-----------------:|------------------:|-----------:|-----------:|----------:|------------:|
|   **Struct8WithSpan** |     **100** |          **92.60 ns** |         **1.844 ns** |         **3.325 ns** |          **91.36 ns** |     **0.1311** |     **0.0002** |         **-** |       **824 B** |
|  Struct48WithSpan |     100 |         736.26 ns |         6.228 ns |         5.826 ns |         733.81 ns |     0.6409 |     0.0095 |         - |      4024 B |
|  Struct80WithSpan |     100 |         937.18 ns |         5.661 ns |         5.295 ns |         935.88 ns |     1.1501 |     0.0296 |         - |      7224 B |
| Struct144WithSpan |     100 |       1,497.93 ns |         9.469 ns |         7.907 ns |       1,496.38 ns |     2.6722 |     0.1564 |         - |     16824 B |
|    Class8WithSpan |     100 |         391.34 ns |         3.695 ns |         3.276 ns |         391.03 ns |     0.5136 |     0.0119 |         - |      3224 B |
|   Class48WithSpan |     100 |         587.88 ns |         6.881 ns |         6.437 ns |         584.85 ns |     1.0233 |     0.0458 |         - |      6424 B |
|   Class80WithSpan |     100 |         804.14 ns |         7.810 ns |         7.306 ns |         805.55 ns |     1.5335 |     0.1011 |         - |      9624 B |
|  Class144WithSpan |     100 |       1,446.42 ns |        16.989 ns |        15.061 ns |       1,445.74 ns |     3.0632 |     0.3681 |         - |     19224 B |
|   **Struct8WithSpan** |    **1000** |         **798.47 ns** |         **5.998 ns** |         **5.610 ns** |         **800.46 ns** |     **1.2779** |     **0.0372** |         **-** |      **8024 B** |
|  Struct48WithSpan |    1000 |       7,225.92 ns |        39.188 ns |        36.656 ns |       7,219.63 ns |     6.3248 |     0.7858 |         - |     40024 B |
|  Struct80WithSpan |    1000 |      11,215.49 ns |        57.456 ns |        53.745 ns |      11,210.50 ns |    11.3525 |     2.2583 |         - |     72024 B |
| Struct144WithSpan |    1000 |      19,834.74 ns |       187.981 ns |       175.837 ns |      19,779.39 ns |    52.6123 |    52.6123 |   52.6123 |    168042 B |
|    Class8WithSpan |    1000 |       3,994.66 ns |        20.135 ns |        17.849 ns |       3,994.07 ns |     5.0964 |     0.8469 |         - |     32024 B |
|   Class48WithSpan |    1000 |       5,770.36 ns |        62.956 ns |        58.889 ns |       5,751.86 ns |    10.2005 |     2.5482 |         - |     64024 B |
|   Class80WithSpan |    1000 |       9,027.06 ns |        95.697 ns |        84.833 ns |       8,989.99 ns |    15.3046 |     5.0964 |         - |     96024 B |
|  Class144WithSpan |    1000 |      15,972.56 ns |       208.237 ns |       194.785 ns |      15,920.32 ns |    30.6091 |     9.6130 |         - |    192024 B |
|   **Struct8WithSpan** |   **10000** |       **8,401.06 ns** |       **101.664 ns** |        **90.122 ns** |       **8,390.17 ns** |    **12.6495** |     **2.5177** |         **-** |     **80024 B** |
|  Struct48WithSpan |   10000 |      78,914.02 ns |       803.247 ns |       751.358 ns |      78,735.24 ns |   124.8779 |   124.8779 |  124.8779 |    400066 B |
|  Struct80WithSpan |   10000 |     131,131.28 ns |     1,742.562 ns |     1,629.994 ns |     131,394.38 ns |   146.9727 |   146.9727 |  146.9727 |    720070 B |
| Struct144WithSpan |   10000 |     385,687.42 ns |     7,300.422 ns |     7,811.369 ns |     387,107.71 ns |   224.1211 |   224.1211 |  224.1211 |   1680094 B |
|    Class8WithSpan |   10000 |      57,692.91 ns |       407.031 ns |       360.822 ns |      57,674.86 ns |    50.8423 |    25.3906 |         - |    320024 B |
|   Class48WithSpan |   10000 |     102,442.33 ns |     1,062.645 ns |       942.007 ns |     102,174.13 ns |   101.8066 |    50.9033 |         - |    640024 B |
|   Class80WithSpan |   10000 |     154,152.20 ns |     2,412.807 ns |     2,256.941 ns |     152,947.73 ns |   152.8320 |    76.4160 |         - |    960024 B |
|  Class144WithSpan |   10000 |     349,980.58 ns |     5,366.623 ns |     4,757.371 ns |     348,105.10 ns |   305.6641 |   152.8320 |         - |   1920024 B |
|   **Struct8WithSpan** |  **100000** |      **98,452.31 ns** |       **932.437 ns** |       **872.202 ns** |      **98,754.46 ns** |   **249.8779** |   **249.8779** |  **249.8779** |    **800108 B** |
|  Struct48WithSpan |  100000 |   1,692,735.20 ns |    33,852.717 ns |    81,758.117 ns |   1,688,124.22 ns |   224.6094 |   224.6094 |  224.6094 |   4000096 B |
|  Struct80WithSpan |  100000 |   3,132,851.25 ns |    62,290.300 ns |   161,900.771 ns |   3,196,000.78 ns |   246.0938 |   246.0938 |  246.0938 |   7200106 B |
| Struct144WithSpan |  100000 |   5,601,497.92 ns |   109,361.704 ns |   117,015.798 ns |   5,611,818.75 ns |   179.6875 |   179.6875 |  179.6875 |  16800087 B |
|    Class8WithSpan |  100000 |   1,943,178.35 ns |     8,134.739 ns |     7,609.240 ns |   1,941,393.16 ns |   496.0938 |   246.0938 |  246.0938 |   3200109 B |
|   Class48WithSpan |  100000 |   6,920,068.53 ns |   133,835.481 ns |   118,641.668 ns |   6,911,010.16 ns |  1085.9375 |   500.0000 |  226.5625 |   6400106 B |
|   Class80WithSpan |  100000 |   8,948,412.71 ns |   176,040.019 ns |   303,660.383 ns |   8,955,438.28 ns |  1609.3750 |   687.5000 |  265.6250 |   9600137 B |
|  Class144WithSpan |  100000 |  21,296,886.20 ns |    69,015.891 ns |    53,883.068 ns |  21,280,206.25 ns |  3375.0000 |  1437.5000 |  468.7500 |  19200235 B |
|   **Struct8WithSpan** | **1000000** |   **3,141,163.21 ns** |    **62,607.331 ns** |   **158,216.715 ns** |   **3,189,228.91 ns** |   **167.9688** |   **167.9688** |  **167.9688** |   **8000081 B** |
|  Struct48WithSpan | 1000000 |  15,751,957.29 ns |   298,977.146 ns |   319,902.197 ns |  15,731,469.53 ns |   250.0000 |   250.0000 |  250.0000 |  40000115 B |
|  Struct80WithSpan | 1000000 |  29,121,434.38 ns |   579,942.404 ns |   952,862.000 ns |  29,058,621.88 ns |   218.7500 |   218.7500 |  218.7500 |  72000115 B |
| Struct144WithSpan | 1000000 |  58,162,820.99 ns | 1,151,629.745 ns | 1,232,230.925 ns |  58,340,033.33 ns |   333.3333 |   333.3333 |  333.3333 | 168000232 B |
|    Class8WithSpan | 1000000 |  51,881,955.71 ns |   750,693.434 ns |   665,470.176 ns |  51,877,340.00 ns |  4500.0000 |  2000.0000 |  700.0000 |  32000330 B |
|   Class48WithSpan | 1000000 |  71,609,374.29 ns | 1,385,818.611 ns | 1,296,295.588 ns |  71,699,900.00 ns |  9857.1429 |  4000.0000 | 1000.0000 |  64001887 B |
|   Class80WithSpan | 1000000 | 116,737,583.33 ns | 2,150,959.118 ns | 2,112,529.463 ns | 116,822,366.67 ns | 15166.6667 |  5833.3333 | 1166.6667 |  96002224 B |
|  Class144WithSpan | 1000000 | 206,319,991.06 ns | 4,072,815.430 ns | 7,344,126.338 ns | 206,420,000.00 ns | 31000.0000 | 11666.6667 | 1666.6667 | 192000875 B |
</details>
