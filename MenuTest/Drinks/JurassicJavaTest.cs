using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for JurassicJava
    /// </summary>
    public class JurassicJavaTest
    {

        /// <summary>
        /// Tests to see if the default has ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Ice);
        }

        /// <summary>
        /// Tests to see if the default is not decaf
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultDecaf()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Decaf);
        }

        /// <summary>
        /// Tests to see if the default has ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.RoomForCream);
        }

        /// <summary>
        /// Tests to see if the default size is small
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSmall()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal(Size.Small, coffee.Size);
        }

        /// <summary>
        /// Tests to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(.59, coffee.Price);
        }

        /// <summary>
        /// Tests to see if the small price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(.59, coffee.Price);
        }

        /// <summary>
        /// Tests to see if the medium price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(.99, coffee.Price);
        }

        /// <summary>
        /// Tests to see if the large price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(2, coffee.Calories);
        }

        /// <summary>
        /// Tests to see if the small calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(2, coffee.Calories);
        }

        /// <summary>
        /// Tests to see if the medium calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(4, coffee.Calories);
        }

        /// <summary>
        /// Tests to see if the large calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(8, coffee.Calories);
        }

        /// <summary>
        /// Tests to see if AddIce() sets Ice to true
        /// </summary>
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        /// <summary>
        /// Tests to see if LeaveSpaceForCream() sets RoomForCream to true
        /// </summary>
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }

        /// <summary>
        /// Tests to see if ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            JurassicJava coffee = new JurassicJava();
            List<string> ingredients = coffee.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

    }
}
