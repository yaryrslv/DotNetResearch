﻿using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using ClassAndStruct;

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance)
    .AddExporter(RPlotExporter.Default, CsvExporter.Default, MarkdownExporter.GitHub, HtmlExporter.Default);

BenchmarkRunner.Run<WriteBenchmark>(config);