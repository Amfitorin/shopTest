using UnityEngine;
using UnityEngine.UI;

namespace Health
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField]
        private Text _health;

        private void OnEnable()
        {
            HealthManager.Instance.HealthChangedEvent += OnHealthChanged;
        }

        private void OnDisable()
        {
            var healthManager = HealthManager.Instance;
            healthManager.HealthChangedEvent += OnHealthChanged;
            OnHealthChanged(healthManager.Health);
        }
        private void OnHealthChanged(int val)
        {
            _health.text = val.ToString();
        }
    }
}
