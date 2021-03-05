using The_barista;
using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeansAndMilkFoam_Expect_Macchiato(){
            // Act
            IBeverage macchiato = new FluentEspresso().AddCoffeeBeans(new Beans(4, Beans.CoffeeBean.Arabica)).AddMilkFoam().ToBeverage();
            // Assert
            Assert.IsType<Macchiato>(macchiato);
        }
        
        [Fact]
        public void When_AddingWaterAndBeansAndMilk_Expect_Latte()
        {
            // Act
            IBeverage latte = new FluentEspresso().AddCoffeeBeans(new Beans(4, Beans.CoffeeBean.Arabica)).AddMilk().ToBeverage();
            // Assert
            Assert.IsType<Latte>(latte);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilkAndMilkFoamAndChocolate_Expect_Mocha()
        {
            // Act
            IBeverage mocha = new FluentEspresso().AddCoffeeBeans(new Beans(4, Beans.CoffeeBean.Arabica)).AddMilk().AddMilkFoam().AddChocolateSyrup().ToBeverage();
            // Assert
            Assert.IsType<Mocha>(mocha);
        }

        [Fact]
        public void When_AddingNothing_Expect_Nothing()
        {
            // Act
            IBeverage nothing = new FluentEspresso().ToBeverage();
            // Assert
            Assert.IsType<Nothing>(nothing);
        }
        [Fact]
        public void When_AddingWater_Expect_Other()
        {
            // Act
            IBeverage other = new FluentEspresso().AddHotWater(100).ToBeverage();
            // Assert
            Assert.IsType<Other>(other);
        }
    }
}