using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny.Data
{
    [CreateAssetMenu(menuName = "Data/Actor")]
    public class Actor : ScriptableObject
    {
        public float WalkDuration = 0.0f;
        public float RunDuration = 0.0f;
    }
}
