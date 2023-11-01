using System.Collections.Generic;
using kata.Models;

// create list of items
List<Item> items = new List<Item>
{
    new NormalItem("+5 Dexterity Vest", 10, 20),
    new AgedBrie("Aged Brie", 2, 0),
    new NormalItem("Elixir of the Mongoose", 5, 7),
    new Sulfuras("Sulfuras, Hand of Ragnaros", 0, 80),
    new Sulfuras("Sulfuras, Hand of Ragnaros", -1, 80),
    new BackstagePasses("Backstage passes to a TAFKAL80ETC concert", 15, 20),
    new BackstagePasses("Backstage passes to a TAFKAL80ETC concert", 10, 49),
    new BackstagePasses("Backstage passes to a TAFKAL80ETC concert", 5, 49),
    new ConjuredItem("Conjured Mana Cake", 3, 6)
};

var gildedRose = new GildedRose(items);
gildedRose.UpdateQuality();
