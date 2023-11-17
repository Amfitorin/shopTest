using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField]
        private Text _nameField;

        [SerializeField]
        private Button _buyButton;

        [SerializeField]
        private Image _buyImg;

        private ShopItem _item;
        private Action<ShopItem> _callback;

        public void SetData(ShopItem item, Action<ShopItem> buyCallback)
        {
            _item = item;
            _callback = buyCallback;
            _nameField.text = _item.Name;
            _item.Price.SpendStateChanged += OnSpendStateChanged;
            _item.Price.TrackState();
            var state = _item.Price.CanSpend();
            OnSpendStateChanged(state);
            gameObject.SetActive(true);
        }

        [UsedImplicitly]
        public void Buy()
        {
            _callback?.Invoke(_item);
        }
        
        private void OnSpendStateChanged(bool state)
        {
            _buyButton.enabled = state;
            _buyImg.color = state ? Color.green : Color.red;
        }

        private void OnDisable()
        {
            _item.Price.SpendStateChanged -= OnSpendStateChanged;
            _item.Price.CancelTrackState();
            _item = null;
            _callback = null;
        }

    }
}
