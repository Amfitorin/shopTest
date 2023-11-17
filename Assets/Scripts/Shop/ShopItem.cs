using Core;

namespace Shop
{
    public class ShopItem
    {
        private readonly ISpendable _price;
        private readonly IReward _reward;
        private readonly string _name;

        public ISpendable Price => _price;

        public IReward Reward => _reward;

        public string Name => _name;

        public ShopItem(ISpendable price, IReward reward, string name)
        {
            _price = price;
            _reward = reward;
            _name = name;
        }

        public ShopItem(ShopItemConfig config)
            : this(config.Price, config.Reward, config.Name)
        {}
    }
}
