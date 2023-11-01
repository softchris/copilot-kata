using System.Collections.Generic;
using Xunit;
using kata.Models;

public class UnitTest1
{
    [Fact]
    public void Ensure_Quality()
    {
        var items = new Item[] { new AgedBrie("Aged Brie", 4, 1) };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        // print out the item name and quality
        Console.WriteLine(items[0].Name + " " + items[0].Quality);

        Assert.Equal(2, items[0].Quality);
    }

    [Fact]
    public void Ensure_Sellin()
    {
        var items = new Item[] { new AgedBrie("Aged Brie", 4, 1) };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        // print out the item name and quality
        Console.WriteLine(items[0].Name + " " + items[0].SellIn);

        Assert.Equal(3, items[0].SellIn);
    }

    [Fact]
    public void NormalItemQualityDecreasesByOneEachDay()
    {
        // Arrange
        var item = new NormalItem ("Normal Item",10,10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(9, item.Quality);
    }

    [Fact]
    public void NormalItemQualityDecreasesByTwoAfterSellByDate()
    {
        // Arrange
        var item = new NormalItem ("Normal Item", 0, 10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void AgedBrieQualityIncreasesByOneEachDay()
    {
        // Arrange
        var item = new AgedBrie ("Aged Brie",10,10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void BackstagePassesQualityIncreasesByTwoWhenTenDaysOrLessLeft()
    {
        // Arrange
        var item = new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",10,10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(12, item.Quality);
    }

    [Fact]
    public void BackstagePassesQualityIncreasesByThreeWhenFiveDaysOrLessLeft()
    {
        // Arrange
        var item = new BackstagePasses ("Backstage passes to a TAFKAL80ETC concert",5,10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(13, item.Quality);
    }

    [Fact]
    public void BackstagePassesQualityDropsToZeroAfterConcert()
    {
        // Arrange
        var item = new BackstagePasses("Backstage passes to a TAFKAL80ETC concert", 0, 10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void SulfurasQualityNeverChanges()
    {
        // Arrange
        var item = new Sulfuras("Sulfuras, Hand of Ragnaros", 10, 80);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(80, item.Quality);
    }

    [Fact]
    public void ConjuredItemQualityDecreasesByTwoEachDay()
    {
        // Arrange
        var item = new ConjuredItem("Conjured Mana Cake", 10, 10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void ConjuredItemQualityDecreasesByFourAfterSellByDate()
    {
        // Arrange
        var item = new ConjuredItem("Conjured Mana Cake", 0, 10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(6, item.Quality);
    }

    [Fact]
    public void AgedBrieQualityIncreasesByTwoAfterSellByDate()
    {
        // Arrange
        var item = new AgedBrie("Aged Brie", 0, 10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(12, item.Quality);
    }
}