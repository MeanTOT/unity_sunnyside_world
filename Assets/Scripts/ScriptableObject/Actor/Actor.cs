using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny.Data
{
    [CreateAssetMenu(menuName = "Data/Actor")]
    public class Actor : ScriptableObject
    {
        public float WalkSpeed = 0.0f;
        public float RunSpeed= 0.0f;
    }
}
