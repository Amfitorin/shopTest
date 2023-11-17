using UnityEngine;
using UnityEngine.Assertions;

namespace Shop
{
    public class Store
    {
        public void Buy(ShopItem item)
        {
            var price = item.Price;
            Assert.IsTrue(price.CanSpend(), "Can't spend price");
            price.Spend();
            if (!item.Reward.Apply())
            {
                Debug.LogError($"Can't apply reward for item {item.Name}");
            }
        }
    }
}
