
using CandFarmEnums;

namespace Models
{
    public class Reward
    {
        public Item[] items;
    }

    public class Item
    {
        public string itemName;
        public string itemDescription;
        public float itemAmount;
        public ItemType itemType;
    }

    public class InGameToken
    {
        public string tokenName;
        public string tokenDescription;
        public float amount;
    }

}