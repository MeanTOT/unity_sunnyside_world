using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny.Data
{
    [CreateAssetMenu(menuName = "Data/Natural")]
    public class Natural : ScriptableObject
    {
        public string Name = "";
        public float Hp = 0.0f;        
    }
}
