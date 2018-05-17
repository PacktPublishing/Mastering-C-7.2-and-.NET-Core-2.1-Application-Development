using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using static System.Environment;

namespace benchmarks
{
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(new MinimalColumnProvider());
            Add(MemoryDiagnoser.Default.GetColumnProvider());
            // Order the results by slowest to fastest
            Set(new DefaultOrderProvider(SummaryOrderPolicy.SlowestToFastest));
            Add(MarkdownExporter.GitHub);
            // Format the results as github compatible markup
            Add(new ConsoleLogger());
        }

        private sealed class MinimalColumnProvider : IColumnProvider
        {
            // Configure the column display
            public IEnumerable<IColumn> GetColumns(Summary summary)
            {
                yield return TargetMethodColumn.Method;
                yield return new JobCharacteristicColumn(InfrastructureMode.ToolchainCharacteristic);
                yield return StatisticColumn.Mean;
            }
        }
    }

    public class Program
    {
        // Configure the benchmark
        public static void Main(string[] args) => BenchmarkRunner.Run<Program>(new BenchmarkConfig());

        string[] SearchItems = Enumerable.Range(0, 1_000).Select(x => x.ToString()).ToArray();
        HashSet<string> hs = new HashSet<string>(Enumerable.Range(0, 1_000).Select(x => x.ToString()).ToArray());
        List<string> ls = new List<string>(Enumerable.Range(0, 1_000).Select(x => x.ToString()).ToArray());
        [Benchmark]
        public void SearchList()
        {
            foreach (var item in SearchItems)
            {
                ls.Contains(item);
            }
        }
        [Benchmark]
        public void SearchHashSet()
        {
            foreach (var item in SearchItems)
            {
                hs.Contains(item);
            }
        }

    }
}

