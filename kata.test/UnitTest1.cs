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
}