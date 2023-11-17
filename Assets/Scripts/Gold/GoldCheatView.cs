using JetBrains.Annotations;
using UnityEngine;

namespace Gold
{
    public class GoldCheatView : MonoBehaviour
    {
        [SerializeField]
        private int _cheatGoldCount;
        
        [UsedImplicitly]
        public void CheatGold()
        {
            GoldManager.Instance.Add(_cheatGoldCount);
        }
    }
}
