using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class InfoMapItem : MonoBehaviour
    {
        [SerializeField] private GameObject _lock;
        [SerializeField] private Image _iconImg;

        public void SetInfo(Sprite iconMap, bool isLock)
        {
            _iconImg.sprite = iconMap;
            _iconImg.SetNativeSize();
            if (_lock)
                _lock.SetActive(isLock);
        }
    }
}