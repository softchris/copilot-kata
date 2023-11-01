using kata;
using Xunit;
using kata.Models;

public class UnitTest1
{
    [Fact]
    public void Ensure_Quality()
    {
        var items = new Item[] { new Item("brie", 4, 1) };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        // print out the item name and quality
        Console.WriteLine(items[0].Name + " " + items[0].Quality);

        Assert.Equal(0, items[0].Quality);
    }

    [Fact]
    public void Ensure_Sellin()
    {
        var items = new Item[] { new Item("brie", 4, 1) };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        // print out the item name and quality
        Console.WriteLine(items[0].Name + " " + items[0].Quality);

        Assert.Equal(3, items[0].SellIn);
    }

    [Fact]
    public void NormalItemQualityDecreasesByOneEachDay()
    {
        // Arrange
        var item = new Item ("Normal Item",10,10);
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
        var item = new Item ("Normal Item", 0, 10);
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
        var item = new Item ("Aged Brie",10,10);
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
        var item = new Item("Backstage passes to a TAFKAL80ETC concert",10,10);
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
        var item = new Item ("Backstage passes to a TAFKAL80ETC concert",5,10);
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);

        // Act
        gildedRose.UpdateQuality();

        // Assert
        Assert.Equal(13, item.Quality);
    }
}