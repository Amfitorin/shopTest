using UnityEngine;

namespace Health
{
    public class HealCheatView : MonoBehaviour
    {
        [SerializeField]
        private int _cheatHealValue;

        public void CheatAddHealth()
        {
            HealthManager.Instance.Heal(_cheatHealValue);
        }
    }
}
