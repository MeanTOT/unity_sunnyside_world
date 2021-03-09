using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    [RequireComponent(typeof(InteractionDetector))]
    public class InteractionHandler : MonoBehaviour
    {
        public void HandleInteraction(Player player, StateMachine sm)
        {
            if (player.InteractionDetector.GetInteraction().Type == EInteractionType.Axe)
                sm.ChangeState(player.States.Axe);
            else
                sm.ChangeState(player.States.Idle);
        }
    }
}
