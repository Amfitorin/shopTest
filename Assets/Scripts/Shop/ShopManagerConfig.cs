using UnityEngine;

namespace Shop
{
    [CreateAssetMenu(menuName = "Managers/ShopManagerConfig", fileName = "ShopManagerConfig")]
    public class ShopManagerConfig : ScriptableObject
    {
        [SerializeField]
        private ShopItemConfig[] _shopItems;

        public ShopItemConfig[] ShopItems => _shopItems;

        private static ShopManagerConfig _instance;

        public static ShopManagerConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Resources.Load<ShopManagerConfig>($"Managers/Shop/ShopManagerConfig");
                }
                return _instance;
            }
        }
    }
}
