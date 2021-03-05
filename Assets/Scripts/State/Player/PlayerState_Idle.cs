using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Idle : PlayerState
    {
        public PlayerState_Idle(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, ANIM_IDLE);            
        }

        public override void Exit()
        {
            base.Exit();            
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            Player.DoFlip((int)Locator.Input.HorizontalValue);

            if ((Locator.Input.IsHorizontalPerformed || Locator.Input.IsVerticalPerformed) && Player.InteractionDetector.CanMove())
            {
                if (Locator.Input.IsRunPerformed)
                {
                    SM.ChangeState(Player.States.Run);
                }
                else
                {
                    SM.ChangeState(Player.States.Walk);
                }                
            }            
            else if (Locator.Input.IsInteractionPerformed && Player.InteractionDetector.GetInteraction().Type != EInteractionType.None)
            {
                Player.InteractionHandler.HandleInteraction(this.Player, SM);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
