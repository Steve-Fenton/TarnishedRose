using GildedRose.Console;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class UpdateQualityWithStandardItemOutOfDateWithLowQualityShould
    {
        const string DEXTERITY_VEST = "+5 Dexterity Vest";
        private readonly Program target = new Program();
        private Item testItem;

        [Fact]
        public void DecreaseQualityOfTwoToZero()
        {
            testItem = new Item { SellIn = 0, Quality = 1, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(0);
        }

        [Fact]
        public void DecraseQualityOnlyToZero()
        {
            testItem = new Item { SellIn = 0, Quality = 1, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(0);
        }

        [Fact]
        public void DisallowNegativeQuality()
        {
            testItem = new Item { SellIn = 0, Quality = 0, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.UpdateQuality();

            testItem.Quality.ShouldBe(0);
        }
    }
}