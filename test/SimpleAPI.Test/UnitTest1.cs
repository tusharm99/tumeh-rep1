using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(5);
            Assert.Equal("something else - fail test", returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
