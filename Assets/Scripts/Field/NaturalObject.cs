using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class NaturalObject : MonoBehaviour, IInteraction
    {
        public NaturalData Data;

        [SerializeField] private EInteractionType mInteractionType;
        public EInteractionType Type { get => mInteractionType; }
        public void Interaction()
        {
            Debug.Log("Interaction");
        }
    }
}
