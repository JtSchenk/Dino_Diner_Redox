using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for Tyrannotea
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Tests to see if the default size is small
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }

        /// <summary>
        /// Tests to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the small price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the medium price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Tests to see if the large price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the small calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the medium calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the large calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the default has no lemon
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultNoLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Tests to see if the default is not sweet
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        /// <summary>
        /// Tests to see if the lemon was added
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// Tests to see if the default has ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Tests to see if HoldIce() removes ice
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Tests to see if the default sweetened calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweetCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the small sweetened calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the medium sweetened calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the large sweetened calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<double>(64, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the default calories are correct after changing sweet to unsweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweetChangeCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the small calories are correct after changing sweet to unsweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallSweetChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the medium calories are correct after changing sweet to unsweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumSweetChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the large calories are correct after changing sweet to unsweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeSweetChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// Tests to see if ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.Sweet = true;
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
            
        }

    }
}
