using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Maya.Raynet.Crm.Tests
{
    public class LicenseTests
    {
        [Fact]
        public void ShouldHaveCurrentYearInLicense()
        {
            var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            var line = File.ReadLines(Path.Combine(directoryInfo.Parent.Parent.Parent.Parent.Parent.FullName, "LICENSE.md"))
                .Skip(2)
                .Take(1)
                .First();

            Assert.Contains(DateTime.Now.Year.ToString(), line);
        }
    }
}
