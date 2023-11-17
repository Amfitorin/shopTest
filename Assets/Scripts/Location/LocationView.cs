using UnityEngine;
using UnityEngine.UI;

namespace Location
{
    public class LocationView : MonoBehaviour
    {
        [SerializeField]
        private Text _location;

        private void OnEnable()
        {
            var locationManager = LocationManager.Instance;
            locationManager.LocationChangedEvent += OnLocationChanged;
            OnLocationChanged(locationManager.CurrentLocation);
        }
        private void OnLocationChanged(string location)
        {
            _location.text = location;
        }

        private void OnDisable()
        {
            LocationManager.Instance.LocationChangedEvent -= OnLocationChanged;
        }

       
    }
}
