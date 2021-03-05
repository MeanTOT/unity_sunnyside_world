using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class NullObject : IInteraction
    {
        public EInteractionType Type => EInteractionType.None;

        public void Interaction()
        {
            return;
        }
    }
}
