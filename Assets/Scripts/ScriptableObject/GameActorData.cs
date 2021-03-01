using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    [CreateAssetMenu(menuName = "Data/GameActor")]
    public class GameActorData : ScriptableObject
    {
        public float WalkSpeed = 0.0f;
        public float RunSpeed = 0.0f;
    }
}
