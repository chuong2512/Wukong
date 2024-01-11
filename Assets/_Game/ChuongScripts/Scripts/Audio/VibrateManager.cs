﻿using SinhTon;
using UnityEngine;

namespace Game
{
    public class VibrateManager /*: PersistentSingleton<VibrateManager>*/
    {
        public static bool CheckOn()
        {
            return GameDataManager.Instance.settingData.Vibration;
        }

        public static void VibrateLight()
        {
            
        }
    }
}