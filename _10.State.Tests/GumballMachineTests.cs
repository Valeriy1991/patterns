using System.Diagnostics.CodeAnalysis;
using Xunit;
using _10.State.States;

namespace _10.State.Tests
{
    [ExcludeFromCodeCoverage]
    [Trait("Category", "Unit")]
    public class GumballMachineTests
    {
        private readonly GumballMachine _gumballMachine;

        public GumballMachineTests()
        {
            _gumballMachine = new GumballMachine(0);
        }

        [Fact]
        public void Ctor_GumballsIs0_DefaultStateIsSoldOut()
        {
            // Arrange
            var gumballMachine = new GumballMachine(0);
            // Act
            var state = gumballMachine.State;
            // Assert
            Assert.Equal(typeof(SoldOutState), state.GetType());
        }

        [Fact]
        public void Ctor_GumballsMoreThan0_DefaultStateIsNoQuarter()
        {
            // Arrange
            var gumballMachine = new GumballMachine(1);
            // Act
            var state = gumballMachine.State;
            // Assert
            Assert.Equal(typeof(NoQuarterState), state.GetType());
        }
    }
}