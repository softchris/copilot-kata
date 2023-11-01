namespace kata.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public abstract void UpdateQuality();
    }

    public class NormalItem : Item
    {
        public NormalItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            SellIn--;

            if (SellIn < 0 && Quality > 0)
            {
                Quality--;
            }
        }
    }

    public class AgedBrie : Item
    {
        public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }

            SellIn--;

            if (SellIn < 0 && Quality < 50)
            {
                Quality++;
            }
        }
    }

    public class BackstagePasses : Item
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;

                if (SellIn < 11 && Quality < 50)
                {
                    Quality++;
                }

                if (SellIn < 6 && Quality < 50)
                {
                    Quality++;
                }
            }

            SellIn--;

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }

    public class Sulfuras : Item
    {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            // Sulfuras never changes
        }
    }

    public class ConjuredItem : Item
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality -= 2;
            }

            SellIn--;

            if (SellIn < 0 && Quality > 0)
            {
                Quality -= 2;
            }
        }
    }

    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }
    }
}
