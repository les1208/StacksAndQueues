using System;
using Xunit;
using StacksAndQueues;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushToStack()
        {
            //Arrange
            Stack stack = new Stack();
            //Act
            stack.Push("candy cane");
            //Assert

            Assert.Equal("candy cane", stack.Top.Value);
        }
    }
}
