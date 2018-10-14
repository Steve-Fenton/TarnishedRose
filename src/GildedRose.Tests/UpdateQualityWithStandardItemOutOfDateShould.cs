using GildedRose.Console;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class UpdateQualityWithStandardItemOutOfDateShould
    {
        private readonly Program target = new Program();
        private readonly Item testItem;

        public UpdateQualityWithStandardItemOutOfDateShould()
        {
            testItem = new Item
            {
                Name = "+5 Dexterity Vest",
                SellIn = 0,
                Quality = 20
            };

            target.Items = new List<Item> { testItem };
        }

        [Fact]
        public void DecreaseRemainingDays()
        {
            target.UpdateQuality();

            testItem.SellIn.ShouldBe(-1);
        }

        [Fact]
        public void DecreaseQualityTwiceAsFast()
        {
            target.UpdateQuality();

            testItem.Quality.ShouldBe(18);
        }
    }
}