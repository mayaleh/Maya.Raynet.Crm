using Maya.Raynet.Crm.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Maya.Raynet.Crm.Tests.Extension
{
    public class SortDirectionExtensionTests
    {

        [Theory]
        [InlineData(Model.SortDirectionKind.Asc, "ASC")]
        [InlineData(Model.SortDirectionKind.Desc, "DESC")]
        public void Map_FromEnum_ReturnFilterString(Model.SortDirectionKind sortKind, string expected)
        {
            // Arrange

            // Act
            var actual = sortKind.Map();

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
