using GildedRose.Console;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class UpdateQualityWithSulfurasShould
    {
        private readonly Program target = new Program();
        private readonly Item testItem;

        public UpdateQualityWithSulfurasShould()
        {
            testItem = new Item
            {
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = 10,
                Quality = 20
            };

            target.Items = new List<Item> { testItem };
        }

        [Fact]
        public void LeaveRemainingDaysAlone()
        {
            target.UpdateQuality();

            testItem.SellIn.ShouldBe(10);
        }

        [Fact]
        public void LeaveQualityAlone()
        {
            target.UpdateQuality();

            testItem.Quality.ShouldBe(20);
        }
    }
}