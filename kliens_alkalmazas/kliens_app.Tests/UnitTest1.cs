using Microsoft.VisualStudio.TestTools.UnitTesting;
using kliens_alkalmazas;
using Hotcakes.CommerceDTO.v1.Client;

namespace kliens_app.Tests
{
    [TestClass]
    public class UserControlKeszletTests
    {
        [TestMethod]
        public void Raktar_API_hivas_test()
        {
            // Act
            var api = typeof(UserControlKeszlet)
                      .GetMethod("apiHivas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                      .Invoke(null, null) as Api;

            // Assert
            Assert.IsNotNull(api);
        }
    }
}
