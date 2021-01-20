using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for Sodasaurus
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the flavor was set correctly
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// Tests to see if the default size is small
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(Size.Small, soda.Size);
        }

        /// <summary>
        /// Tests to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.5, soda.Price);
        }

        /// <summary>
        /// Tests to see if the small price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.5, soda.Price);
        }

        /// <summary>
        /// Tests to see if the medium price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
        }

        /// <summary>
        /// Tests to see if the large price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.5, soda.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(112, soda.Calories);
        }

        /// <summary>
        /// Tests to see if the small calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(112, soda.Calories);
        }

        /// <summary>
        /// Tests to see if the medium calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(156, soda.Calories);
        }

        /// <summary>
        /// Tests to see if the large calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(208, soda.Calories);
        }

        /// <summary>
        /// Tests to see if the default has ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// Tests to see if HoldIce() removes ice
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// Tests to see if ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }
    }
}
