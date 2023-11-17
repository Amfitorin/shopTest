using System;
using Core;

namespace Health
{
    public class HealthManager : Singleton<HealthManager>
    {
        public event Action<int> HealthChangedEvent;
        
        public int Health { get; private set; }

        public void Damage(int damage)
        {
            Health = Math.Clamp(Health - damage, 0, int.MaxValue);
            HealthChangedEvent?.Invoke(Health);
        }
        
        public void Heal(int heal)
        {
            Health += heal;
            HealthChangedEvent?.Invoke(Health);
        }
    }
}
