using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QATesting
{
    [TestClass]
    public class ExtentReportDemo
    {
        [TestMethod]
        public void ExtentTestCase()
        {
            var htmlReport = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReport);

            //vars
            string hostname = Dns.GetHostName();
            OperatingSystem os = Environment.OSVersion;

            //Hard Coding
            extent.AddSystemInfo("Operating System:", os.ToString());
            extent.AddSystemInfo("HostName:", hostname);
            extent.AddSystemInfo("Browser:", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1 : Test case starts...");
            test.Log(Status.Pass, "Step 2 : Test case for Pass.");
            test.Log(Status.Fail, "Step 3 : Test case failed.");

            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");

            extent.Flush();


        }
    }
}
