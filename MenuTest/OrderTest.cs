using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;

namespace MenuTest
{
    /// <summary>
    /// Tests for order class
    /// </summary>
    public class OrderTest{

        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            Order order = new Order();
            MockEntree mock = new MockEntree();
            mock.Price = -4.5;
            order.Add(mock);
            Assert.Equal(0, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxTotalShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink drink = new MockDrink();
            drink.Price = 10;
            order.Add(drink);
            Assert.Equal(1, order.SalesTaxCost);
        }

        [Fact]
        public void TotalCostShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink drink = new MockDrink();
            MockEntree entree = new MockEntree();
            MockSide side = new MockSide();
            entree.Price = 15;
            side.Price = 5;
            drink.Price = 10;
            order.Add(drink);
            order.Add(entree);
            order.Add(side);
            Assert.Equal(33, order.TotalCost);
        }

    }

    class MockDrink : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public override double Price { get; set; }
    }

    class MockEntree : Entree
    {
        public override double Price { get; set; }
    }

    class MockSide : Side
    {
        public override double Price { get; set; }
    }
}
