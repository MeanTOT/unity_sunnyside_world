using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    [CreateAssetMenu(menuName = "Data/Natural")]
    public class NaturalData : ScriptableObject
    {
        public string Name = "";
        public float Hp = 0.0f;        
    }
}
