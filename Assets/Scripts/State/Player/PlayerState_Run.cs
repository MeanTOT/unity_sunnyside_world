using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Run : PlayerState
    {
        public PlayerState_Run(Actor actor, StateMachine stateMachine) : base(actor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, ANIM_RUN);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            Player.Actions.Flip.Execute(Player.transform, (int)Locator.Input.HorizontalValue);

            if (!Locator.Input.IsHorizontalPerformed && !Locator.Input.IsVerticalPerformed)
            {
                SM.ChangeState(Player.States.Idle);
            }
            else if (!Locator.Input.IsRunPerformed)
            {
                SM.ChangeState(Player.States.Walk);
            }
            else if (Locator.Input.IsInteractionPerformed)
            {
                Locator.InteractionHandler.HandleInteraction(this.Player, SM);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

            this.Player.Actions.Move.Execute(this.Player.Rb2D, new Vector2(Locator.Input.HorizontalValue, Locator.Input.VerticalValue), Player.Data.RunSpeed);
        }
    }
}
