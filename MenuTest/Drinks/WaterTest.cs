using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for Water
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Tests to see if the default size is small
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSmall()
        {
            Water agua = new Water();
            Assert.Equal(Size.Small, agua.Size);
        }

        /// <summary>
        /// Tests to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water agua = new Water();
            Assert.Equal<double>(.1, agua.Price);
        }

        /// <summary>
        /// Tests to see if the small price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water agua = new Water();
            agua.Size = Size.Small;
            Assert.Equal<double>(.1, agua.Price);
        }

        /// <summary>
        /// Tests to see if the medium price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water agua = new Water();
            agua.Size = Size.Medium;
            Assert.Equal<double>(.1, agua.Price);
        }

        /// <summary>
        /// Tests to see if the large price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water agua = new Water();
            agua.Size = Size.Large;
            Assert.Equal<double>(.1, agua.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water agua = new Water();
            Assert.Equal<double>(0, agua.Calories);
        }

        /// <summary>
        /// Tests to see if the small calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water agua = new Water();
            agua.Size = Size.Small;
            Assert.Equal<double>(0, agua.Calories);
        }

        /// <summary>
        /// Tests to see if the medium calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water agua = new Water();
            agua.Size = Size.Medium;
            Assert.Equal<double>(0, agua.Calories);
        }

        /// <summary>
        /// Tests to see if the large calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water agua = new Water();
            agua.Size = Size.Large;
            Assert.Equal<double>(0, agua.Calories);
        }

        /// <summary>
        /// Tests to see if HoldIce() sets Ice to false
        /// </summary>
        [Fact]
        public void ShouldAddIce()
        {
            Water agua = new Water();
            agua.HoldIce();
            Assert.False(agua.Ice);
        }

        /// <summary>
        /// Tests to see if AddLemon() sets Lemon to true
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water agua = new Water();
            agua.AddLemon();
            Assert.True(agua.Lemon);
        }

        /// <summary>
        /// Tests to see if ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water agua = new Water();
            agua.AddLemon();
            List<string> ingredients = agua.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
