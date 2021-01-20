using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Tests for event handling
    /// </summary>
    public class PropertyChangedTest
    {
        #region Drinks

        #region Sizes
        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void SodaSizeChangeShouldNotify(Size size, string prop)
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, prop, () =>
              {
                  s.Size = size;
              }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void JurassicJavaSizeChangeShouldNotify(Size size, string prop)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, prop, () =>
            {
                java.Size = size;
            }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void TyrannoteaSizeChangeShouldNotify(Size size, string prop)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, prop, () =>
            {
                tea.Size = size;
            }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Description")]
        public void WaterSizeChangeShouldNotify(Size size, string prop)
        {
            Water agua = new Water();
            Assert.PropertyChanged(agua, prop, () =>
            {
                agua.Size = size;
            }
            );
        }
        #endregion

        [Theory]
        [InlineData(typeof(Tyrannotea))]
        [InlineData(typeof(Sodasaurus))]
        [InlineData(typeof(Water))]
        public void HoldIceChangeShouldNotify(Type type)
        {
            Drink s = (Drink)Activator.CreateInstance(type);
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            }
            );
        }

        [Fact]
        public void WaterAddLemonShouldNotify()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            }
            );
        }

        [Fact]
        public void TeaAddLemonShouldNotify()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            }
            );
        }

        [Theory]
        [InlineData(SodasaurusFlavor.Cherry)]
        [InlineData(SodasaurusFlavor.Chocolate)]
        [InlineData(SodasaurusFlavor.Cola)]
        [InlineData(SodasaurusFlavor.Lime)]
        [InlineData(SodasaurusFlavor.Orange)]
        [InlineData(SodasaurusFlavor.RootBeer)]
        [InlineData(SodasaurusFlavor.Vanilla)]
        public void SodaFlavorShouldNotify(SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Flavor= flavor;
            }
            );
        }

        [Fact]
        public void MakeRoomForCreamShouldNotify()
        {
            JurassicJava j = new JurassicJava(); 
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.LeaveRoomForCream();
            }
            );
        }

        [Fact]
        public void JavaAddIceShouldNotify()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddIce();
            }
            );
        }

        [Fact]
        public void JavaDecafShouldNotify()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Decaf = true;
            }
            );
        }

        [Fact]
        public void SweetTeaShouldNotify()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Sweet = true;
            }
            );
        }
        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void FryceritopsSizeChangeShouldNotify(Size size, string prop)
        {
            Fryceritops fries = new Fryceritops();
            Assert.PropertyChanged(fries, prop, () =>
            {
                fries.Size = size;
            }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void MeteorMacAndCheeseSizeChangeShouldNotify(Size size, string prop)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, prop, () =>
            {
                mac.Size = size;
            }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void MezzorellaSticksSizeChangeShouldNotify(Size size, string prop)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, prop, () =>
            {
                ms.Size = size;
            }
            );
        }

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Small, "Description")]
        public void TriceritotsSizeChangeShouldNotify(Size size, string prop)
        {
            Triceritots tots = new Triceritots();
            Assert.PropertyChanged(tots, prop, () =>
            {
                tots.Size = size;
            }
            );
        }

        #endregion

        #region Entree

        #region Brontowurst

        [Fact]
        public void BrontowurstBunShouldNotify()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            }
            );
        }
        [Fact]
        public void BrontowurstOnionShouldNotify()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            }
            );
        }
        [Fact]
        public void BrontowurstPeppersShouldNotify()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            }
            );
        }


        #endregion

        [Theory]
        [InlineData("Special")]
        [InlineData("Price")]
        public void DinoNuggetsAdditionShouldNotify(string prop)
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, prop, () =>
            {
                dn.AddNugget();
            }
            );
        }

        [Fact]
        public void PBJPeanutButterShouldNotify()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            }
            );
        }

        [Fact]
        public void PBJJellyShouldNotify()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            }
            );
        }

        #region SteakosaurusBurger

        [Fact]
        public void SteakosaurusBunShouldNotify()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            }
            );
        }

        [Fact]
        public void SteakosaurusPickleShouldNotify()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            }
            );
        }

        [Fact]
        public void SteakosaurusKetchupShouldNotify()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            }
            );
        }

        [Fact]
        public void SteakosaurusMustardShouldNotify()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            }
            );
        }

        #endregion

        #region TRexKingBurger

        [Fact]
        public void KingBurgerBunShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldBun();
            }
            );
        }

        [Fact]
        public void KingBurgerLettuceShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldLettuce();
            }
            );
        }

        [Fact]
        public void KingBurgerTomatoShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldTomato();
            }
            );
        }

        [Fact]
        public void KingBurgerOnionShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldOnion();
            }
            );
        }

        [Fact]
        public void KingBurgerPickleShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldPickle();
            }
            );
        }

        [Fact]
        public void KingBurgerKetchupShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldKetchup();
            }
            );
        }

        [Fact]
        public void KingBurgerMustardShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldMustard();
            }
            );
        }

        [Fact]
        public void KingBurgerMayoShouldNotify()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, "Special", () =>
            {
                king.HoldMayo();
            }
            );
        }

        #endregion

        [Fact]
        public void VelociWrapDressingShouldNotify()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldDressing();
            }
            );
        }

        [Fact]
        public void VelociWrapCheeseShouldNotify()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldCheese();
            }
            );
        }

        [Fact]
        public void VelociWrapLettuceShouldNotify()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldLettuce();
            }
            );
        }

        #endregion

        #region Combo

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ComboEntreeChangeShouldNotify(string prop)
        {
            Brontowurst bw = new Brontowurst();
            TRexKingBurger t = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(bw);
            Assert.PropertyChanged(combo, prop, () =>
            {
                combo.Entree = t;
            }
            );
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ComboSideChangeShouldNotify(string prop)
        {
            Brontowurst bw = new Brontowurst();
            Tyrannotea t = new Tyrannotea();
            CretaceousCombo combo = new CretaceousCombo(bw);
            Assert.PropertyChanged(combo, prop, () =>
            {
                combo.Drink = t;
            }
            );
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ComboDrinkChangeShouldNotify(string prop)
        {
            Brontowurst bw = new Brontowurst();
            Triceritots t = new Triceritots();
            CretaceousCombo combo = new CretaceousCombo(bw);
            Assert.PropertyChanged(combo, prop, () =>
            {
                combo.Side = t;
            }
            );
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ComboSizeChangeShouldNotify(string prop)
        {
            Brontowurst bw = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(bw);
            Assert.PropertyChanged(combo, prop, () =>
            {
                combo.Size = Size.Large;
            }
            );
        }

        #endregion
    }
}
