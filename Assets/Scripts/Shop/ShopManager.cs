using System.Linq;
using Core;

namespace Shop
{
    public class ShopManager : Singleton<ShopManager>
    {
        private readonly ShopItem[] _shopItems;

        public Store Store { get; }

        public ShopManager()
        {
            _shopItems = ShopManagerConfig.Instance.ShopItems.Select(x => new ShopItem(x)).ToArray();
            Store = new Store();
        }

        public ShopItem[] GetShopItems()
        {
            return _shopItems;
        }
        
        
    }
}
