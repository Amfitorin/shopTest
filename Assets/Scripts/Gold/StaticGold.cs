using System;
using Core;
using UnityEngine;

namespace Gold
{
    public class StaticGold : ISpendable
    {
        [SerializeField]
        private int _count;

        private bool _prevState;

        /// <inheritdoc />
        public event Action<bool> SpendStateChanged;
        /// <inheritdoc />
        public bool CanSpend()
        {
            return GoldManager.Instance.Gold > _count;
        }
        /// <inheritdoc />
        public void Spend()
        {
            GoldManager.Instance.Spend(_count);
        }
        /// <inheritdoc />
        public void TrackState()
        {
            _prevState = CanSpend();
            GoldManager.Instance.GoldChangedEvent += OnGoldChanged;
        }
        private void OnGoldChanged(int change)
        {
            if (_prevState == CanSpend())
                return;
            _prevState = !_prevState;
            SpendStateChanged?.Invoke(_prevState);
        }
        /// <inheritdoc />
        public void CancelTrackState()
        {
            GoldManager.Instance.GoldChangedEvent -= OnGoldChanged;
        }
    }
}
