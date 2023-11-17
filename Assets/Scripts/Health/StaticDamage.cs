using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class StaticDamage : IReward
    {
        [SerializeField]
        private int _damageValue;


        /// <inheritdoc />
        public bool Apply()
        {
            HealthManager.Instance.Damage(_damageValue);
            return true;
        }
    }
}
