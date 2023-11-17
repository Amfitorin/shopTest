using Core;
using UnityEngine;

namespace Shop
{
    [CreateAssetMenu(menuName = "Shop/ShopITemConfig", fileName = "shopItem")]
    public class ShopItemConfig : ScriptableObject
    {
        [SerializeField, SerializeReference, SelectImplementation(typeof(IReward))]
        private IReward _reward;
        
        [SerializeField, SerializeReference, SelectImplementation(typeof(ISpendable))]
        private ISpendable _price;

        [SerializeField]
        private string _name;

        public IReward Reward => _reward;

        public ISpendable Price => _price;

        public string Name => _name;
    }
}
