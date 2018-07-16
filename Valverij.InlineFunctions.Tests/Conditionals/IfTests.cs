using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valverij.InlineFunctions.Tests.Conditionals
{
    public class IfTests
    {
        [Fact]
        public void MatchesCondition()
        {
            var result = "failed";
            Inline.If(() => true).Then(() => result = "passed");
            Assert.Equal("passed", result);
        }
    }
}
