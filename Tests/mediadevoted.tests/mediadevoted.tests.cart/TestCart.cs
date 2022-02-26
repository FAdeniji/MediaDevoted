using mediadevoted.api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Threading.Tasks;
using mediadevoted.domain.Entities;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using MyTested.WebApi;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace mediadevoted.tests.mediadevoted.tests.cart
{
    /// <summary>
    /// Summary description for TestCart
    /// </summary>
    [TestClass]
    public class TestCart
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public async Task Ensure_cart_is_emptyAsync()
        {
            var cartController = new CartController();

            var cart = await cartController.FetchCart();

            Assert.IsNull(cart);
        }

        [TestMethod]
        public async Task Adding_items_to_cart_return_the_recently_added_cart()
        {
            var newCart = new Cart()
            {
                Id = 3
            };
            var cartController = new CartController();

            var cart = await cartController.AddToCart(newCart);

            Assert.IsNull(cart);
        }
    }
}
