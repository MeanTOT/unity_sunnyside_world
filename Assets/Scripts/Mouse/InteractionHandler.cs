using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class InteractionHandler
    {
        private NullObject mNullObject = null;
        private IInteraction InteractionTarget = null;

        public InteractionHandler()
        {
            mNullObject = new NullObject();
        }

        public void HandleInteraction(Player player, StateMachine sm)
        {
            if (GetInterationInternal().Type == EInteractionType.Axe)
                sm.ChangeState(player.States.Axe);
        }

        public void DoInteraction()
        {
            if (InteractionTarget != null)
            {
                InteractionTarget.Interaction();
                InteractionTarget = null;
            }
        }

        private IInteraction GetInterationInternal()
        {
            Collider2D target = Locator.Picking.GetHit().collider;

            if (target == null || (InteractionTarget = target.GetComponent<IInteraction>()) == null)
            {
                return mNullObject;
            }

            return InteractionTarget;
        }
    }
}
