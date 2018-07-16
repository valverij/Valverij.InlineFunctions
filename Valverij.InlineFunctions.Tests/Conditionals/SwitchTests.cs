using Xunit;

namespace Valverij.InlineFunctions.Tests.Conditionals
{
    public class SwitchTests
    {
        [Fact]
        public void SwitchTests_SwitchOnInteger()
        {
            var targetMessage = "It worked!";

            var result = Inline.Switch.On(2)
                .Returns<string>()
                .Case(0).Then("Not this one")
                .Case(1).Then("Or this one")
                .Case(2).Then(targetMessage)
                .Case(3).Then("Too far!");

            Assert.Equal(targetMessage, result);
        }

        [Fact]
        public void SwitchTests_SwitchOnInteger_ReturnDefault()
        {
            var targetMessage = "It worked!";

            var result = Inline.Switch.On(2)
                .Returns<string>()
                .Case(0).Then("Not this one")
                .Case(1).Then("Or this one")
                .Case(3).Then("Too far!")
                .Default(targetMessage);

            Assert.Equal(targetMessage, result);
        }
    }
}
