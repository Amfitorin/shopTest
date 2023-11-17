using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class PercentageDamage : IReward
    {
        [SerializeField]
        private float _percent;

        private void OnValidate()
        {
            _percent = Mathf.Clamp(_percent, 0, 100);
        }

        /// <inheritdoc />
        public bool Apply()
        {
            var currentHealth = HealthManager.Instance.Health;
            var damage = Mathf.RoundToInt(currentHealth * (_percent < 1 ? _percent : _percent / 100));
            HealthManager.Instance.Damage(damage);
            return true;
        }
    }
}
