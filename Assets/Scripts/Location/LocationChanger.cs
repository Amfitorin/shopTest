using System;
using Core;
using UnityEngine;

namespace Location
{
    [Serializable]
    public class LocationChanger : IReward
    {

        [SerializeField]
        private string _locationName;

        /// <inheritdoc />
        public bool Apply()
        {

            var locationManager = LocationManager.Instance;
            if (locationManager.CurrentLocation == _locationName)
                return false;
            
            locationManager.ChangeLocation(_locationName);
            return true;
        }
    }
}
