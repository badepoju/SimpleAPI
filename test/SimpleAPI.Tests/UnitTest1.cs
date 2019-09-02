using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController ();
        [Fact]
        public void GetReturnSandra ()
        {
            var getMyValue = controller.Get (400);
            Assert.Equal ("Bowale", getMyValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
