using System;
using Scope.Library;
using Xunit;

namespace Scope.Test
{
    public class HelloTests
    {
        [Fact]
        public void Test_WithoutName()
        {
            var result = Hello.World();
            Assert.Equal("Hello world!", result);
        }

        [Fact]
        public void Test_WithName()
        {
            var result = Hello.World("scope");
            Assert.Equal("Hello scope!", result);
        }
    }
}
