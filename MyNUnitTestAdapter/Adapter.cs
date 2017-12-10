using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNUnitTestAdapter
{
    [ExtensionUri(Id)]
    public class VsTestExecutor : ITestExecutor
    {
        public const string Id = "executor://Fixie.VisualStudio";
        public static Uri Uri = new Uri(Id);

        public void Cancel()
        {
            Debugger.Launch();
        }

        public void RunTests(IEnumerable<TestCase> tests, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            Debugger.Launch();
        }

        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            Debugger.Launch();
        }
    }

    [DefaultExecutorUri(VsTestExecutor.Id)]
    [FileExtension(".dll")]
    public class VsTestDiscoverer : ITestDiscoverer
    {
        public void DiscoverTests(IEnumerable<string> sources, IDiscoveryContext discoveryContext, IMessageLogger logger, ITestCaseDiscoverySink discoverySink)
        {
            discoverySink.SendTestCase(new TestCase("Testcase1", VsTestExecutor.Uri, "mySource"));
            discoverySink.SendTestCase(new TestCase("Testcase2", VsTestExecutor.Uri, "mySource"));
            discoverySink.SendTestCase(new TestCase("Testcase3", VsTestExecutor.Uri, "mySource"));
            Debugger.Launch();

        }
    }
}
