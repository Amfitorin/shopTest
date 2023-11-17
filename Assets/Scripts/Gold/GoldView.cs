using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Gold
{
    public class GoldView : MonoBehaviour
    {

        [SerializeField]
        private Text _count;

     

        private void OnEnable()
        {
            var goldManager = GoldManager.Instance;
            goldManager.GoldChangedEvent += GoldChanged;
            _count.text = goldManager.Gold.ToString();
        }
        private void GoldChanged(int gold)
        {
            _count.text = gold.ToString();
        }

        private void OnDisable()
        {
            GoldManager.Instance.GoldChangedEvent -= GoldChanged;
        }

      
        
    }
}
