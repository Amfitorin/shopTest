using System;
using Core;

namespace Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        public event Action<string> LocationChangedEvent;
        public string CurrentLocation { get; private set; } = BASE_LOCATION;

        private const string BASE_LOCATION = "Тумба Юмба";

        public void ChangeLocation(string newLocation)
        {
            CurrentLocation = newLocation;
            LocationChangedEvent?.Invoke(CurrentLocation);
        }

        public void ResetLocation()
        {
            CurrentLocation = BASE_LOCATION;
            LocationChangedEvent?.Invoke(CurrentLocation);
        }
    }
}
