using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Test for IOrderItem interface
    /// </summary>
    public class IOrderItemTest
    {
        #region Empty Specials
        [Theory]
        [InlineData(typeof(Brontowurst))]
        [InlineData(typeof(DinoNuggets))]
        [InlineData(typeof(PrehistoricPBJ))]
        [InlineData(typeof(PterodactylWings))]
        [InlineData(typeof(SteakosaurusBurger))]
        [InlineData(typeof(TRexKingBurger))]
        [InlineData(typeof(VelociWrap))]
        [InlineData(typeof(Fryceritops))]
        [InlineData(typeof(Triceritots))]
        [InlineData(typeof(MeteorMacAndCheese))]
        [InlineData(typeof(MezzorellaSticks))]
        [InlineData(typeof(Tyrannotea))]
        [InlineData(typeof(Sodasaurus))]
        [InlineData(typeof(JurassicJava))]
        [InlineData(typeof(Water))]
        public void SpecialShouldBeEmptyByDefault(Type type)
        {
            IOrderItem item = (IOrderItem)Activator.CreateInstance(type);
            Assert.Empty(item.Special);
        }

        #endregion

        #region Entrees Specials

        /// <summary>
        /// Tests withholding single component
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData("Hold Onion")]
        [InlineData("Hold Whole Wheat Bun")]
        [InlineData("Hold Peppers")]
        public void SingleBrontowurstSpecialShouldChange(string ans)
        {
            Brontowurst bw = new Brontowurst();
            if(ans == "Hold Onion"){ bw.HoldOnion();}
            if (ans == "Hold Whole Wheat Bun"){ bw.HoldBun();}
            else{ bw.HoldPeppers();}
            Assert.Contains(ans, bw.Special);
        }

        /// <summary>
        /// Tests if multiple ingredients can be withheld
        /// </summary>
        [Fact]
        public void AllBrontowurstSpecialShouldChange()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            bw.HoldOnion();
            bw.HoldBun();
            Assert.Contains("Hold Onion", bw.Special);
            Assert.Contains("Hold Whole Wheat Bun", bw.Special);
            Assert.Contains("Hold Peppers", bw.Special);
        }

        /// <summary>
        /// Tests adding multiple nuggets
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(12)]
        public void NuggetSpecialShouldChange(int x)
        {
            DinoNuggets dn = new DinoNuggets();
            for(int i = 0; i < x; i++) { dn.AddNugget(); }
            Assert.Contains($"{x} Extra Nuggets", dn.Special);
        }

        /// <summary>
        /// Tests withholding single component
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData("Hold Peanut Butter")]
        [InlineData("Hold Jelly")]
        public void SinglePrehistoricPBJSpecialShouldChange(string ans)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            if (ans == "Hold Peanut Butter") { pbj.HoldPeanutButter(); }
            if (ans == "Hold Jelly") { pbj.HoldJelly(); }
            Assert.Contains(ans, pbj.Special);
        }

        /// <summary>
        /// Tests if multiple ingredients can be withheld
        /// </summary>
        [Fact]
        public void BothPrehistoricPBJSpecialShouldChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            pbj.HoldPeanutButter();
            Assert.Contains("Hold Peanut Butter", pbj.Special);
            Assert.Contains("Hold Jelly", pbj.Special);
        }

        /// <summary>
        /// Tests withholding single component
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData("Hold Pickle")]
        [InlineData("Hold Whole Wheat Bun")]
        [InlineData("Hold Ketchup")]
        [InlineData("Hold Mustard")]
        public void SingleSteakosaurusBurgerSpecialShouldChange(string ans)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            if (ans == "Hold Ketchup") { sb.HoldKetchup(); }
            if (ans == "Hold Whole Wheat Bun") { sb.HoldBun(); }
            if (ans == "Hold Pickle") { sb.HoldPickle(); }
            if (ans == "Hold Mustard") { sb.HoldMustard(); }
            Assert.Contains(ans, sb.Special);
        }

        /// <summary>
        /// Tests if multiple ingredients can be withheld
        /// </summary>
        [Theory]
        [InlineData("Hold Pickle", "Hold Whole Wheat Bun", "Hold Ketchup")]
        [InlineData("Hold Whole Wheat Bun", "Hold Mustard", "Hold Ketchup")]
        [InlineData("Hold Ketchup", "Hold Ketchup", "Hold Mustard")]
        [InlineData("Hold Mustard", "Hold Pickle", "Hold Whole Wheat Bun")]
        public void MultipleSteakosaurusBurgerSpecialShouldChange(string ans1, string ans2, string ans3)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            if (ans1 == "Hold Ketchup") { sb.HoldKetchup(); }
            if (ans1 == "Hold Whole Wheat Bun") { sb.HoldBun(); }
            if (ans1 == "Hold Pickle") { sb.HoldPickle(); }
            if (ans1 == "Hold Mustard") { sb.HoldMustard(); }
            if (ans2 == "Hold Ketchup") { sb.HoldKetchup(); }
            if (ans2 == "Hold Whole Wheat Bun") { sb.HoldBun(); }
            if (ans2 == "Hold Pickle") { sb.HoldPickle(); }
            if (ans2 == "Hold Mustard") { sb.HoldMustard(); }
            if (ans3 == "Hold Ketchup") { sb.HoldKetchup(); }
            if (ans3 == "Hold Whole Wheat Bun") { sb.HoldBun(); }
            if (ans3 == "Hold Pickle") { sb.HoldPickle(); }
            if (ans3 == "Hold Mustard") { sb.HoldMustard(); }
            Assert.Contains(ans1, sb.Special);
            Assert.Contains(ans2, sb.Special);
            Assert.Contains(ans3, sb.Special);
        }

        /// <summary>
        /// Tests withholding single component
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData("Hold Pickle")]
        [InlineData("Hold Ketchup")]
        [InlineData("Hold Mustard")]
        [InlineData("Hold Mayo")]
        [InlineData("Hold Lettuce")]
        [InlineData("Hold Tomato")]
        [InlineData("Hold Onion")]
        public void SingleTRexKingBurgerSpecialShouldChange(string ans)
        {
            TRexKingBurger t = new TRexKingBurger();
            if (ans == "Hold Ketchup") { t.HoldKetchup(); }
            if (ans == "Hold Mayo") { t.HoldMayo(); }
            if (ans == "Hold Pickle") { t.HoldPickle(); }
            if (ans == "Hold Mustard") { t.HoldMustard(); }
            if (ans == "Hold Lettuce") { t.HoldLettuce(); }
            if (ans == "Hold Tomato") { t.HoldTomato(); }
            if (ans == "Hold Onion") { t.HoldOnion(); }
            Assert.Contains(ans, t.Special);
        }

        /// <summary>
        /// Tests if multiple ingredients can be withheld
        /// </summary>
        [Theory]
        [InlineData("Hold Ketchup", "Hold Mustard", "Hold Mayo", "Hold Pickle")]
        [InlineData("Hold Lettuce", "Hold Tomato","Hold Mustard", "Hold Ketchup")]
        [InlineData("Hold Onion", "Hold Ketchup", "Hold Mustard", "Hold Mayo")]
        [InlineData("Hold Mustard", "Hold Pickle", "Hold Mayo", "Hold Mayo")]
        [InlineData("Hold Lettuce", "Hold Tomato", "Hold Mayo", "Hold Pickle")]
        [InlineData("Hold Onion", "Hold Lettuce", "Hold Mustard", "Hold Ketchup")]
        public void MultipleTRexKingBurgerSpecialShouldChange(string ans1, string ans2, string ans3, string ans4)
        {
            TRexKingBurger t = new TRexKingBurger();
            if (ans1 == "Hold Ketchup") { t.HoldKetchup(); }
            if (ans1 == "Hold Mayo") { t.HoldMayo(); }
            if (ans1 == "Hold Pickle") { t.HoldPickle(); }
            if (ans1 == "Hold Mustard") { t.HoldMustard(); }
            if (ans1 == "Hold Lettuce") { t.HoldLettuce(); }
            if (ans1 == "Hold Tomato") { t.HoldTomato(); }
            if (ans1 == "Hold Onion") { t.HoldOnion(); }
            if (ans2 == "Hold Ketchup") { t.HoldKetchup(); }
            if (ans2 == "Hold Mayo") { t.HoldMayo(); }
            if (ans2 == "Hold Pickle") { t.HoldPickle(); }
            if (ans2 == "Hold Mustard") { t.HoldMustard(); }
            if (ans2 == "Hold Lettuce") { t.HoldLettuce(); }
            if (ans2 == "Hold Tomato") { t.HoldTomato(); }
            if (ans2 == "Hold Onion") { t.HoldOnion(); }
            if (ans3 == "Hold Ketchup") { t.HoldKetchup(); }
            if (ans3 == "Hold Mayo") { t.HoldMayo(); }
            if (ans3 == "Hold Pickle") { t.HoldPickle(); }
            if (ans3 == "Hold Mustard") { t.HoldMustard(); }
            if (ans3 == "Hold Lettuce") { t.HoldLettuce(); }
            if (ans3 == "Hold Tomato") { t.HoldTomato(); }
            if (ans3 == "Hold Onion") { t.HoldOnion(); }
            if (ans4 == "Hold Ketchup") { t.HoldKetchup(); }
            if (ans4 == "Hold Mayo") { t.HoldMayo(); }
            if (ans4 == "Hold Pickle") { t.HoldPickle(); }
            if (ans4 == "Hold Mustard") { t.HoldMustard(); }
            if (ans4 == "Hold Lettuce") { t.HoldLettuce(); }
            if (ans4 == "Hold Tomato") { t.HoldTomato(); }
            if (ans4 == "Hold Onion") { t.HoldOnion(); }
            Assert.Contains(ans1, t.Special);
            Assert.Contains(ans2, t.Special);
            Assert.Contains(ans3, t.Special);
        }

        /// <summary>
        /// Tests withholding single component
        /// </summary>
        /// <param name="ans">Component being withheld</param>
        [Theory]
        [InlineData("Hold Caesar Dressing")]
        [InlineData("Hold Romaine Lettuce")]
        [InlineData("Hold Parmesan Cheese")]
        public void SingleVelociWrapSpecialShouldChange(string ans)
        {
            VelociWrap vw = new VelociWrap();
            if (ans == "Hold Caesar Dressing") { vw.HoldDressing(); }
            if (ans == "Hold Romaine Lettuce") { vw.HoldLettuce(); }
            if (ans == "Hold Parmesan Cheese") { vw.HoldCheese(); }
            Assert.Contains(ans, vw.Special);
        }

        /// <summary>
        /// Tests if multiple ingredients can be withheld
        /// </summary>
        [Fact]
        public void AllVelociWrapSpecialShouldChange()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldCheese();
            vw.HoldLettuce();
            Assert.Contains("Hold Caesar Dressing", vw.Special);
            Assert.Contains("Hold Romaine Lettuce", vw.Special);
            Assert.Contains("Hold Parmesan Cheese", vw.Special);
        }

        #endregion

        #region Drink Specials

        /// <summary>
        /// Tests menu modifications
        /// </summary>
        /// <param name="ans">Modification being tested</param>
        [Theory]
        [InlineData("Leave Room For Cream", "Add Ice")]
        [InlineData("Leave Room For Cream", "Leave Room For Cream")]
        [InlineData("Add Ice", "Add Ice")]
        public void JurassicJavaSpecialShouldChange(string ans1, string ans2)
        {
            JurassicJava jj = new JurassicJava();
            if (ans1 == "Leave Room For Cream") { jj.LeaveRoomForCream(); }
            if (ans1 == "Add Ice") { jj.AddIce(); }
            if (ans2 == "Leave Room For Cream") { jj.LeaveRoomForCream(); }
            if (ans2 == "Add Ice") { jj.AddIce(); }
            Assert.Contains(ans1, jj.Special);
            Assert.Contains(ans2, jj.Special);
        }

        /// <summary>
        /// Tests menu modifications
        /// </summary>
        /// <param name="ans">Modification being tested</param>
        [Fact]
        public void SodasaurusSpecialShouldChange()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.Contains("Hold Ice", s.Special);
        }

        /// <summary>
        /// Tests menu modifications
        /// </summary>
        /// <param name="ans">Modification being tested</param>
        [Theory]
        [InlineData("Add Lemon", "Hold Ice")]
        [InlineData("Add Lemon", "Add Lemon")]
        [InlineData("Hold Ice", "Hold Ice")]
        public void TyrannoteaSpecialShouldChange(string ans1, string ans2)
        {
            Tyrannotea t = new Tyrannotea();
            if (ans1 == "Add Lemon") { t.AddLemon(); }
            if (ans1 == "Hold Ice") { t.HoldIce(); }
            if (ans2 == "Add Lemon") { t.AddLemon(); }
            if (ans2 == "Hold Ice"){ t.HoldIce(); }
            Assert.Contains(ans1, t.Special);
            Assert.Contains(ans2, t.Special);
        }

        /// <summary>
        /// Tests menu modifications
        /// </summary>
        /// <param name="ans">Modification being tested</param>
        [Theory]
        [InlineData("Add Lemon", "Hold Ice")]
        [InlineData("Add Lemon", "Add Lemon")]
        [InlineData("Hold Ice", "Hold Ice")]
        public void WaterSpecialShouldChange(string ans1, string ans2)
        {
            Water w = new Water();
            if (ans1 == "Add Lemon") { w.AddLemon(); }
            if (ans1 == "Hold Ice") { w.HoldIce(); }
            if (ans2 == "Add Lemon") { w.AddLemon(); }
            if (ans2 == "Hold Ice") { w.HoldIce(); }
            Assert.Contains(ans1, w.Special);
            Assert.Contains(ans2, w.Special);
        }

        #endregion

        #region Combo Specials

        [Fact]
        public void BrontowurstComboSpecialShouldChange()
        {
            Brontowurst bw = new Brontowurst();
            Fryceritops f = new Fryceritops();
            JurassicJava j = new JurassicJava();
            CretaceousCombo combo = new CretaceousCombo(bw);
            bw.HoldOnion();
            combo.Side = f;
            combo.Drink = j;
            j.Size = Size.Medium;
            j.AddIce();
            Assert.Equal("Hold Onion", combo.Special[0]);
            Assert.Equal("Small Fryceritops", combo.Special[1]);
            Assert.Equal("Medium Jurassic Java", combo.Special[2]);
            Assert.Equal("Add Ice", combo.Special[3]);
        }
        [Fact]
        public void DinoNuggetsComboSpecialShouldChange()
        {
            DinoNuggets dn = new DinoNuggets();
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Sodasaurus s = new Sodasaurus();
            CretaceousCombo combo = new CretaceousCombo(dn);
            combo.Side = m;
            combo.Drink = s;
            s.HoldIce();
            s.Flavor = SodasaurusFlavor.Cherry;
            m.Size = Size.Large;
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            Assert.Equal("6 Extra Nuggets", combo.Special[0]);
            Assert.Equal("Large Meteor Mac and Cheese", combo.Special[1]);
            Assert.Equal("Small Cherry Sodasaurus", combo.Special[2]);
            Assert.Equal("Hold Ice", combo.Special[3]);
        }
        [Fact]
        public void PrehistoricPBJComboSpecialShouldChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Triceritots t = new Triceritots();
            CretaceousCombo combo = new CretaceousCombo(pbj);
            Water w = new Water();
            combo.Side = t;
            combo.Drink = w;
            Assert.Equal("Small Triceritots", combo.Special[0]);
            Assert.Equal("Small Water", combo.Special[1]);
        }
        [Fact]
        public void PterodactylWingsComboSpecialShouldChange()
        {
            PterodactylWings pw = new PterodactylWings();
            MezzorellaSticks m = new MezzorellaSticks();
            CretaceousCombo combo = new CretaceousCombo(pw);
            Tyrannotea t = new Tyrannotea();
            m.Size = Size.Medium;
            combo.Side = m;
            combo.Drink = t;
            t.HoldIce();
            Assert.Equal("Medium Mezzorella Sticks", combo.Special[0]);
            Assert.Equal("Small Tyrannotea", combo.Special[1]);
            Assert.Equal("Hold Ice", combo.Special[2]);
        }
        [Fact]
        public void SteakosaurusBurgerComboSpecialShouldChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Triceritots t = new Triceritots();
            CretaceousCombo combo = new CretaceousCombo(s);
            JurassicJava j = new JurassicJava();
            combo.Side = t;
            combo.Drink = j;
            t.Size = Size.Medium;
            j.AddIce();
            s.HoldKetchup();
            Assert.Equal("Hold Ketchup", combo.Special[0]);
            Assert.Equal("Medium Triceritots", combo.Special[1]);
            Assert.Equal("Small Jurassic Java", combo.Special[2]);
            Assert.Equal("Add Ice", combo.Special[3]);
        }
        [Fact]
        public void TRexKingBurgerComboSpecialShouldChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            CretaceousCombo combo = new CretaceousCombo(t);
            Sodasaurus s = new Sodasaurus();
            combo.Side = m;
            combo.Drink = s;
            t.HoldMayo();
            Assert.Equal("Hold Mayo", combo.Special[0]);
            Assert.Equal("Small Meteor Mac and Cheese", combo.Special[1]);
            Assert.Equal("Small Cola Sodasaurus", combo.Special[2]);
        }
        [Fact]
        public void VelociwrapComboSpecialShouldChange()
        {
            VelociWrap vw = new VelociWrap();
            MezzorellaSticks m = new MezzorellaSticks();
            CretaceousCombo combo = new CretaceousCombo(vw);
            Tyrannotea t = new Tyrannotea();
            combo.Side = m;
            m.Size = Size.Large;
            t.Size = Size.Large;
            t.HoldIce();
            combo.Drink = t;
            vw.HoldDressing();
            Assert.Equal("Hold Caesar Dressing", combo.Special[0]);
            Assert.Equal("Large Mezzorella Sticks", combo.Special[1]);
            Assert.Equal("Large Tyrannotea", combo.Special[2]);
            Assert.Equal("Hold Ice", combo.Special[3]);
        }

        #endregion

        #region Entrees Description

        [Fact]
        public void BrontowurstDescriptionShouldGiveName()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }


        [Fact]
        public void DinoNuggetDescriptionShouldGiveName()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }


        [Fact]
        public void PrehistoricPBJDescriptionShouldGiveName()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void PterodactylWingsDescriptionShouldGiveName()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionShouldGiveName()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void TRexKingBurgerDescriptionShouldGiveName()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void VelociWrapDescriptionShouldGiveName()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        #endregion

        #region Sides Description

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionShouldGiveNameForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionShouldGiveNameForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldGiveNameForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.Description);
        }
        #endregion

        #region Drinks Description

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }


        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusDescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        #endregion

        #region Combos Description

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void DescriptionShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        #endregion
    }
}
