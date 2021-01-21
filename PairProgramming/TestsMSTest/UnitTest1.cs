using System.Reflection;
using Domain;
using Domain.Product;
using Domain.Product.Items;
using Domain.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, Description("")]
        public void InitShoppingCart()
        {
            ShoppingCart sc = new ShoppingCart();

            Product productA = new tshirt(10);
            Product productB = new Jean(20);

            sc.Add(productA);
            sc.Add(productB);


            Assert.AreEqual(2, sc.Products.Count);

        }

        [TestMethod, Description("Add into the cart 1 Tshirt and 1 Jean")]
        public void Sc1AddTshirtAndJean()
        {
            ShoppingCart sc = new ShoppingCart();

            Product tshirt = new tshirt(10);
            Product jean = new Jean(20);

            sc.Add(tshirt);
            sc.Add(jean);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(30, totalPrice);

        }

        [TestMethod, Description("Add into the cart 3 Jeans and the price is 40")]
        public void Buy2Jeansfor2()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);

            sc.Add(jean ,3);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(40, totalPrice);

        }
        [TestMethod, Description("Add into the cart 5 Jeans and the price is 80")]
        public void Buy5Jeansfor4()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);

            sc.Add(jean, 5);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(80, totalPrice);

        }
        [TestMethod, Description("Add into the cart 7 Jeans and the price is 100")]
        public void Buy7Jeansfor5()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);

            sc.Add(jean, 7);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(100, totalPrice);

        }

        [TestMethod, Description("Add into the cart 2 Jeans and 2 tshirt the price is 45")]
        public void Buy2Jeans2Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 2);
            sc.Add(tshirt, 2);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(45, totalPrice);

        }

        [TestMethod, Description("Add into the cart 2 Jeans and 2 tshirt the price is 90")]
        public void Buy4Jeans4Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 4);
            sc.Add(tshirt, 4);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(90, totalPrice);

        }

        [TestMethod, Description("Add into the cart 2 Jeans and 1 tshirt the price is 50")]
        public void Buy2Jeans1Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 2);
            sc.Add(tshirt, 1);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(50, totalPrice);

        }

        [TestMethod, Description("Add into the cart 2 Jeans and 6 tshirt the price is 85")]
        public void Buy2Jeans6Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 2);
            sc.Add(tshirt, 6);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(85, totalPrice);

        }

        [TestMethod, Description("Add into the cart 6 Jeans and 2 tshirt the price is 110")]
        public void Buy6Jeans2Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 6);
            sc.Add(tshirt, 2);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(105, totalPrice);

        }

        [TestMethod, Description("Add into the cart 4 Jeans and 3 tshirt the price is 75")]
        public void Buy4Jeans3Tshirt()
        {
            ShoppingCart sc = new ShoppingCart();

            Product jean = new Jean(20);
            Product tshirt = new tshirt(10);

            sc.Add(jean, 4);
            sc.Add(tshirt, 3);

            double totalPrice = sc.TotalValue();

            Assert.AreEqual(95, totalPrice);

        }
    }
}