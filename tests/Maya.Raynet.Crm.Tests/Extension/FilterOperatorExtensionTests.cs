using Maya.Raynet.Crm.Extension;
using Xunit;

namespace Maya.Raynet.Crm.Tests.Extension
{
    public class FilterOperatorExtensionTests
    {
        [Theory]
        [InlineData(Model.FilterOperatorKind.Equal, "EQ")]
        [InlineData(Model.FilterOperatorKind.GreaterThan, "GT")]
        [InlineData(Model.FilterOperatorKind.LessThan, "LT")]
        [InlineData(Model.FilterOperatorKind.GreaterThanOrEqual, "GE")]
        [InlineData(Model.FilterOperatorKind.LessThanOrEqual, "LE")]
        [InlineData(Model.FilterOperatorKind.EqaulOrNull, "EQ_OR_NULL")]
        [InlineData(Model.FilterOperatorKind.In, "IN")]
        [InlineData(Model.FilterOperatorKind.Like, "LIKE")]
        [InlineData(Model.FilterOperatorKind.LikeNoCase, "LIKE_NOCASE")]
        [InlineData(Model.FilterOperatorKind.Not, "NE")]
        [InlineData(Model.FilterOperatorKind.NotIn, "NOT_IN")]
        public void Map_FromEnum_ReturnFilterString(Model.FilterOperatorKind operatorKind, string expected)
        {
            // Arrange

            // Act
            var actual = operatorKind.Map();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
