using System;

namespace Core
{
    public interface ISpendable
    {
        event Action<bool> SpendStateChanged;
        bool CanSpend();
        void Spend();
        public void TrackState();
        public void CancelTrackState();
    }
}
