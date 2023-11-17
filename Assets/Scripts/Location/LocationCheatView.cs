using JetBrains.Annotations;
using UnityEngine;

namespace Location
{
    public class LocationCheatView : MonoBehaviour
    {
        [UsedImplicitly]
        public void CheatReset()
        {
            LocationManager.Instance.ResetLocation(); 
        }
    }
}
