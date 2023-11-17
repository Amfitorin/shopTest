using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace Shop
{
    public class ShopView : MonoBehaviour
    {

        [SerializeField]
        private Transform _shopItemsRoot;

        [SerializeField]
        private ShopItemView _itemBase;
        
        private readonly List<ShopItemView> _items = new();

        private void OnEnable()
        {
            var shopItems = ShopManager.Instance.GetShopItems();
            foreach (var shopItem in shopItems)
            {
                var instance = Instantiate(_itemBase, _shopItemsRoot);
                instance.SetData(shopItem, data =>
                {
                    Assert.IsNotNull(data);
                    ShopManager.Instance.Store.Buy(data);
                });
                _items.Add(instance);
            }
        }

        private void OnDisable()
        {
            foreach (var item in _items)
            {
                Destroy(item);
            }
            _items.Clear();
        }
    }
}
