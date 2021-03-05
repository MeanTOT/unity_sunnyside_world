using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public enum EInteractionType
    {
        None,
        Axe,
    }

    public interface IInteraction
    {
        EInteractionType Type { get; }

        public void Interaction();
    }
}
