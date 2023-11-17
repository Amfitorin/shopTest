using Core;
using UnityEngine;

namespace Location
{
    public class LocationChangeReward : ScriptableObject, IReward
    {

        [SerializeField]
        private string _newLocation;
        
        /// <inheritdoc />
        public bool Apply()
        {
            LocationManager.Instance.ChangeLocation(_newLocation);
            return true;
        }
    }
}
