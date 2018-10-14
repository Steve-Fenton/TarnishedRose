using GildedRose.Console;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class UpdateQualityWithAgedBrieShould
    {
        const string AGED_BRIE = "Aged Brie";
        private readonly Program target = new Program();
        private Item testItem;

        [Fact]
        public void DecreaseRemainingDays()
        {
            testItem = new Item
            {
                Name = AGED_BRIE,
                SellIn = 10,
                Quality = 20
            };

            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.SellIn.ShouldBe(9);
        }

        [Fact]
        public void IncreaseQualityWhenBelowFifty()
        {
            testItem = new Item
            {
                Name = AGED_BRIE,
                SellIn = 10,
                Quality = 49
            };

            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(50);
        }

        [Fact]
        public void LimitQualityToFifty()
        {
            testItem = new Item
            {
                Name = AGED_BRIE,
                SellIn = 10,
                Quality = 50
            };

            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(50);
        }

        [Fact]
        public void IncreaseQualityTwiceAsFastAfterSaleDeadline()
        {
            // Note: Case discovered during characterisation
            testItem = new Item
            {
                Name = AGED_BRIE,
                SellIn = 0,
                Quality = 48
            };

            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(50);
        }

        [Fact]
        public void LimitQualityToFiftyWhenRateHasDoubled()
        {
            // Note: Case discovered during characterisation
            testItem = new Item
            {
                Name = AGED_BRIE,
                SellIn = 0,
                Quality = 49
            };

            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(50);
        }
    }
}