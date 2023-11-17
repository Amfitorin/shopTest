using System;
using Core;
using UnityEngine.Assertions;

namespace Gold
{
    public class GoldManager : Singleton<GoldManager>
    {

        public event Action<int> GoldChangedEvent;
        public int Gold { get; private set; }

        public void Add(int count)
        {
            Assert.IsTrue(count >= 0, "The value must be greater than zero");
            if (count == 0)
                return;
            Gold += count;
            GoldChangedEvent?.Invoke(Gold);
        }

        public void Spend(int count)
        {
            Assert.IsTrue(count >= 0, "The value must be greater than zero");
            Assert.IsTrue(count < Gold, "The value must be less than Gold");
            if (count == 0)
                return;
            Gold -= count;
            GoldChangedEvent?.Invoke(Gold);   
        }
    }
}
