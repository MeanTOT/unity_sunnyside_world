using System;
using UnityEngine;

namespace Sunny
{
    public static class GameEvent
    {
        public static event Action<float> OnHorizontalWalk;
        public static void HorizontalWalk(float value)
        {
            if (OnHorizontalWalk != null)
            {
                OnHorizontalWalk(value);
            }
        }

        public static event Action<float> OnVerticalWalk;
        public static void VerticalWalk(float value)
        {
            if (OnVerticalWalk != null)
            {
                OnVerticalWalk(value);
            }
        }
    }
}
